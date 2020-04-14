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
    public partial class Form1 : Form
    {
        private int __done;
        public int done
        {
            get => __done;
            set
            {
                __done = value;
                if (__done == 2)
                    this.Close();
            }
        }

        public Form1()
        {
            InitializeComponent();

            DigitalClock clock = new DigitalClock();
            DigitalClockWithDate clockWithDate = new DigitalClockWithDate();

            clock.Show();
            clockWithDate.Show();

            clock.FormClosed += (sender, e) => done++;
            clockWithDate.FormClosed += (sender, e) => done++;

            this.Shown += (sender, e) => this.Hide();
        }
    }
}
