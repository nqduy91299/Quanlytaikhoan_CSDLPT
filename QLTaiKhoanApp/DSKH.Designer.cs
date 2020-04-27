namespace QLTaiKhoanApp
{
    partial class DSKH
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
            this.dataGridView_DSKH = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ten_DSKH_tb = new System.Windows.Forms.TextBox();
            this.diachi_DSKH_tb = new System.Windows.Forms.TextBox();
            this.cmnd_DSKH_tb = new System.Windows.Forms.TextBox();
            this.chinhnah_DSKH_tb = new System.Windows.Forms.TextBox();
            this.dateTimePicker_DSKH_ngaycap = new System.Windows.Forms.DateTimePicker();
            this.Them_DSKH_btn = new System.Windows.Forms.Button();
            this.thoat_DSKH_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYCAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_DSKH
            // 
            this.dataGridView_DSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HOTEN,
            this.DIACHI,
            this.CMND,
            this.NGAYCAP,
            this.MACN});
            this.dataGridView_DSKH.Location = new System.Drawing.Point(30, 309);
            this.dataGridView_DSKH.Name = "dataGridView_DSKH";
            this.dataGridView_DSKH.RowHeadersWidth = 123;
            this.dataGridView_DSKH.RowTemplate.Height = 46;
            this.dataGridView_DSKH.Size = new System.Drawing.Size(1258, 874);
            this.dataGridView_DSKH.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.thoat_DSKH_btn);
            this.groupBox1.Controls.Add(this.Them_DSKH_btn);
            this.groupBox1.Controls.Add(this.dateTimePicker_DSKH_ngaycap);
            this.groupBox1.Controls.Add(this.chinhnah_DSKH_tb);
            this.groupBox1.Controls.Add(this.cmnd_DSKH_tb);
            this.groupBox1.Controls.Add(this.diachi_DSKH_tb);
            this.groupBox1.Controls.Add(this.ten_DSKH_tb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1351, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 875);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đia chỉ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "CMND:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày cấp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 571);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chi Nhánh:";
            // 
            // ten_DSKH_tb
            // 
            this.ten_DSKH_tb.Location = new System.Drawing.Point(215, 68);
            this.ten_DSKH_tb.Name = "ten_DSKH_tb";
            this.ten_DSKH_tb.Size = new System.Drawing.Size(416, 44);
            this.ten_DSKH_tb.TabIndex = 5;
            // 
            // diachi_DSKH_tb
            // 
            this.diachi_DSKH_tb.Location = new System.Drawing.Point(215, 185);
            this.diachi_DSKH_tb.Name = "diachi_DSKH_tb";
            this.diachi_DSKH_tb.Size = new System.Drawing.Size(416, 44);
            this.diachi_DSKH_tb.TabIndex = 6;
            // 
            // cmnd_DSKH_tb
            // 
            this.cmnd_DSKH_tb.Location = new System.Drawing.Point(215, 301);
            this.cmnd_DSKH_tb.Name = "cmnd_DSKH_tb";
            this.cmnd_DSKH_tb.Size = new System.Drawing.Size(416, 44);
            this.cmnd_DSKH_tb.TabIndex = 7;
            // 
            // chinhnah_DSKH_tb
            // 
            this.chinhnah_DSKH_tb.Location = new System.Drawing.Point(215, 568);
            this.chinhnah_DSKH_tb.Name = "chinhnah_DSKH_tb";
            this.chinhnah_DSKH_tb.ReadOnly = true;
            this.chinhnah_DSKH_tb.Size = new System.Drawing.Size(416, 44);
            this.chinhnah_DSKH_tb.TabIndex = 8;
            // 
            // dateTimePicker_DSKH_ngaycap
            // 
            this.dateTimePicker_DSKH_ngaycap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DSKH_ngaycap.Location = new System.Drawing.Point(215, 432);
            this.dateTimePicker_DSKH_ngaycap.Name = "dateTimePicker_DSKH_ngaycap";
            this.dateTimePicker_DSKH_ngaycap.Size = new System.Drawing.Size(416, 44);
            this.dateTimePicker_DSKH_ngaycap.TabIndex = 9;
            // 
            // Them_DSKH_btn
            // 
            this.Them_DSKH_btn.Location = new System.Drawing.Point(32, 737);
            this.Them_DSKH_btn.Name = "Them_DSKH_btn";
            this.Them_DSKH_btn.Size = new System.Drawing.Size(268, 104);
            this.Them_DSKH_btn.TabIndex = 10;
            this.Them_DSKH_btn.Text = "Thêm";
            this.Them_DSKH_btn.UseVisualStyleBackColor = true;
            this.Them_DSKH_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // thoat_DSKH_btn
            // 
            this.thoat_DSKH_btn.Location = new System.Drawing.Point(363, 737);
            this.thoat_DSKH_btn.Name = "thoat_DSKH_btn";
            this.thoat_DSKH_btn.Size = new System.Drawing.Size(268, 104);
            this.thoat_DSKH_btn.TabIndex = 11;
            this.thoat_DSKH_btn.Text = "Thoát";
            this.thoat_DSKH_btn.UseVisualStyleBackColor = true;
            this.thoat_DSKH_btn.Click += new System.EventHandler(this.thoat_DSKH_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1249, 126);
            this.label6.TabIndex = 2;
            this.label6.Text = "Danh Sách Khách Hàng";
            // 
            // HOTEN
            // 
            this.HOTEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Tên";
            this.HOTEN.MinimumWidth = 15;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            this.HOTEN.Width = 135;
            // 
            // DIACHI
            // 
            this.DIACHI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.MinimumWidth = 15;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            this.DIACHI.Width = 185;
            // 
            // CMND
            // 
            this.CMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.MinimumWidth = 15;
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            this.CMND.Width = 176;
            // 
            // NGAYCAP
            // 
            this.NGAYCAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NGAYCAP.DataPropertyName = "NGAYCAP";
            this.NGAYCAP.HeaderText = "Ngày Cấp";
            this.NGAYCAP.MinimumWidth = 15;
            this.NGAYCAP.Name = "NGAYCAP";
            this.NGAYCAP.ReadOnly = true;
            this.NGAYCAP.Width = 223;
            // 
            // MACN
            // 
            this.MACN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MACN.DataPropertyName = "MACN";
            this.MACN.HeaderText = "Mã Chi Nhánh";
            this.MACN.MinimumWidth = 15;
            this.MACN.Name = "MACN";
            this.MACN.ReadOnly = true;
            this.MACN.Width = 263;
            // 
            // DSKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2104, 1282);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_DSKH);
            this.MaximumSize = new System.Drawing.Size(2140, 1385);
            this.MinimumSize = new System.Drawing.Size(2140, 1385);
            this.Name = "DSKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSKH";
            this.Load += new System.EventHandler(this.DSKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSKH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_DSKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button thoat_DSKH_btn;
        private System.Windows.Forms.Button Them_DSKH_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DSKH_ngaycap;
        private System.Windows.Forms.TextBox chinhnah_DSKH_tb;
        private System.Windows.Forms.TextBox cmnd_DSKH_tb;
        private System.Windows.Forms.TextBox diachi_DSKH_tb;
        private System.Windows.Forms.TextBox ten_DSKH_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYCAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACN;
    }
}