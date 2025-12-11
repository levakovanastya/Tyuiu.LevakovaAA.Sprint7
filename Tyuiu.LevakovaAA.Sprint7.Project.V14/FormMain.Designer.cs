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
            panel1 = new Panel();
            buttonShow_LAA = new Button();
            buttonStatistic = new Button();
            buttonSaveFile = new Button();
            buttonHelp_LAA = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            dataGridViewRoutes_LAA = new DataGridView();
            panel5 = new Panel();
            toolTipButton_LAA = new ToolTip(components);
            openFileDialog_LAA = new OpenFileDialog();
            saveFileDialog_LAA = new OpenFileDialog();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes_LAA).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
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
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(219, 137);
            panel3.Name = "panel3";
            panel3.Size = new Size(792, 510);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridViewRoutes_LAA);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(792, 510);
            panel4.TabIndex = 3;
            // 
            // dataGridViewRoutes_LAA
            // 
            dataGridViewRoutes_LAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoutes_LAA.Dock = DockStyle.Fill;
            dataGridViewRoutes_LAA.Location = new Point(0, 0);
            dataGridViewRoutes_LAA.Name = "dataGridViewRoutes_LAA";
            dataGridViewRoutes_LAA.RowHeadersWidth = 51;
            dataGridViewRoutes_LAA.Size = new Size(792, 510);
            dataGridViewRoutes_LAA.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(1010, 109);
            panel5.Name = "panel5";
            panel5.Size = new Size(172, 537);
            panel5.TabIndex = 3;
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
            // FormMain_LAA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 646);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain_LAA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Городской транспорт";
            Load += FormMain_LAA_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes_LAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button buttonHelp_LAA;
        private ToolTip toolTipButton_LAA;
        private Button buttonStatistic;
        private Button buttonSaveFile;
        private DataGridView dataGridViewRoutes_LAA;
        private Button buttonShow_LAA;
        private OpenFileDialog openFileDialog_LAA;
        private OpenFileDialog saveFileDialog_LAA;
    }
}
