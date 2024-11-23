using DATAPlayer;
using DevExpress.XtraEditors;
using LOGICPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FRONTENDPlayer.TrangChu;


namespace FRONTENDPlayer
{
    public partial class SuaNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public NhanVien NhanVienHienTai { get; set; }
        NhanVienBackEnd nhanVienBE = new NhanVienBackEnd();
        public SuaNhanVien(NhanVien nhanVien)
        {
            InitializeComponent();
            NhanVienHienTai = nhanVien;
            LoadData();
        }
        public SuaNhanVien(NhanVien nhanVien, Action reloadDataCallback)
        {
            InitializeComponent();
            NhanVienHienTai = nhanVien;
            LoadData();
        }
        private void LoadData()
        {
            if (NhanVienHienTai != null)
            {
                txtMaNhanVien.Text = NhanVienHienTai.MaNhanVien;
                txtTenNhanVien.Text = NhanVienHienTai.TenNhanVien;
                dateNgaySinh.Text = NhanVienHienTai.NgaySinh?.ToString("dd/MM/yyyy");
                txtDiaChi.Text = NhanVienHienTai.DiaChi;
                txtSdt.Text = NhanVienHienTai.SoDienThoai;
                cmbPhongBan.EditValue = NhanVienHienTai.MaPhongBan;
                cmbChucVu.EditValue = NhanVienHienTai.MaChucVu;
            }
        }
       


        // Xử lý sự kiện nút Cập Nhật trong form SuaNhanVien
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các điều khiển
                string maNhanVien = txtMaNhanVien.Text;
                string tenNhanVien = txtTenNhanVien.Text;

                // Kiểm tra và lấy ngày sinh
                DateTime? ngaySinh = null;
                if (!string.IsNullOrEmpty(dateNgaySinh.Text))
                {
                    if (DateTime.TryParseExact(dateNgaySinh.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                    {
                        ngaySinh = parsedDate;
                    }
                    else
                    {
                        XtraMessageBox.Show("Ngày sinh không hợp lệ! Vui lòng nhập theo định dạng dd/MM/yyyy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string diaChi = txtDiaChi.Text;
                string soDienThoai = txtSdt.Text;

                // Kiểm tra số điện thoại: phải là chuỗi số và độ dài bằng 10
                if (soDienThoai.Length != 10 || !soDienThoai.All(char.IsDigit))
                {
                    XtraMessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy mã Phòng Ban từ ComboBox
                string maPhongBan = cmbPhongBan.EditValue?.ToString();
                if (string.IsNullOrEmpty(maPhongBan))
                {
                    XtraMessageBox.Show("Vui lòng chọn phòng ban!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy mã Chức Vụ từ ComboBox
                string maChucVu = cmbChucVu.EditValue?.ToString();
                if (string.IsNullOrEmpty(maChucVu))
                {
                    XtraMessageBox.Show("Vui lòng chọn chức vụ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng NhanVien để cập nhật
                NhanVien nhanVienSua = new NhanVien
                {
                    MaNhanVien = maNhanVien,
                    TenNhanVien = tenNhanVien,
                    NgaySinh = ngaySinh,
                    DiaChi = diaChi,
                    SoDienThoai = soDienThoai,
                    MaPhongBan = maPhongBan,
                    MaChucVu = maChucVu
                };

                // Gọi logic layer để cập nhật nhân viên
                bool isUpdated = nhanVienBE.UpdateNhanVien(nhanVienSua);

                if (isUpdated)
                {
                    XtraMessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Cập nhật thông tin nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSuaNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tKD_HRMDataSet.DM_ChucVu' table. You can move, or remove it, as needed.
            this.dM_ChucVuTableAdapter.Fill(this.HRMDataSet.DM_ChucVu);
            // TODO: This line of code loads data into the 'tKD_HRMDataSet.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this.HRMDataSet.PhongBan);
            // TODO: This line of code loads data into the 'tKD_HRMDataSet.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this.HRMDataSet.PhongBan);


        }

        private void dateNgaySinh_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
