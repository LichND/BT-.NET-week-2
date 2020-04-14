using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3
{
    public partial class Form1 : Form
    {
        private MessageBoxButtons button;
        private MessageBoxIcon icon;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "";

            OK.Select();
            button = MessageBoxButtons.OK;
            Error.Select();
            icon = MessageBoxIcon.Error;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = MessageBox.Show("This is Your Custom MessageBox.", "Custom MessageBox", button, icon).ToString() + " was pressed.";
        }

        private void OK_CheckedChanged(object sender, EventArgs e)
        {
            button = MessageBoxButtons.OK;
        }

        private void OKCancel_CheckedChanged(object sender, EventArgs e)
        {
            button = MessageBoxButtons.OKCancel;
        }

        private void AbortRetryIgnore_CheckedChanged(object sender, EventArgs e)
        {
            button = MessageBoxButtons.AbortRetryIgnore;
        }

        private void YesNoCancel_CheckedChanged(object sender, EventArgs e)
        {
            button = MessageBoxButtons.YesNoCancel;
        }

        private void YesNo_CheckedChanged(object sender, EventArgs e)
        {
            button = MessageBoxButtons.YesNo;
        }

        private void RetryCancel_CheckedChanged(object sender, EventArgs e)
        {
            button = MessageBoxButtons.RetryCancel;
        }

        private void Error_CheckedChanged(object sender, EventArgs e)
        {
            icon = MessageBoxIcon.Error;
        }

        private void Exclamation_CheckedChanged(object sender, EventArgs e)
        {
            icon = MessageBoxIcon.Exclamation;
        }

        private void Information_CheckedChanged(object sender, EventArgs e)
        {
            icon = MessageBoxIcon.Information;
        }

        private void Question_CheckedChanged(object sender, EventArgs e)
        {
            icon = MessageBoxIcon.Question;
        }
    }
}
