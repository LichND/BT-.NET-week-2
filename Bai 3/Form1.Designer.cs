namespace Bai_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RetryCancel = new System.Windows.Forms.RadioButton();
            this.YesNo = new System.Windows.Forms.RadioButton();
            this.YesNoCancel = new System.Windows.Forms.RadioButton();
            this.AbortRetryIgnore = new System.Windows.Forms.RadioButton();
            this.OKCancel = new System.Windows.Forms.RadioButton();
            this.OK = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Question = new System.Windows.Forms.RadioButton();
            this.Information = new System.Windows.Forms.RadioButton();
            this.Exclamation = new System.Windows.Forms.RadioButton();
            this.Error = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the type of MessageBox you would like to display!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RetryCancel);
            this.groupBox1.Controls.Add(this.YesNo);
            this.groupBox1.Controls.Add(this.YesNoCancel);
            this.groupBox1.Controls.Add(this.AbortRetryIgnore);
            this.groupBox1.Controls.Add(this.OKCancel);
            this.groupBox1.Controls.Add(this.OK);
            this.groupBox1.Location = new System.Drawing.Point(16, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Button Type";
            // 
            // RetryCancel
            // 
            this.RetryCancel.AutoSize = true;
            this.RetryCancel.Location = new System.Drawing.Point(15, 196);
            this.RetryCancel.Name = "RetryCancel";
            this.RetryCancel.Size = new System.Drawing.Size(106, 21);
            this.RetryCancel.TabIndex = 5;
            this.RetryCancel.TabStop = true;
            this.RetryCancel.Text = "RetryCancel";
            this.RetryCancel.UseVisualStyleBackColor = true;
            this.RetryCancel.CheckedChanged += new System.EventHandler(this.RetryCancel_CheckedChanged);
            // 
            // YesNo
            // 
            this.YesNo.AutoSize = true;
            this.YesNo.Location = new System.Drawing.Point(15, 161);
            this.YesNo.Name = "YesNo";
            this.YesNo.Size = new System.Drawing.Size(71, 21);
            this.YesNo.TabIndex = 4;
            this.YesNo.TabStop = true;
            this.YesNo.Text = "YesNo";
            this.YesNo.UseVisualStyleBackColor = true;
            this.YesNo.CheckedChanged += new System.EventHandler(this.YesNo_CheckedChanged);
            // 
            // YesNoCancel
            // 
            this.YesNoCancel.AutoSize = true;
            this.YesNoCancel.Location = new System.Drawing.Point(15, 126);
            this.YesNoCancel.Name = "YesNoCancel";
            this.YesNoCancel.Size = new System.Drawing.Size(114, 21);
            this.YesNoCancel.TabIndex = 3;
            this.YesNoCancel.TabStop = true;
            this.YesNoCancel.Text = "YesNoCancel";
            this.YesNoCancel.UseVisualStyleBackColor = true;
            this.YesNoCancel.CheckedChanged += new System.EventHandler(this.YesNoCancel_CheckedChanged);
            // 
            // AbortRetryIgnore
            // 
            this.AbortRetryIgnore.AutoSize = true;
            this.AbortRetryIgnore.Location = new System.Drawing.Point(15, 91);
            this.AbortRetryIgnore.Name = "AbortRetryIgnore";
            this.AbortRetryIgnore.Size = new System.Drawing.Size(137, 21);
            this.AbortRetryIgnore.TabIndex = 2;
            this.AbortRetryIgnore.TabStop = true;
            this.AbortRetryIgnore.Text = "AbortRetryIgnore";
            this.AbortRetryIgnore.UseVisualStyleBackColor = true;
            this.AbortRetryIgnore.CheckedChanged += new System.EventHandler(this.AbortRetryIgnore_CheckedChanged);
            // 
            // OKCancel
            // 
            this.OKCancel.AutoSize = true;
            this.OKCancel.Location = new System.Drawing.Point(15, 56);
            this.OKCancel.Name = "OKCancel";
            this.OKCancel.Size = new System.Drawing.Size(92, 21);
            this.OKCancel.TabIndex = 1;
            this.OKCancel.TabStop = true;
            this.OKCancel.Text = "OKCancel";
            this.OKCancel.UseVisualStyleBackColor = true;
            this.OKCancel.CheckedChanged += new System.EventHandler(this.OKCancel_CheckedChanged);
            // 
            // OK
            // 
            this.OK.AutoSize = true;
            this.OK.Location = new System.Drawing.Point(15, 21);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(49, 21);
            this.OK.TabIndex = 0;
            this.OK.TabStop = true;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.CheckedChanged += new System.EventHandler(this.OK_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Question);
            this.groupBox2.Controls.Add(this.Information);
            this.groupBox2.Controls.Add(this.Exclamation);
            this.groupBox2.Controls.Add(this.Error);
            this.groupBox2.Location = new System.Drawing.Point(205, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 152);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Icon";
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Location = new System.Drawing.Point(15, 126);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(86, 21);
            this.Question.TabIndex = 3;
            this.Question.TabStop = true;
            this.Question.Text = "Question";
            this.Question.UseVisualStyleBackColor = true;
            this.Question.CheckedChanged += new System.EventHandler(this.Question_CheckedChanged);
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Location = new System.Drawing.Point(15, 91);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(99, 21);
            this.Information.TabIndex = 2;
            this.Information.TabStop = true;
            this.Information.Text = "Information";
            this.Information.UseVisualStyleBackColor = true;
            this.Information.CheckedChanged += new System.EventHandler(this.Information_CheckedChanged);
            // 
            // Exclamation
            // 
            this.Exclamation.AutoSize = true;
            this.Exclamation.Location = new System.Drawing.Point(15, 56);
            this.Exclamation.Name = "Exclamation";
            this.Exclamation.Size = new System.Drawing.Size(104, 21);
            this.Exclamation.TabIndex = 1;
            this.Exclamation.TabStop = true;
            this.Exclamation.Text = "Exclamation";
            this.Exclamation.UseVisualStyleBackColor = true;
            this.Exclamation.CheckedChanged += new System.EventHandler(this.Exclamation_CheckedChanged);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Location = new System.Drawing.Point(15, 21);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(61, 21);
            this.Error.TabIndex = 0;
            this.Error.TabStop = true;
            this.Error.Text = "Error";
            this.Error.UseVisualStyleBackColor = true;
            this.Error.CheckedChanged += new System.EventHandler(this.Error_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 282);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Demonstrating Radiobutton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton AbortRetryIgnore;
        private System.Windows.Forms.RadioButton OKCancel;
        private System.Windows.Forms.RadioButton OK;
        private System.Windows.Forms.RadioButton RetryCancel;
        private System.Windows.Forms.RadioButton YesNo;
        private System.Windows.Forms.RadioButton YesNoCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Question;
        private System.Windows.Forms.RadioButton Information;
        private System.Windows.Forms.RadioButton Exclamation;
        private System.Windows.Forms.RadioButton Error;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

