namespace WindowsFormsApp2
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textEMPID = new System.Windows.Forms.TextBox();
            this.textEmpName = new System.Windows.Forms.TextBox();
            this.textHRa = new System.Windows.Forms.TextBox();
            this.textbasicsalary = new System.Windows.Forms.TextBox();
            this.textGROS = new System.Windows.Forms.TextBox();
            this.textPF = new System.Windows.Forms.TextBox();
            this.textDA = new System.Windows.Forms.TextBox();
            this.textTA = new System.Windows.Forms.TextBox();
            this.cmbdepartlist = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMP ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employe Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Basic Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "HRA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "TA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "DA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "PF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 565);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Gross Salary";
            // 
            // textEMPID
            // 
            this.textEMPID.Location = new System.Drawing.Point(383, 80);
            this.textEMPID.Name = "textEMPID";
            this.textEMPID.Size = new System.Drawing.Size(179, 22);
            this.textEMPID.TabIndex = 9;
            // 
            // textEmpName
            // 
            this.textEmpName.Location = new System.Drawing.Point(392, 142);
            this.textEmpName.Name = "textEmpName";
            this.textEmpName.Size = new System.Drawing.Size(179, 22);
            this.textEmpName.TabIndex = 10;
            // 
            // textHRa
            // 
            this.textHRa.Enabled = false;
            this.textHRa.Location = new System.Drawing.Point(383, 323);
            this.textHRa.Name = "textHRa";
            this.textHRa.Size = new System.Drawing.Size(179, 22);
            this.textHRa.TabIndex = 11;
            // 
            // textbasicsalary
            // 
            this.textbasicsalary.Location = new System.Drawing.Point(383, 262);
            this.textbasicsalary.Name = "textbasicsalary";
            this.textbasicsalary.Size = new System.Drawing.Size(179, 22);
            this.textbasicsalary.TabIndex = 12;
            // 
            // textGROS
            // 
            this.textGROS.Enabled = false;
            this.textGROS.Location = new System.Drawing.Point(392, 562);
            this.textGROS.Name = "textGROS";
            this.textGROS.Size = new System.Drawing.Size(179, 22);
            this.textGROS.TabIndex = 13;
            // 
            // textPF
            // 
            this.textPF.Enabled = false;
            this.textPF.Location = new System.Drawing.Point(383, 506);
            this.textPF.Name = "textPF";
            this.textPF.Size = new System.Drawing.Size(179, 22);
            this.textPF.TabIndex = 14;
            this.textPF.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textDA
            // 
            this.textDA.Enabled = false;
            this.textDA.Location = new System.Drawing.Point(383, 450);
            this.textDA.Name = "textDA";
            this.textDA.Size = new System.Drawing.Size(179, 22);
            this.textDA.TabIndex = 15;
            // 
            // textTA
            // 
            this.textTA.Enabled = false;
            this.textTA.Location = new System.Drawing.Point(383, 396);
            this.textTA.Name = "textTA";
            this.textTA.Size = new System.Drawing.Size(179, 22);
            this.textTA.TabIndex = 16;
            // 
            // cmbdepartlist
            // 
            this.cmbdepartlist.FormattingEnabled = true;
            this.cmbdepartlist.Location = new System.Drawing.Point(383, 201);
            this.cmbdepartlist.Name = "cmbdepartlist";
            this.cmbdepartlist.Size = new System.Drawing.Size(188, 24);
            this.cmbdepartlist.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1053, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "Calculation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1065, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 50);
            this.button2.TabIndex = 22;
            this.button2.Text = "Display";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 715);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbdepartlist);
            this.Controls.Add(this.textTA);
            this.Controls.Add(this.textDA);
            this.Controls.Add(this.textPF);
            this.Controls.Add(this.textGROS);
            this.Controls.Add(this.textbasicsalary);
            this.Controls.Add(this.textHRa);
            this.Controls.Add(this.textEmpName);
            this.Controls.Add(this.textEMPID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Emoplyes Form";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textEMPID;
        private System.Windows.Forms.TextBox textEmpName;
        private System.Windows.Forms.TextBox textHRa;
        private System.Windows.Forms.TextBox textbasicsalary;
        private System.Windows.Forms.TextBox textGROS;
        private System.Windows.Forms.TextBox textPF;
        private System.Windows.Forms.TextBox textDA;
        private System.Windows.Forms.TextBox textTA;
        private System.Windows.Forms.ComboBox cmbdepartlist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}