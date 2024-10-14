public partial class frmQuanLySanPham : Form
{
    private readonly SanPhamService sanPhamService = new SanPhamService();
    private readonly LoaiSPService loaiSpService = new LoaiSPService();
  
    public frmQuanLySanPham()
    {
        InitializeComponent();
        btnLuu.Visible = false; // ?n n�t L?u khi kh?i ??ng
        btnKhongLuu.Visible = false; // ?n n�t Kh�ng L?u khi kh?i ??ng
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Vui l�ng nh?p ??y ?? th�ng tin!");
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

            MessageBox.Show("Th�m S?n Ph?m Th�nh C�ng");

            // Hi?n th? n�t L?u v� Kh�ng L?u
            btnLuu.Visible = true;
            btnKhongLuu.Visible = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Th�m S?n Ph?m Kh�ng Th�nh C�ng: " + ex.Message);
        }
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {
        // Th?c hi?n l?u d? li?u
        // ?n n�t L?u v� Kh�ng L?u sau khi l?u
        btnLuu.Visible = false;
        btnKhongLuu.Visible = false;
    }

    private void btnKhongLuu_Click(object sender, EventArgs e)
    {
        // Th?c hi?n h�nh ??ng kh�ng l?u d? li?u
        // ?n n�t L?u v� Kh�ng L?u sau khi kh�ng l?u
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
