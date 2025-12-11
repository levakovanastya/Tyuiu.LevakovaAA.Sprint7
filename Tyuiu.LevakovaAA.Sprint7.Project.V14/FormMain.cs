using System.Text;
using System.Windows.Forms;
using System;
using Microsoft.VisualBasic.FileIO;

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
        static int rows;
        static int colums;
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
            if (dataGridViewRoutes_LAA.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для статистики");
                return;
            }
            int total = dataGridViewRoutes_LAA.Rows.Count;
            int buses = 0;
            int trams = 0;
            int metro = 0;
            foreach (DataGridViewRow row in dataGridViewRoutes_LAA.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string type = row.Cells[0].Value.ToString().ToLower();
                    if (type.Contains("автобус")) buses++;
                    else if (type.Contains("трамвай")) trams++;
                    else if (type.Contains("метро")) metro++;
                }
            }
            int others = total - buses - trams - metro;
            string stats = "СТАТИСТИКА МАРШРУТОВ\n" +
                           $"Всего маршрутов: {total - 1}\n\n" +
                           $"• Автобусов: {buses} ({GetPercentage(buses, total)}%)\n" +
                           $"• Трамваев: {trams} ({GetPercentage(trams, total)}%)\n" +
                           $"• Метро: {metro} ({GetPercentage(metro, total)}%)\n" +
                           $"• Других: {others} ({GetPercentage(others, total)}%)\n\n" +
                           $"Сгенерировано: {DateTime.Now:HH:mm:ss}";
            MessageBox.Show(stats, "Статистика", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetPercentage(int count, int total)
        {
            if (total == 0) return "0.0";
            return ((double)count / total * 100).ToString("F1");
        }
    }
}
