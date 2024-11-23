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

namespace FRONTENDPlayer
{
    public partial class SuaCongTac : DevExpress.XtraEditors.XtraForm
    {
        public QT_CongTac CTHienTai { get; set; }
        CongTacBackEnd CTBackEnd = new CongTacBackEnd();
        public SuaCongTac(QT_CongTac CongTac)
        {
            InitializeComponent();
            CTHienTai = CongTac;
            LoadData();
        }
        private void LoadData()
        {
            if (CTHienTai != null)
            {
                // Kiểm tra và định dạng lại chuỗi ngày tháng với định dạng dd/MM/yyyy
                NgayBatDau.Text = CTHienTai.BatDau.HasValue ? CTHienTai.BatDau.Value.ToString("dd/MM/yyyy") : string.Empty;
                NgayKetThuc.Text = CTHienTai.KetThuc.HasValue ? CTHienTai.KetThuc.Value.ToString("dd/MM/yyyy") : string.Empty;

                // Gán các trường khác mà không cần thay đổi
                txtGhiChu.Text = CTHienTai.GhiChu;
                cmbMaCT.EditValue = CTHienTai.MaCT;
                cmbNhanVien.EditValue = CTHienTai.MaNhanVien;
            }
        }





        // Xử lý sự kiện nút Cập Nhật trong form SuaNhanVien
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các điều khiển
                string maCT = cmbMaCT.Text;
                string ghichu = txtGhiChu.Text;

                // Lấy Nhân Viên từ ComboBox
                string maNhanVien = cmbNhanVien.EditValue?.ToString();
                if (string.IsNullOrEmpty(maNhanVien))
                {
                    XtraMessageBox.Show("Vui lòng chọn nhân viên đi công tác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra và lấy ngày bắt đầu và kết thúc
                DateTime? batdau = null;
                if (!string.IsNullOrEmpty(NgayBatDau.Text))
                {
                    if (DateTime.TryParseExact(NgayBatDau.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                    {
                        batdau = parsedDate;
                    }
                    else
                    {
                        XtraMessageBox.Show("Ngày không hợp lệ! Vui lòng nhập theo định dạng dd/MM/yyyy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                DateTime? ketthuc = null;
                if (!string.IsNullOrEmpty(NgayKetThuc.Text))
                {
                    if (DateTime.TryParseExact(NgayKetThuc.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                    {
                        ketthuc = parsedDate;
                    }
                    else
                    {
                        XtraMessageBox.Show("Ngày không hợp lệ! Vui lòng nhập theo định dạng dd/MM/yyyy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Kiểm tra ngày bắt đầu phải nhỏ hơn ngày kết thúc
                if (batdau.HasValue && ketthuc.HasValue && batdau >= ketthuc)
                {
                    XtraMessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng NhanVien mới
                QT_CongTac CongTacMoi = new QT_CongTac
                {
                    MaCT = maCT,
                    MaNhanVien = maNhanVien,
                    BatDau = batdau,
                    KetThuc = ketthuc,
                    GhiChu = ghichu
                };

                //Gọi logic layer để thêm công tác
                bool isAdded = CTBackEnd.UpdateCongTac(CongTacMoi);

                if (isAdded)
                {
                    XtraMessageBox.Show("Cập nhật công tác mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Cập nhật công tác mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void SuaCongTac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMDataSet.QT_CongTac' table. You can move, or remove it, as needed.
            this.qT_CongTacTableAdapter.Fill(this.hRMDataSet.QT_CongTac);
            // TODO: This line of code loads data into the 'hRMDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.hRMDataSet.NhanVien);

        }
    }
}
