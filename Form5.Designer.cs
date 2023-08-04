namespace WindowsFormsApp2
{
    partial class Form5
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
            this.create_Folder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpprice = new System.Windows.Forms.Label();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // create_Folder
            // 
            this.create_Folder.Location = new System.Drawing.Point(53, 43);
            this.create_Folder.Name = "create_Folder";
            this.create_Folder.Size = new System.Drawing.Size(136, 42);
            this.create_Folder.TabIndex = 0;
            this.create_Folder.Text = "Create Folder";
            this.create_Folder.UseVisualStyleBackColor = true;
            this.create_Folder.Click += new System.EventHandler(this.create_Folder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Name";
            // 
            // txtpprice
            // 
            this.txtpprice.AutoSize = true;
            this.txtpprice.Location = new System.Drawing.Point(104, 289);
            this.txtpprice.Name = "txtpprice";
            this.txtpprice.Size = new System.Drawing.Size(86, 16);
            this.txtpprice.TabIndex = 4;
            this.txtpprice.Text = "Product price";
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(218, 157);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(168, 22);
            this.txtpid.TabIndex = 5;
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(218, 223);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(168, 22);
            this.txtpname.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(218, 289);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 22);
            this.textBox3.TabIndex = 7;
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(145, 362);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(113, 32);
            this.btnwrite.TabIndex = 8;
            this.btnwrite.Text = "Write to file";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(282, 362);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(104, 32);
            this.btnread.TabIndex = 9;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.txtpprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.create_Folder);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_Folder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtpprice;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnread;
    }
}