using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            comboBox1.TextChanged += (sender, e) =>
            {
                pictureBox1.ImageLocation = comboBox1.Text;

                if (System.IO.File.Exists(comboBox1.Text))
                    if (!comboBox1.Items.Contains(comboBox1.Text))
                        comboBox1.Items.Add(comboBox1.Text);
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            open.Multiselect = false;
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = open.FileName;
                comboBox1.Text = open.FileName;
            }
        }
    }
}
