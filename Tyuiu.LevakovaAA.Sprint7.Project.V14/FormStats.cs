using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Tyuiu.LevakovaAA.Sprint7.Project.V14
{
    public partial class FormStats : Form
    {
        public FormStats()
        {
            InitializeComponent();
        }

        private void FormStats_Load(int totalRoutes, int busCount, int tramCount,
                                 int trolleyCount, int otherCount,
                                 double avgTime, double maxTime, double minTime)

        {
            string stats = "";

            stats += "СТАТИСТИКА МАРШРУТОВ\n";
            stats += "══════════════════════\n\n";

            stats += $"Всего маршрутов: {totalRoutes}\n\n";

            stats += "По типам транспорта:\n";
            stats += $"• Автобусов: {busCount} ({CalculatePercentage(busCount, totalRoutes)}%)\n";
            stats += $"• Трамваев: {tramCount} ({CalculatePercentage(tramCount, totalRoutes)}%)\n";
            stats += $"• Троллейбусов: {trolleyCount} ({CalculatePercentage(trolleyCount, totalRoutes)}%)\n";
            stats += $"• Других: {otherCount} ({CalculatePercentage(otherCount, totalRoutes)}%)\n\n";

            stats += "Время в пути:\n";
            stats += $"• Среднее: {avgTime:F1} мин\n";
            stats += $"• Максимальное: {maxTime:F0} мин\n";
            stats += $"• Минимальное: {minTime:F0} мин\n\n";

            stats += $"Сгенерировано: {DateTime.Now:HH:mm:ss}";

            textBoxStats.Text = stats;
        }

        private string CalculatePercentage(int count, int total)
        {
            if (total == 0) return "0.0";
            return ((double)count / total * 100).ToString("F1");
        }
    }
}