using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class Form1 : Form
    {
        const int MinYear = 1999;
        const int MaxYear = 2099;
        Action refresh, setDay;

        public Form1()
        {
            InitializeComponent();

            for (int i = 1; i <= 31; i++)
                CBDay.Items.Add(i);

            for (int i = 1; i <= 12; i++)
                CBMonth.Items.Add($"Tháng {i}");

            for (int i = MinYear; i <= MaxYear; i++)
                CBYear.Items.Add(i);

            initAction();

            refresh.Invoke();
            LabRes.Text = "";
        }

        private void initAction()
        {
            refresh = () =>
            {
                CBDay.SelectedIndex = 0;
                CBMonth.SelectedIndex = 0;
                CBYear.SelectedIndex = 0;
                LabRes.Text = "";
            };
            setDay = () =>
            {
                if (int.TryParse(CBYear.SelectedItem?.ToString(), out int year))
                {
                    int dom = DateTime.DaysInMonth(year, CBMonth.SelectedIndex + 1);
                    int hold = CBDay.SelectedIndex;
                    CBDay.Items.Clear();
                    for (int i = 1; i <= dom; i++)
                        CBDay.Items.Add(i);
                    CBDay.SelectedIndex = Math.Min(hold, dom - 1);
                }
            };
        }

        private string GetDoW(DayOfWeek dow)
        {
            switch (dow)
            {
                case DayOfWeek.Monday:
                    return "thứ hai";
                case DayOfWeek.Tuesday:
                    return "thứ ba";
                case DayOfWeek.Wednesday:
                    return "thứ tư";
                case DayOfWeek.Thursday:
                    return "thứ năm";
                case DayOfWeek.Friday:
                    return "thứ sáu";
                case DayOfWeek.Saturday:
                    return "thứ bảy";
                case DayOfWeek.Sunday:
                    return "chủ nhật";
                default:
                    return "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButRefresh_Click(object sender, EventArgs e)
        {
            refresh.Invoke();
        }

        private void CBMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            setDay.Invoke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CBYear.SelectedItem?.ToString(), out int year))
            {
                DateTime date = new DateTime(year,CBMonth.SelectedIndex+1,CBDay.SelectedIndex+1);
                LabRes.Text = $"Hôm đó là thứ {GetDoW(date.DayOfWeek)}";
            }
        }

        private void CBYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            setDay.Invoke();
        }
    }
}
