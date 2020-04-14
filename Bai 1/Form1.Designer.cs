namespace Bai_1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBDay = new System.Windows.Forms.ComboBox();
            this.CBMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBYear = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ButRefresh = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LabRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH THỨ TRONG TUẦN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày";
            // 
            // CBDay
            // 
            this.CBDay.FormattingEnabled = true;
            this.CBDay.Location = new System.Drawing.Point(83, 58);
            this.CBDay.Name = "CBDay";
            this.CBDay.Size = new System.Drawing.Size(121, 24);
            this.CBDay.TabIndex = 2;
            // 
            // CBMonth
            // 
            this.CBMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBMonth.FormattingEnabled = true;
            this.CBMonth.Location = new System.Drawing.Point(83, 99);
            this.CBMonth.Name = "CBMonth";
            this.CBMonth.Size = new System.Drawing.Size(121, 24);
            this.CBMonth.TabIndex = 4;
            this.CBMonth.SelectedIndexChanged += new System.EventHandler(this.CBMonth_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tháng";
            // 
            // CBYear
            // 
            this.CBYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBYear.FormattingEnabled = true;
            this.CBYear.Location = new System.Drawing.Point(83, 142);
            this.CBYear.Name = "CBYear";
            this.CBYear.Size = new System.Drawing.Size(121, 24);
            this.CBYear.TabIndex = 6;
            this.CBYear.SelectedIndexChanged += new System.EventHandler(this.CBYear_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Năm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tính thứ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButRefresh
            // 
            this.ButRefresh.Location = new System.Drawing.Point(225, 100);
            this.ButRefresh.Name = "ButRefresh";
            this.ButRefresh.Size = new System.Drawing.Size(75, 23);
            this.ButRefresh.TabIndex = 8;
            this.ButRefresh.Text = "Làm lại";
            this.ButRefresh.UseVisualStyleBackColor = true;
            this.ButRefresh.Click += new System.EventHandler(this.ButRefresh_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LabRes
            // 
            this.LabRes.AutoSize = true;
            this.LabRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LabRes.Location = new System.Drawing.Point(22, 182);
            this.LabRes.Name = "LabRes";
            this.LabRes.Size = new System.Drawing.Size(129, 29);
            this.LabRes.TabIndex = 11;
            this.LabRes.Text = "Hôm đó là";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 231);
            this.Controls.Add(this.LabRes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ButRefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CBYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tính thứ trong tuần";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBDay;
        private System.Windows.Forms.ComboBox CBMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButRefresh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LabRes;
    }
}

