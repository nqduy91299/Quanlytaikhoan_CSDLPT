namespace QLTaiKhoanApp
{
    partial class ReportForm
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
            this.dataGridView_report = new System.Windows.Forms.DataGridView();
            this.MAPHIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYGUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAISUAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTIEN_GUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYDENHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAGDV_LPG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYRUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENLAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAGDV_LPR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(872, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(892, 217);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORT";
            // 
            // dataGridView_report
            // 
            this.dataGridView_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPHIEU,
            this.CMND,
            this.MADV,
            this.NGAYGUI,
            this.LAISUAT,
            this.SOTIEN_GUI,
            this.NGAYDENHAN,
            this.MAGDV_LPG,
            this.NGAYRUT,
            this.TIENLAI,
            this.MAGDV_LPR});
            this.dataGridView_report.Location = new System.Drawing.Point(30, 302);
            this.dataGridView_report.Name = "dataGridView_report";
            this.dataGridView_report.RowHeadersWidth = 123;
            this.dataGridView_report.RowTemplate.Height = 46;
            this.dataGridView_report.Size = new System.Drawing.Size(2598, 1155);
            this.dataGridView_report.TabIndex = 1;
            // 
            // MAPHIEU
            // 
            this.MAPHIEU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MAPHIEU.DataPropertyName = "MAPHIEU";
            this.MAPHIEU.HeaderText = "Mã Phiếu";
            this.MAPHIEU.MinimumWidth = 15;
            this.MAPHIEU.Name = "MAPHIEU";
            this.MAPHIEU.ReadOnly = true;
            this.MAPHIEU.Width = 214;
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
            // MADV
            // 
            this.MADV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MADV.DataPropertyName = "MADV";
            this.MADV.HeaderText = "Mã DV";
            this.MADV.MinimumWidth = 15;
            this.MADV.Name = "MADV";
            this.MADV.ReadOnly = true;
            this.MADV.Width = 178;
            // 
            // NGAYGUI
            // 
            this.NGAYGUI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NGAYGUI.DataPropertyName = "NGAYGUI";
            this.NGAYGUI.HeaderText = "Ngày Gửi";
            this.NGAYGUI.MinimumWidth = 15;
            this.NGAYGUI.Name = "NGAYGUI";
            this.NGAYGUI.ReadOnly = true;
            this.NGAYGUI.Width = 214;
            // 
            // LAISUAT
            // 
            this.LAISUAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LAISUAT.DataPropertyName = "LAISUAT";
            this.LAISUAT.HeaderText = "Lãi Suất";
            this.LAISUAT.MinimumWidth = 15;
            this.LAISUAT.Name = "LAISUAT";
            this.LAISUAT.ReadOnly = true;
            this.LAISUAT.Width = 198;
            // 
            // SOTIEN_GUI
            // 
            this.SOTIEN_GUI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SOTIEN_GUI.DataPropertyName = "SOTIEN_GUI";
            this.SOTIEN_GUI.HeaderText = "Số Tiền Gửi";
            this.SOTIEN_GUI.MinimumWidth = 15;
            this.SOTIEN_GUI.Name = "SOTIEN_GUI";
            this.SOTIEN_GUI.Width = 249;
            // 
            // NGAYDENHAN
            // 
            this.NGAYDENHAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NGAYDENHAN.DataPropertyName = "NGAYDENHAN";
            this.NGAYDENHAN.HeaderText = "Ngày Đến Hạn";
            this.NGAYDENHAN.MinimumWidth = 15;
            this.NGAYDENHAN.Name = "NGAYDENHAN";
            this.NGAYDENHAN.ReadOnly = true;
            this.NGAYDENHAN.Width = 214;
            // 
            // MAGDV_LPG
            // 
            this.MAGDV_LPG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MAGDV_LPG.DataPropertyName = "MAGDV_LPG";
            this.MAGDV_LPG.HeaderText = "Mã GDV Lập Phiếu Gửi";
            this.MAGDV_LPG.MinimumWidth = 15;
            this.MAGDV_LPG.Name = "MAGDV_LPG";
            this.MAGDV_LPG.ReadOnly = true;
            this.MAGDV_LPG.Width = 334;
            // 
            // NGAYRUT
            // 
            this.NGAYRUT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NGAYRUT.DataPropertyName = "NGAYRUT";
            this.NGAYRUT.HeaderText = "Ngày Rút Tiền";
            this.NGAYRUT.MinimumWidth = 15;
            this.NGAYRUT.Name = "NGAYRUT";
            this.NGAYRUT.ReadOnly = true;
            this.NGAYRUT.Width = 206;
            // 
            // TIENLAI
            // 
            this.TIENLAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TIENLAI.DataPropertyName = "TIENLAI";
            this.TIENLAI.HeaderText = "Tiền Lãi";
            this.TIENLAI.MinimumWidth = 15;
            this.TIENLAI.Name = "TIENLAI";
            this.TIENLAI.ReadOnly = true;
            this.TIENLAI.Width = 142;
            // 
            // MAGDV_LPR
            // 
            this.MAGDV_LPR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MAGDV_LPR.DataPropertyName = "MAGDV_LPR";
            this.MAGDV_LPR.HeaderText = "Mã GDV Lập Phiếu Rút";
            this.MAGDV_LPR.MinimumWidth = 15;
            this.MAGDV_LPR.Name = "MAGDV_LPR";
            this.MAGDV_LPR.ReadOnly = true;
            this.MAGDV_LPR.Width = 334;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2676, 1486);
            this.Controls.Add(this.dataGridView_report);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(2712, 1589);
            this.MinimumSize = new System.Drawing.Size(2712, 1589);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_report;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYGUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAISUAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTIEN_GUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYDENHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGDV_LPG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYRUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENLAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGDV_LPR;
    }
}