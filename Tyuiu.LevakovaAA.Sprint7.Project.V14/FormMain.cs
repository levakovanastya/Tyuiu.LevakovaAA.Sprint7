using Microsoft.VisualBasic.FileIO;
using System;
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

        private void ShowChartFromDataGridView()
        {
            if (dataGridViewRoutes_LAA.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных в таблице");
                return;
            }
            Chart chart = new Chart();
            chart.Size = new Size(500, 300);
            chart.Location = new Point(200, 50);
            ChartArea area = new ChartArea();
            chart.ChartAreas.Add(area);
            var counts = new Dictionary<string, int>();
            foreach (DataGridViewRow row in dataGridViewRoutes_LAA.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value != null)
                {
                    string type = row.Cells[0].Value.ToString();
                    if (counts.ContainsKey(type))
                        counts[type]++;
                    else
                        counts[type] = 1;
                }
            }
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;

            foreach (var item in counts)
            {
                series.Points.AddXY(item.Key, item.Value);
            }

            chart.Series.Add(series);
            this.Controls.Add(chart);
        }
        private void buttonGraf_Click(object sender, EventArgs e)
        {

            if (chart.Series.Count > 0)
            {
                chart.Series.Clear();
            }
            Series newSeries = new Series("TransportData");
            newSeries.ChartType = SeriesChartType.Pie;
            newSeries.Points.AddXY("Автобус", 2);
            newSeries.Points.AddXY("Трамвай", 1);
            newSeries.Points.AddXY("Маршрутка", 1);
            newSeries.Points.AddXY("Метро", 1);
            newSeries.Points.AddXY("Электричка", 2);
            newSeries.IsValueShownAsLabel = true;
            newSeries.Label = "#VALX"; 
            newSeries.LabelForeColor = Color.White;
            newSeries.Font = new Font("Arial", 12, FontStyle.Bold);
            newSeries["PieLabelStyle"] = "Outside"; 
            newSeries.Points[0].Color = Color.FromArgb(255, 99, 132);   
            newSeries.Points[1].Color = Color.FromArgb(54, 162, 235);   
            newSeries.Points[2].Color = Color.FromArgb(255, 205, 86);   
            newSeries.Points[3].Color = Color.FromArgb(75, 192, 192);   
            chart.Series.Add(newSeries);
            if (chart.Legends.Count == 0)
            {
                Legend legend = new Legend();
                legend.Docking = Docking.Right;
                chart.Legends.Add(legend);
            }
            chart.Titles.Clear();
            chart.Titles.Add("Распределение по типам транспорта");
            chart.Invalidate();
        }
      

        private void chartTransport_LAA_Click(object sender, EventArgs e)
        {
        }
    }
}
