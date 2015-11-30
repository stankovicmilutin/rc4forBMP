namespace ZI_Lab02
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
            this.selFileBtn = new System.Windows.Forms.Button();
            this.cryptBtn = new System.Windows.Forms.Button();
            this.selFileTb = new System.Windows.Forms.TextBox();
            this.newFileTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encriptionKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selFileBtn
            // 
            this.selFileBtn.Location = new System.Drawing.Point(22, 26);
            this.selFileBtn.Name = "selFileBtn";
            this.selFileBtn.Size = new System.Drawing.Size(75, 23);
            this.selFileBtn.TabIndex = 0;
            this.selFileBtn.Text = "Select File";
            this.selFileBtn.UseVisualStyleBackColor = true;
            this.selFileBtn.Click += new System.EventHandler(this.selFileBtn_Click);
            // 
            // cryptBtn
            // 
            this.cryptBtn.Location = new System.Drawing.Point(22, 83);
            this.cryptBtn.Name = "cryptBtn";
            this.cryptBtn.Size = new System.Drawing.Size(75, 23);
            this.cryptBtn.TabIndex = 1;
            this.cryptBtn.Text = "Crypt";
            this.cryptBtn.UseVisualStyleBackColor = true;
            this.cryptBtn.Click += new System.EventHandler(this.cryptBtn_Click);
            // 
            // selFileTb
            // 
            this.selFileTb.Location = new System.Drawing.Point(137, 29);
            this.selFileTb.Name = "selFileTb";
            this.selFileTb.Size = new System.Drawing.Size(162, 20);
            this.selFileTb.TabIndex = 2;
            // 
            // newFileTb
            // 
            this.newFileTb.Location = new System.Drawing.Point(137, 83);
            this.newFileTb.Name = "newFileTb";
            this.newFileTb.Size = new System.Drawing.Size(162, 20);
            this.newFileTb.TabIndex = 3;
            this.newFileTb.Text = "newFile.bmp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selected file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "New file name";
            // 
            // encriptionKey
            // 
            this.encriptionKey.Location = new System.Drawing.Point(24, 153);
            this.encriptionKey.Name = "encriptionKey";
            this.encriptionKey.Size = new System.Drawing.Size(275, 20);
            this.encriptionKey.TabIndex = 6;
            this.encriptionKey.Text = "asdjkljklqqwe123qwe2123";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Encription key";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encriptionKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newFileTb);
            this.Controls.Add(this.selFileTb);
            this.Controls.Add(this.cryptBtn);
            this.Controls.Add(this.selFileBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selFileBtn;
        private System.Windows.Forms.Button cryptBtn;
        private System.Windows.Forms.TextBox selFileTb;
        private System.Windows.Forms.TextBox newFileTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox encriptionKey;
        private System.Windows.Forms.Label label3;
    }
}

