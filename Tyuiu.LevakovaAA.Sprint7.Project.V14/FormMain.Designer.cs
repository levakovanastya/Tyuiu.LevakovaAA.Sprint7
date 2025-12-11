namespace Tyuiu.LevakovaAA.Sprint7.Project.V14
{
    partial class FormMain_LAA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            buttonGraf = new Button();
            buttonShow_LAA = new Button();
            buttonStatistic = new Button();
            buttonSaveFile = new Button();
            buttonHelp_LAA = new Button();
            panel2 = new Panel();
            dataGridViewRoutes_LAA = new DataGridView();
            toolTipButton_LAA = new ToolTip(components);
            openFileDialog_LAA = new OpenFileDialog();
            saveFileDialog_LAA = new OpenFileDialog();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes_LAA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonGraf);
            panel1.Controls.Add(buttonShow_LAA);
            panel1.Controls.Add(buttonStatistic);
            panel1.Controls.Add(buttonSaveFile);
            panel1.Controls.Add(buttonHelp_LAA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 109);
            panel1.TabIndex = 0;
            // 
            // buttonGraf
            // 
            buttonGraf.Location = new Point(340, 22);
            buttonGraf.Name = "buttonGraf";
            buttonGraf.Size = new Size(119, 71);
            buttonGraf.TabIndex = 4;
            buttonGraf.Text = "Построить график";
            buttonGraf.UseVisualStyleBackColor = true;
            buttonGraf.Click += buttonGraf_Click;
            // 
            // buttonShow_LAA
            // 
            buttonShow_LAA.Location = new Point(219, 22);
            buttonShow_LAA.Name = "buttonShow_LAA";
            buttonShow_LAA.Size = new Size(115, 71);
            buttonShow_LAA.TabIndex = 3;
            buttonShow_LAA.Text = "Показать маршруты";
            buttonShow_LAA.UseVisualStyleBackColor = true;
            buttonShow_LAA.Click += buttonShow_Click;
            // 
            // buttonStatistic
            // 
            buttonStatistic.Location = new Point(117, 22);
            buttonStatistic.Name = "buttonStatistic";
            buttonStatistic.Size = new Size(96, 71);
            buttonStatistic.TabIndex = 2;
            buttonStatistic.Text = "Статистика";
            buttonStatistic.UseVisualStyleBackColor = true;
            buttonStatistic.Click += buttonStatistic_Click;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Image = Properties.Resources.page_save;
            buttonSaveFile.Location = new Point(14, 22);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(97, 71);
            buttonSaveFile.TabIndex = 1;
            toolTipButton_LAA.SetToolTip(buttonSaveFile, "Сохранить файл");
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // buttonHelp_LAA
            // 
            buttonHelp_LAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_LAA.Image = Properties.Resources.help;
            buttonHelp_LAA.Location = new Point(1090, 22);
            buttonHelp_LAA.Name = "buttonHelp_LAA";
            buttonHelp_LAA.Size = new Size(80, 71);
            buttonHelp_LAA.TabIndex = 0;
            toolTipButton_LAA.SetToolTip(buttonHelp_LAA, "Справка");
            buttonHelp_LAA.UseVisualStyleBackColor = true;
            buttonHelp_LAA.Click += buttonHelp_LAA_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(217, 537);
            panel2.TabIndex = 1;
            // 
            // dataGridViewRoutes_LAA
            // 
            dataGridViewRoutes_LAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoutes_LAA.Location = new Point(219, 112);
            dataGridViewRoutes_LAA.Name = "dataGridViewRoutes_LAA";
            dataGridViewRoutes_LAA.RowHeadersWidth = 51;
            dataGridViewRoutes_LAA.Size = new Size(552, 373);
            dataGridViewRoutes_LAA.TabIndex = 0;
            // 
            // toolTipButton_LAA
            // 
            toolTipButton_LAA.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog_LAA
            // 
            openFileDialog_LAA.FileName = "openFileDialog1";
            // 
            // saveFileDialog_LAA
            // 
            saveFileDialog_LAA.FileName = "openFileDialog2";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(776, 117);
            chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(403, 369);
            chart.TabIndex = 2;
            chart.Text = "chart1";
            // 
            // FormMain_LAA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 646);
            Controls.Add(chart);
            Controls.Add(dataGridViewRoutes_LAA);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain_LAA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Городской транспорт";
            Load += FormMain_LAA_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes_LAA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button buttonHelp_LAA;
        private ToolTip toolTipButton_LAA;
        private Button buttonStatistic;
        private Button buttonSaveFile;
        private DataGridView dataGridViewRoutes_LAA;
        private Button buttonShow_LAA;
        private OpenFileDialog openFileDialog_LAA;
        private OpenFileDialog saveFileDialog_LAA;
        private Button buttonGraf;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}
