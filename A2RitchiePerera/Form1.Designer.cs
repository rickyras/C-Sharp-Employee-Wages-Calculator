namespace A2RitchiePerera
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hoursWorkedTxt = new System.Windows.Forms.TextBox();
            this.houryWagTxt = new System.Windows.Forms.TextBox();
            this.nameEmptxt = new System.Windows.Forms.TextBox();
            this.mgrChk = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.netEarnTxt = new System.Windows.Forms.TextBox();
            this.lessfwtTx = new System.Windows.Forms.TextBox();
            this.grossEtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lessFWT = new System.Windows.Forms.Label();
            this.grossEarnLb = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.empBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hoursWorkedTxt);
            this.groupBox1.Controls.Add(this.houryWagTxt);
            this.groupBox1.Controls.Add(this.nameEmptxt);
            this.groupBox1.Controls.Add(this.mgrChk);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please input the employee information";
            // 
            // hoursWorkedTxt
            // 
            this.hoursWorkedTxt.Location = new System.Drawing.Point(98, 79);
            this.hoursWorkedTxt.Name = "hoursWorkedTxt";
            this.hoursWorkedTxt.Size = new System.Drawing.Size(100, 20);
            this.hoursWorkedTxt.TabIndex = 3;
            this.hoursWorkedTxt.TextChanged += new System.EventHandler(this.hoursWorkedTxt_TextChanged);
            // 
            // houryWagTxt
            // 
            this.houryWagTxt.Location = new System.Drawing.Point(98, 53);
            this.houryWagTxt.Name = "houryWagTxt";
            this.houryWagTxt.Size = new System.Drawing.Size(100, 20);
            this.houryWagTxt.TabIndex = 2;
            this.houryWagTxt.TextChanged += new System.EventHandler(this.houryWagTxt_TextChanged);
            // 
            // nameEmptxt
            // 
            this.nameEmptxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameEmptxt.Location = new System.Drawing.Point(98, 26);
            this.nameEmptxt.Name = "nameEmptxt";
            this.nameEmptxt.Size = new System.Drawing.Size(100, 20);
            this.nameEmptxt.TabIndex = 1;
            this.nameEmptxt.TextChanged += new System.EventHandler(this.nameEmptxt_TextChanged);
            // 
            // mgrChk
            // 
            this.mgrChk.AutoSize = true;
            this.mgrChk.Location = new System.Drawing.Point(98, 109);
            this.mgrChk.Name = "mgrChk";
            this.mgrChk.Size = new System.Drawing.Size(15, 14);
            this.mgrChk.TabIndex = 4;
            this.mgrChk.UseVisualStyleBackColor = true;
            this.mgrChk.CheckedChanged += new System.EventHandler(this.mgrChk_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Manager:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hours Worked:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hourly Wage:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.netEarnTxt);
            this.groupBox2.Controls.Add(this.lessfwtTx);
            this.groupBox2.Controls.Add(this.grossEtxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lessFWT);
            this.groupBox2.Controls.Add(this.grossEarnLb);
            this.groupBox2.Location = new System.Drawing.Point(32, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculated Wage";
            // 
            // netEarnTxt
            // 
            this.netEarnTxt.Enabled = false;
            this.netEarnTxt.Location = new System.Drawing.Point(131, 103);
            this.netEarnTxt.Name = "netEarnTxt";
            this.netEarnTxt.Size = new System.Drawing.Size(100, 20);
            this.netEarnTxt.TabIndex = 5;
            // 
            // lessfwtTx
            // 
            this.lessfwtTx.Enabled = false;
            this.lessfwtTx.Location = new System.Drawing.Point(131, 70);
            this.lessfwtTx.Name = "lessfwtTx";
            this.lessfwtTx.Size = new System.Drawing.Size(100, 20);
            this.lessfwtTx.TabIndex = 4;
            // 
            // grossEtxt
            // 
            this.grossEtxt.Enabled = false;
            this.grossEtxt.Location = new System.Drawing.Point(131, 39);
            this.grossEtxt.Name = "grossEtxt";
            this.grossEtxt.Size = new System.Drawing.Size(100, 20);
            this.grossEtxt.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Net Earnings:";
            // 
            // lessFWT
            // 
            this.lessFWT.AutoSize = true;
            this.lessFWT.Location = new System.Drawing.Point(17, 73);
            this.lessFWT.Name = "lessFWT";
            this.lessFWT.Size = new System.Drawing.Size(59, 13);
            this.lessFWT.TabIndex = 1;
            this.lessFWT.Text = "Less FWT:";
            // 
            // grossEarnLb
            // 
            this.grossEarnLb.AutoSize = true;
            this.grossEarnLb.Location = new System.Drawing.Point(17, 39);
            this.grossEarnLb.Name = "grossEarnLb";
            this.grossEarnLb.Size = new System.Drawing.Size(81, 13);
            this.grossEarnLb.TabIndex = 0;
            this.grossEarnLb.Text = "Gross Earnings:";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(32, 176);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 3;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(273, 176);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(75, 23);
            this.clrBtn.TabIndex = 3;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Employees";
            // 
            // empBox
            // 
            this.empBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empBox.FormattingEnabled = true;
            this.empBox.Location = new System.Drawing.Point(142, 368);
            this.empBox.Name = "empBox";
            this.empBox.Size = new System.Drawing.Size(205, 21);
            this.empBox.TabIndex = 5;
            this.empBox.SelectedIndexChanged += new System.EventHandler(this.empBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(394, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.empBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wage Calculator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox hoursWorkedTxt;
        private System.Windows.Forms.TextBox houryWagTxt;
        private System.Windows.Forms.TextBox nameEmptxt;
        private System.Windows.Forms.CheckBox mgrChk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox netEarnTxt;
        private System.Windows.Forms.TextBox lessfwtTx;
        private System.Windows.Forms.TextBox grossEtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lessFWT;
        private System.Windows.Forms.Label grossEarnLb;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox empBox;
        private System.Windows.Forms.Button button1;
    }
}

