namespace QLTaiKhoanApp
{
    partial class MainFormAdmin
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Exit_mainform_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(62, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2108, 1063);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button4.Location = new System.Drawing.Point(1091, 536);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(780, 421);
            this.button4.TabIndex = 3;
            this.button4.Text = "Lập Report";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button3.Location = new System.Drawing.Point(1091, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(780, 421);
            this.button3.TabIndex = 2;
            this.button3.Text = "Lập Phiếu Gửi Tiền";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button2.Location = new System.Drawing.Point(224, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(780, 421);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lập Phiếu Rút Tiền";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.Location = new System.Drawing.Point(224, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(780, 421);
            this.button1.TabIndex = 0;
            this.button1.Text = "In Danh Sách Khách Hàng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Exit_mainform_btn
            // 
            this.Exit_mainform_btn.Location = new System.Drawing.Point(1866, 209);
            this.Exit_mainform_btn.Name = "Exit_mainform_btn";
            this.Exit_mainform_btn.Size = new System.Drawing.Size(304, 84);
            this.Exit_mainform_btn.TabIndex = 1;
            this.Exit_mainform_btn.Text = "Đăng Xuất";
            this.Exit_mainform_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(517, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1056, 135);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lí Tài Khoản";
            // 
            // MainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2237, 1445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_mainform_btn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximumSize = new System.Drawing.Size(2273, 1548);
            this.MinimumSize = new System.Drawing.Size(2273, 1548);
            this.Name = "MainFormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFormAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Exit_mainform_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}