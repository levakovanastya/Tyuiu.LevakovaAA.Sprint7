using Microsoft.VisualBasic.FileIO;
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.LevakovaAA.Sprint7.Project.V14
{
    public partial class FormMain_LAA : Form
    {
        public FormMain_LAA()
        {
            InitializeComponent();
            openFileDialog_LAA.Filter = "Значения разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_LAA.Filter = "Значения разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";


        }
        static string openFilePath;
        private void openFileDialog_LAA_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void saveFileDialog_LAA_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void FormMain_LAA_Load(object sender, EventArgs e)
        {

        }

        private void buttonHelp_LAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (openFileDialog_LAA.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialog_LAA.FileName;
                using (TextFieldParser parser = new TextFieldParser(openFilePath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(";");
                    parser.HasFieldsEnclosedInQuotes = true;
                    if (!parser.EndOfData)
                    {
                        string[] headers = parser.ReadFields();
                        foreach (string header in headers)
                        {
                            string cleanHeader = header.Trim('"', ' ', '\t');
                            dataGridViewRoutes_LAA.Columns.Add(cleanHeader, cleanHeader);
                        }
                    }
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        dataGridViewRoutes_LAA.Rows.Add(fields);
                    }
                }
                dataGridViewRoutes_LAA.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                buttonShow_LAA.Enabled = true;
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.FileName = "Transport.csv";
                saveDialog.Filter = "Значения разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
                saveDialog.DefaultExt = "csv";
                saveDialog.OverwritePrompt = true;
                saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = saveDialog.FileName;
                    if (dataGridViewRoutes_LAA == null || dataGridViewRoutes_LAA.Columns.Count == 0)
                    {
                        MessageBox.Show("Нет данных для сохранения");
                        return;
                    }
                    List<string> csvLines = new List<string>();
                    List<string> headers = new List<string>();
                    for (int i = 0; i < dataGridViewRoutes_LAA.Columns.Count; i++)
                    {
                        headers.Add(dataGridViewRoutes_LAA.Columns[i].HeaderText ?? $"Col{i + 1}");
                    }
                    csvLines.Add(string.Join(";", headers));
                    int savedRows = 0;
                    for (int row = 0; row < dataGridViewRoutes_LAA.Rows.Count; row++)
                    {
                        List<string> rowData = new List<string>();
                        bool rowHasData = false;
                        for (int col = 0; col < dataGridViewRoutes_LAA.Columns.Count; col++)
                        {
                            object value = dataGridViewRoutes_LAA.Rows[row].Cells[col].Value;
                            string text = value?.ToString() ?? "";
                            if (!string.IsNullOrEmpty(text))
                                rowHasData = true;
                            if (text.Contains(";") || text.Contains("\""))
                                text = "\"" + text.Replace("\"", "\"\"") + "\"";
                            rowData.Add(text);
                        }
                        if (rowHasData)
                        {
                            csvLines.Add(string.Join(";", rowData));
                            savedRows++;
                        }
                    }
                    if (savedRows == 0)
                    {
                        MessageBox.Show("Нет данных для сохранения");
                        return;
                    }
                    File.WriteAllLines(selectedPath, csvLines, new UTF8Encoding(true));
                    if (File.Exists(selectedPath))
                    {
                        FileInfo fi = new FileInfo(selectedPath);
                        MessageBox.Show("Файл успешно сохранен!");
                    }
                }
            }
        }

        private void buttonStatistic_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxType_LAA.Text))
            {
                string searchType = textBoxType_LAA.Text.Trim().ToLower();

                if (dataGridViewRoutes_LAA.Rows.Count == 0)
                {
                    MessageBox.Show("Нет данных для статистики");
                    return;
                }

                int total = dataGridViewRoutes_LAA.Rows.Count;
                int searchedCount = 0;
                string typeName = "";

                foreach (DataGridViewRow row in dataGridViewRoutes_LAA.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string type = row.Cells[0].Value.ToString().ToLower();

                        if (searchType.Contains("автобус") && type.Contains("автобус"))
                        {
                            searchedCount++;
                            typeName = "Автобус";
                        }
                        else if (searchType.Contains("трамвай") && type.Contains("трамвай"))
                        {
                            searchedCount++;
                            typeName = "Трамвай";
                        }
                        else if (searchType.Contains("метро") && type.Contains("метро"))
                        {
                            searchedCount++;
                            typeName = "Метро";
                        }
                        else if (searchType.Contains("маршрут") && type.Contains("маршрут"))
                        {
                            searchedCount++;
                            typeName = "Маршрутка";
                        }
                        else if (searchType.Contains("электрич") && type.Contains("электрич"))
                        {
                            searchedCount++;
                            typeName = "Электричка";
                        }
                    }
                }

                if (searchedCount == 0)
                {
                    MessageBox.Show($"Маршрутов типа '{textBoxType_LAA.Text}' не найдено");
                    return;
                }

                string stats = $"СТАТИСТИКА: {typeName.ToUpper()}\n" +
                              $"Всего маршрутов: {total - 1}\n\n" +
                              $"• {typeName}: {searchedCount} ({GetPercentage(searchedCount, total)}%)\n\n" +
                              $"Сгенерировано: {DateTime.Now:HH:mm:ss}";

                MessageBox.Show(stats, $"Статистика - {typeName}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dataGridViewRoutes_LAA.Rows.Count == 0)
                {
                    MessageBox.Show("Нет данных для статистики");
                    return;
                }
                int total = dataGridViewRoutes_LAA.Rows.Count;
                int buses = 0;
                int trams = 0;
                int metro = 0;
                int minibuses = 0;
                int trains = 0;

                foreach (DataGridViewRow row in dataGridViewRoutes_LAA.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string type = row.Cells[0].Value.ToString().ToLower();
                        if (type.Contains("автобус")) buses++;
                        else if (type.Contains("трамвай")) trams++;
                        else if (type.Contains("метро")) metro++;
                        else if (type.Contains("маршрут")) minibuses++;
                        else if (type.Contains("электрич")) trains++;
                    }
                }
                string stats = "СТАТИСТИКА МАРШРУТОВ\n" +
                               $"Всего маршрутов: {total - 1}\n\n" +
                               $"• Автобусов: {buses} ({GetPercentage(buses, total)}%)\n" +
                               $"• Трамваев: {trams} ({GetPercentage(trams, total)}%)\n" +
                               $"• Метро: {metro} ({GetPercentage(metro, total)}%)\n" +
                               $"• Маршруток: {minibuses} ({GetPercentage(minibuses, total)}%)\n" +
                               $"• Электричек: {trains} ({GetPercentage(trains, total)}%)\n" +
                               $"Сгенерировано: {DateTime.Now:HH:mm:ss}";

                MessageBox.Show(stats, "Статистика", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GetPercentage(int count, int total)
        {
            if (total == 0) return "0.0";
            return ((double)count / total * 100).ToString("F1");
        }


        private void buttonGraf_Click(object sender, EventArgs e)
        {

            if (dataGridViewRoutes_LAA.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для графика");
                return;
            }
            chartPie_LAA.Series.Clear();
            int buses = 0;
            int trams = 0;
            int metro = 0;
            int minibuses = 0;
            int trains = 0;

            foreach (DataGridViewRow row in dataGridViewRoutes_LAA.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string type = row.Cells[0].Value.ToString().ToLower();
                    if (type.Contains("автобус")) buses++;
                    else if (type.Contains("трамвай")) trams++;
                    else if (type.Contains("метро")) metro++;
                    else if (type.Contains("маршрут")) minibuses++;
                    else if (type.Contains("электрич")) trains++;
                }
            }
            Series series = new Series();
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;
            series.Label = "#VALX";

            if (buses > 0) series.Points.AddXY("Автобусы", buses);
            if (trams > 0) series.Points.AddXY("Трамваи", trams);
            if (metro > 0) series.Points.AddXY("Метро", metro);
            if (minibuses > 0) series.Points.AddXY("Маршрутки", minibuses);
            if (trains > 0) series.Points.AddXY("Электрички", trains);

            chartPie_LAA.Series.Add(series);
        }

        private void chartTransport_LAA_Click(object sender, EventArgs e)
        {
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxType_LAA.Text))
            {
                MessageBox.Show("Введите вид транспорта для поиска",
                              "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            buttonStatistic_Click(sender, e);
        }

        private void buttonGraf_MouseEnter(object sender, EventArgs e)
        {
        }
    }
}
