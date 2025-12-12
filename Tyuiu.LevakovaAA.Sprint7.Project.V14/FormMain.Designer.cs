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
            buttonSearch = new Button();
            buttonGraf = new Button();
            groupBoxType_LAA = new GroupBox();
            textBoxType_LAA = new TextBox();
            buttonShow_LAA = new Button();
            buttonStatistic_LAA = new Button();
            buttonSaveFile = new Button();
            buttonHelp_LAA = new Button();
            dataGridViewRoutes_LAA = new DataGridView();
            toolTipButton_LAA = new ToolTip(components);
            openFileDialog_LAA = new OpenFileDialog();
            saveFileDialog_LAA = new OpenFileDialog();
            chartPie_LAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel3 = new Panel();
            panel4 = new Panel();
            splitter1 = new Splitter();
            panel1.SuspendLayout();
            groupBoxType_LAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes_LAA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPie_LAA).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(buttonGraf);
            panel1.Controls.Add(groupBoxType_LAA);
            panel1.Controls.Add(buttonShow_LAA);
            panel1.Controls.Add(buttonStatistic_LAA);
            panel1.Controls.Add(buttonSaveFile);
            panel1.Controls.Add(buttonHelp_LAA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 109);
            panel1.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(935, 32);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(105, 38);
            buttonSearch.TabIndex = 7;
            buttonSearch.Text = "Найти";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
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
            // groupBoxType_LAA
            // 
            groupBoxType_LAA.Controls.Add(textBoxType_LAA);
            groupBoxType_LAA.Location = new Point(738, 22);
            groupBoxType_LAA.Name = "groupBoxType_LAA";
            groupBoxType_LAA.Size = new Size(189, 48);
            groupBoxType_LAA.TabIndex = 6;
            groupBoxType_LAA.TabStop = false;
            groupBoxType_LAA.Text = "Тип транспорта";
            // 
            // textBoxType_LAA
            // 
            textBoxType_LAA.Location = new Point(2, 21);
            textBoxType_LAA.Name = "textBoxType_LAA";
            textBoxType_LAA.Size = new Size(189, 27);
            textBoxType_LAA.TabIndex = 5;
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
            // buttonStatistic_LAA
            // 
            buttonStatistic_LAA.Location = new Point(117, 22);
            buttonStatistic_LAA.Name = "buttonStatistic_LAA";
            buttonStatistic_LAA.Size = new Size(96, 71);
            buttonStatistic_LAA.TabIndex = 2;
            buttonStatistic_LAA.Text = "Статистика";
            buttonStatistic_LAA.UseVisualStyleBackColor = true;
            buttonStatistic_LAA.Click += buttonStatistic_Click;
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
            // dataGridViewRoutes_LAA
            // 
            dataGridViewRoutes_LAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoutes_LAA.Dock = DockStyle.Fill;
            dataGridViewRoutes_LAA.Location = new Point(0, 0);
            dataGridViewRoutes_LAA.Name = "dataGridViewRoutes_LAA";
            dataGridViewRoutes_LAA.RowHeadersWidth = 51;
            dataGridViewRoutes_LAA.Size = new Size(660, 534);
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
            // chartPie_LAA
            // 
            chartArea1.Name = "ChartArea1";
            chartPie_LAA.ChartAreas.Add(chartArea1);
            chartPie_LAA.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartPie_LAA.Legends.Add(legend1);
            chartPie_LAA.Location = new Point(4, 0);
            chartPie_LAA.Name = "chartPie_LAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartPie_LAA.Series.Add(series1);
            chartPie_LAA.Size = new Size(517, 536);
            chartPie_LAA.TabIndex = 2;
            chartPie_LAA.Text = "chart1";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewRoutes_LAA);
            panel3.Location = new Point(0, 111);
            panel3.Name = "panel3";
            panel3.Size = new Size(660, 534);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(chartPie_LAA);
            panel4.Controls.Add(splitter1);
            panel4.Location = new Point(660, 109);
            panel4.Name = "panel4";
            panel4.Size = new Size(521, 536);
            panel4.TabIndex = 4;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 536);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // FormMain_LAA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 646);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "FormMain_LAA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Городской транспорт";
            Load += FormMain_LAA_Load;
            panel1.ResumeLayout(false);
            groupBoxType_LAA.ResumeLayout(false);
            groupBoxType_LAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes_LAA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPie_LAA).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonHelp_LAA;
        private ToolTip toolTipButton_LAA;
        private Button buttonStatistic_LAA;
        private Button buttonSaveFile;
        private DataGridView dataGridViewRoutes_LAA;
        private Button buttonShow_LAA;
        private OpenFileDialog openFileDialog_LAA;
        private OpenFileDialog saveFileDialog_LAA;
        private Button buttonGraf;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie_LAA;
        private Panel panel3;
        private Panel panel4;
        private Splitter splitter1;
        private GroupBox groupBoxType_LAA;
        private TextBox textBoxType_LAA;
        private Button buttonSearch;
    }
}
