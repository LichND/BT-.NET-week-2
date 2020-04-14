using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_5
{
    public partial class DigitalClockWithDate : Form
    {
        public DigitalClockWithDate()
        {
            InitializeComponent();

            label1.Text = DateTime.Now.ToShortDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
            timer2.Tick += (sender, e) =>
            {
                if (DateTime.Now.Millisecond <= timer1.Interval)
                {
                    timer1.Stop();
                    timer1.Start();
                    timer2.Stop();
                    timer2.Dispose();
                }
            };

            timer1.Tick += (sender, e) =>
            {
                label1.Text = DateTime.Now.ToShortDateString();
                label2.Text = DateTime.Now.ToLongTimeString();
            };
        }
    }
}
