using BUS;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class frmQuanLySanPham : Form
    {
        private readonly SanPhamService sanPhamService = new SanPhamService();
        private readonly LoaiSPService loaiSpService = new LoaiSPService();
      
        public frmQuanLySanPham()
        {
            InitializeComponent();

        }
        private void LoadStudentData()
        {
            List<Sanpham> sanphams = sanPhamService.GetAll();
            BindGrid(sanphams);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dgvSanPham);
                var listSanPhams = sanPhamService.GetAll();
                var listLoaiSps = loaiSpService.GetAll();

                FillLoaiSPCombobox(listLoaiSps);
                BindGrid(listSanPhams);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        //Hàm binding list dữ liệu khoa vào combobox có tên hiện thị là tên khoa, giá trị là Mã khoa
        private void FillLoaiSPCombobox(List<LoaiSP> listLoaiSP)
        {
            listLoaiSP.Insert(0, new LoaiSP());
            this.cmbLoaiSP.DataSource = listLoaiSP;
            this.cmbLoaiSP.DisplayMember = "TenSP";
            this.cmbLoaiSP.ValueMember = "MaLoai";
         }
            //Hàm binding gridView từ list sinh viên
        private void BindGrid(List<Sanpham> sanphams)
        {
            dgvSanPham.Rows.Clear();
            foreach (var item in sanphams)
            {
                int index = dgvSanPham.Rows.Add();
                dgvSanPham.Rows[index].Cells[0].Value = item.MaSP;
                dgvSanPham.Rows[index].Cells[1].Value = item.TenSP;
                if (item.LoaiSP != null)
                    dgvSanPham.Rows[index].Cells[2].Value = item.Ngaynhap;
                dgvSanPham.Rows[index].Cells[3].Value = item.TenSP + "";
              
            }
        }

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    SanPhamService context = new SanPhamService();

        //    var student = context.FindById(txtMaSP.Text);
        //    if (student == null)
        //    {
        //        // Thêm mới sinh viên
        //        Sanpham sanpham = new Sanpham()
        //        {
        //            MaSP = txtMaSP.Text,
        //            TenSP = txtTenSP.Text,
        //            Ngaynhap = dateNgayNhap.Value,
        //            MaLoai = cmbLoaiSP.SelectedValue.ToString(),
        //        };
        //        context.InsertUpdate(sanpham);
        //        MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }

        //    //try
        //    //{
        //    //    if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text))
        //    //    {
        //    //        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        //    //        return;
        //    //    }
        //    //    string MaSP = txtMaSP.Text;
        //    //    string fullname = txtTenSP.Text.Trim();
        //    //    string maLoaiStr = cmbLoaiSP.SelectedValue.ToString();
        //    //    DateTime ngaynhap = dateNgayNhap.Value;


        //    //    Sanpham s = new Sanpham()
        //    //    {
        //    //        MaSP = MaSP,
        //    //        TenSP = fullname,
        //    //        Ngaynhap = ngaynhap,
        //    //        MaLoai = maLoaiStr
        //    //    };
        //    //    context.InsertUpdate(s);
        //    //    LoadStudentData();
        //    //    // Reset dữ liệu sau khi thêm thành công
        //    //    ResetInputFields();

        //    //    MessageBox.Show("Thêm Sản Phẩm Thành Công");
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show("Thêm Sản Phẩm Không Thành Công: " + ex.Message);
        //    //}


        //}
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                SanPhamService context = new SanPhamService();

                // Kiểm tra xem sản phẩm đã tồn tại chưa
                var sanpham = context.FindById(txtMaSP.Text);
                if (sanpham == null)
                {
                    // Thêm mới sản phẩm
                    sanpham = new Sanpham()
                    {
                        MaSP = txtMaSP.Text,
                        TenSP = txtTenSP.Text,
                        Ngaynhap = dateNgayNhap.Value,
                        MaLoai = cmbLoaiSP.SelectedValue.ToString(),
                    };
                    context.InsertUpdate(sanpham);
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Hiển thị nút Lưu và Không Lưu
                    btnLuu.Visible = true;
                    btnNoLuu.Visible = true;

                    // Tải lại dữ liệu và reset các trường nhập liệu
                    LoadStudentData();
                    ResetInputFields();
                }
                else
                {
                    MessageBox.Show("Sản phẩm đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Sản Phẩm Không Thành Công: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetInputFields()
        {
            //txtMaSP.Clear();
            //txtTenSP.Clear();
            //txtAverageScore.Clear();
            //cmbLoaiSP.SelectedIndex = 0;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string maSp = txtMaSP.Text;
                sanPhamService.DeleteStudent(maSp);
                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudentData(); // Cập nhật lại danh sách sau khi xóa
                ResetInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi xóa sinh viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudent_SelectionChanged(object sender, EventArgs e)
        {
         
        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem dòng được chọn có hợp lệ không
                if (e.RowIndex >= 0)
                {
                    // Lấy dòng hiện tại
                    DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                    // Hiển thị thông tin sinh viên từ dòng đã chọn vào các ô nhập liệu
                    txtMaSP.Text = row.Cells[0].Value.ToString();
                    txtTenSP.Text = row.Cells[1].Value.ToString();
                    dateNgayNhap.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                    cmbLoaiSP.SelectedIndex = cmbLoaiSP.FindStringExact(row.Cells[3].Value.ToString()); // Tìm và chọn giá trị của combobox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SanPhamService context = new SanPhamService();

            var sanPham = context.FindById(txtMaSP.Text);
            if (sanPham != null)
            {
                // Cập nhật dữ liệu sản phẩm
                sanPham.TenSP = txtTenSP.Text;
                sanPham.Ngaynhap = dateNgayNhap.Value;
                sanPham.MaLoai = cmbLoaiSP.SelectedValue.ToString();

                sanPhamService.InsertUpdate(sanPham);
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadStudentData();
            // Reset dữ liệu sau khi sửa thành công
            ResetInputFields();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            //btnLuu.Visible = false;
            //btnNoLuu.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmQuanLySanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true; // Cancel the form closing event
            //DialogResult result = MessageBox.Show("Bạn có muốn đóng form?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (result == DialogResult.Cancel)
            //{
            //    this.Close();
            //}
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string searchValue = txtTimKiem.Text.ToLower();
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (row.Cells[0].Value != null)
                    row.Visible = row.Cells[0].Value.ToString().ToLower().Contains(searchValue) ||
                              row.Cells[1].Value.ToString().ToLower().Contains(searchValue);
            }
        }

        private void btnNoLuu_Click(object sender, EventArgs e)
        {
            //// Thực hiện hành động không lưu dữ liệu
            //// Ẩn nút Lưu và Không Lưu sau khi không lưu
            //btnLuu.Visible = false;
            //btnNoLuu.Visible = false;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

            SanPhamService context = new SanPhamService();

            var student = context.FindById(txtMaSP.Text);
            if (student == null)
            {
                // Thêm mới sinh viên
                Sanpham sanpham = new Sanpham()
                {
                    MaSP = txtMaSP.Text,
                    TenSP = txtTenSP.Text,
                    Ngaynhap = dateNgayNhap.Value,
                    MaLoai = cmbLoaiSP.SelectedValue.ToString(),
                };
                context.InsertUpdate(sanpham);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadStudentData();
        }
    }
}
