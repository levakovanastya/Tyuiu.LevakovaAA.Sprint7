namespace Tyuiu.LevakovaAA.Sprint7.Project.V14
{
    partial class FormStats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxStats = new TextBox();
            SuspendLayout();
            // 
            // textBoxStats
            // 
            textBoxStats.Location = new Point(4, 5);
            textBoxStats.Multiline = true;
            textBoxStats.Name = "textBoxStats";
            textBoxStats.ReadOnly = true;
            textBoxStats.Size = new Size(413, 503);
            textBoxStats.TabIndex = 0;
            // 
            // FormStats
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 505);
            Controls.Add(textBoxStats);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormStats";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStats;
    }
}