namespace GUI
{
    partial class frmQuanLySanPham
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
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.cmbLoaiSP = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnNoLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dateNgayNhap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colNgayNhap,
            this.colLoaiSP});
            this.dgvSanPham.Location = new System.Drawing.Point(56, 108);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(883, 471);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            this.dgvSanPham.SelectionChanged += new System.EventHandler(this.dgvStudent_SelectionChanged);
            // 
            // colMaSP
            // 
            this.colMaSP.HeaderText = "Mã SP";
            this.colMaSP.MinimumWidth = 6;
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.Width = 125;
            // 
            // colTenSP
            // 
            this.colTenSP.HeaderText = "Tên Sản Phẩm";
            this.colTenSP.MinimumWidth = 6;
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Width = 150;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.HeaderText = "Ngày Nhập";
            this.colNgayNhap.MinimumWidth = 6;
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.Width = 150;
            // 
            // colLoaiSP
            // 
            this.colLoaiSP.HeaderText = "Loại SP";
            this.colLoaiSP.MinimumWidth = 6;
            this.colLoaiSP.Name = "colLoaiSP";
            this.colLoaiSP.Width = 125;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Firebrick;
            this.lblHeader.Location = new System.Drawing.Point(474, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(465, 54);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Danh Mục Sản Phẩm";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(1021, 225);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(47, 16);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1021, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1026, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại SP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1021, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Nhập";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(1137, 217);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(190, 22);
            this.txtMaSP.TabIndex = 5;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(1137, 276);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(190, 22);
            this.txtTenSP.TabIndex = 6;
            // 
            // cmbLoaiSP
            // 
            this.cmbLoaiSP.FormattingEnabled = true;
            this.cmbLoaiSP.Location = new System.Drawing.Point(1142, 403);
            this.cmbLoaiSP.Name = "cmbLoaiSP";
            this.cmbLoaiSP.Size = new System.Drawing.Size(190, 24);
            this.cmbLoaiSP.TabIndex = 9;
            this.cmbLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(56, 605);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 38);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(380, 605);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 38);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(56, 76);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(120, 22);
            this.txtTimKiem.TabIndex = 13;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(241, 72);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(102, 30);
            this.btnTim.TabIndex = 14;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(220, 605);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 38);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(531, 605);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 38);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnNoLuu
            // 
            this.btnNoLuu.Location = new System.Drawing.Point(691, 605);
            this.btnNoLuu.Name = "btnNoLuu";
            this.btnNoLuu.Size = new System.Drawing.Size(109, 38);
            this.btnNoLuu.TabIndex = 17;
            this.btnNoLuu.Text = "Không Luu";
            this.btnNoLuu.UseVisualStyleBackColor = true;
            this.btnNoLuu.Click += new System.EventHandler(this.btnNoLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(829, 605);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 38);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dateNgayNhap
            // 
            this.dateNgayNhap.Location = new System.Drawing.Point(1142, 338);
            this.dateNgayNhap.Name = "dateNgayNhap";
            this.dateNgayNhap.Size = new System.Drawing.Size(200, 22);
            this.dateNgayNhap.TabIndex = 19;
            // 
            // frmQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 664);
            this.Controls.Add(this.dateNgayNhap);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNoLuu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.cmbLoaiSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label3);
            this.Name = "frmQuanLySanPham";
            this.Text = "Quản Lý Sản Phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLySanPham_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.ComboBox cmbLoaiSP;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiSP;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnNoLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dateNgayNhap;
    }
}

