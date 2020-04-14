using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
            label4.Text = "";
            this.KeyPreview = true;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label2.Text = (e as MouseEventArgs)?.Location.ToString();
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            label4.Text = $"Mã ASCII {e.KeyValue} - Key code {e.KeyCode} - Scan code {(Char)e.KeyData}";
        }
    }
}
