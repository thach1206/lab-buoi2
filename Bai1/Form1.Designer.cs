namespace Bai1
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
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.txtNb1 = new System.Windows.Forms.TextBox();
            this.txtNb2 = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.lblRs = new System.Windows.Forms.Label();
            this.txtRs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(146, 19);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(74, 20);
            this.lblNumber1.TabIndex = 0;
            this.lblNumber1.Text = "Number1";
            this.lblNumber1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(146, 80);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(74, 20);
            this.lblNumber2.TabIndex = 1;
            this.lblNumber2.Text = "Number2";
            // 
            // txtNb1
            // 
            this.txtNb1.Location = new System.Drawing.Point(272, 19);
            this.txtNb1.Name = "txtNb1";
            this.txtNb1.Size = new System.Drawing.Size(330, 26);
            this.txtNb1.TabIndex = 2;
            // 
            // txtNb2
            // 
            this.txtNb2.Location = new System.Drawing.Point(272, 74);
            this.txtNb2.Name = "txtNb2";
            this.txtNb2.Size = new System.Drawing.Size(330, 26);
            this.txtNb2.TabIndex = 3;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(144, 155);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 75);
            this.btnCong.TabIndex = 4;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            this.btnCong.Enter += new System.EventHandler(this.label1_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(272, 155);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(75, 75);
            this.btnTru.TabIndex = 5;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            this.btnTru.Enter += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(391, 155);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(75, 75);
            this.btnNhan.TabIndex = 6;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            this.btnNhan.Enter += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(527, 155);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(75, 75);
            this.btnChia.TabIndex = 7;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            this.btnChia.Enter += new System.EventHandler(this.btnChia_Click);
            // 
            // lblRs
            // 
            this.lblRs.AutoSize = true;
            this.lblRs.Location = new System.Drawing.Point(140, 286);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(55, 20);
            this.lblRs.TabIndex = 8;
            this.lblRs.Text = "Result";
            // 
            // txtRs
            // 
            this.txtRs.Location = new System.Drawing.Point(272, 286);
            this.txtRs.Name = "txtRs";
            this.txtRs.Size = new System.Drawing.Size(330, 26);
            this.txtRs.TabIndex = 9;
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 483);
            this.Controls.Add(this.txtRs);
            this.Controls.Add(this.lblRs);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtNb2);
            this.Controls.Add(this.txtNb1);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.TextBox txtNb1;
        private System.Windows.Forms.TextBox txtNb2;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Label lblRs;
        private System.Windows.Forms.TextBox txtRs;
    }
}

