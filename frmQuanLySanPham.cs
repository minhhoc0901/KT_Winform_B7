public partial class frmQuanLySanPham : Form
{
    private readonly SanPhamService sanPhamService = new SanPhamService();
    private readonly LoaiSPService loaiSpService = new LoaiSPService();
  
    public frmQuanLySanPham()
    {
        InitializeComponent();
        btnLuu.Visible = false; // ?n nút L?u khi kh?i ??ng
        btnKhongLuu.Visible = false; // ?n nút Không L?u khi kh?i ??ng
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Vui lòng nh?p ??y ?? thông tin!");
                return;
            }
            string MaSP = txtMaSP.Text;
            string fullname = txtTenSP.Text.Trim();
            string maLoaiStr = cmbLoaiSP.SelectedValue.ToString();
            DateTime ngaynhap = dateNgayNhap.Value;

            Sanpham s = new Sanpham()
            {
                MaSP = MaSP,
                TenSP = fullname,
                Ngaynhap = ngaynhap,
                MaLoai = maLoaiStr
            };

            sanPhamService.InsertUpdate(s);
            LoadStudentData();
            ResetInputFields();

            MessageBox.Show("Thêm S?n Ph?m Thành Công");

            // Hi?n th? nút L?u và Không L?u
            btnLuu.Visible = true;
            btnKhongLuu.Visible = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Thêm S?n Ph?m Không Thành Công: " + ex.Message);
        }
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {
        // Th?c hi?n l?u d? li?u
        // ?n nút L?u và Không L?u sau khi l?u
        btnLuu.Visible = false;
        btnKhongLuu.Visible = false;
    }

    private void btnKhongLuu_Click(object sender, EventArgs e)
    {
        // Th?c hi?n hành ??ng không l?u d? li?u
        // ?n nút L?u và Không L?u sau khi không l?u
        btnLuu.Visible = false;
        btnKhongLuu.Visible = false;
    }

    private void ResetInputFields()
    {
        txtMaSP.Clear();
        txtTenSP.Clear();
        cmbLoaiSP.SelectedIndex = 0;
        dateNgayNhap.Value = DateTime.Now;
    }
}
