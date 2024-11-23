using DATAPlayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace LOGICPlayer
{
    public class NhanVienBackEnd
    {
        readonly HRMEntities Adapter = new HRMEntities();
        //public List<NhanVien> LoadDataTable() => Adapter.NhanViens.AsNoTracking().ToList();
        public List<object> LoadDataTable()
        {
            return Adapter.NhanVien
                .AsNoTracking()
                .Join(
                    Adapter.PhongBan,  // Bảng PhongBan
                    nv => nv.MaPhongBan,  // Khóa ngoại ở NhanVien
                    pb => pb.MaPhongBan,  // Khóa chính ở PhongBan
                    (nv, pb) => new { nv, pb })  // Kết hợp dữ liệu
                .Join(
                    Adapter.DM_ChucVu,  // Bảng ChucVu
                    nvpb => nvpb.nv.MaChucVu,  // Khóa ngoại ở NhanVien
                    cv => cv.MaChucVu,  // Khóa chính ở ChucVu
                    (nvpb, cv) => new // Kết hợp thêm dữ liệu của ChucVu
                    {
                        MaNhanVien = nvpb.nv.MaNhanVien,
                        TenNhanVien = nvpb.nv.TenNhanVien,
                        NgaySinh = nvpb.nv.NgaySinh,
                        DiaChi = nvpb.nv.DiaChi,
                        SoDienThoai = nvpb.nv.SoDienThoai,
                        TenPhongBan = nvpb.pb.TenPhongBan,  // Lấy tên phòng ban
                        TenChucVu = cv.TenChucVu,  // Lấy tên chức vụ
                        TinhTrangLamViec = nvpb.nv.TinhTrangLamViec
                    })
                .ToList<object>();
        }

        public List<object> LoadDataTable_ThoiViec()
        {
            return Adapter.NhanVien
                .AsNoTracking()
                .Where(nv => nv.TinhTrangLamViec == false) // Điều kiện lọc nhân viên nghỉ việc
                .Join(
                    Adapter.PhongBan,  // Bảng PhongBan
                    nv => nv.MaPhongBan,  // Khóa ngoại ở NhanVien
                    pb => pb.MaPhongBan,  // Khóa chính ở PhongBan
                    (nv, pb) => new { nv, pb })  // Kết hợp dữ liệu
                .Join(
                    Adapter.DM_ChucVu,  // Bảng ChucVu
                    nvpb => nvpb.nv.MaChucVu,  // Khóa ngoại ở NhanVien
                    cv => cv.MaChucVu,  // Khóa chính ở ChucVu
                    (nvpb, cv) => new // Kết hợp thêm dữ liệu của ChucVu
                    {
                        MaNhanVien = nvpb.nv.MaNhanVien,
                        TenNhanVien = nvpb.nv.TenNhanVien,
                        NgaySinh = nvpb.nv.NgaySinh,
                        DiaChi = nvpb.nv.DiaChi,
                        SoDienThoai = nvpb.nv.SoDienThoai,
                        TenPhongBan = nvpb.pb.TenPhongBan,  // Lấy tên phòng ban
                        TenChucVu = cv.TenChucVu,  // Lấy tên chức vụ
                        TinhTrangLamViec = nvpb.nv.TinhTrangLamViec
                    })
                .ToList<object>();
        }

        public List<object> LoadDataTable_DangLamViec()
        {
            return Adapter.NhanVien
                .AsNoTracking()
                .Where(nv => nv.TinhTrangLamViec == true) // Điều kiện lọc nhân viên nghỉ việc
                .Join(
                    Adapter.PhongBan,  // Bảng PhongBan
                    nv => nv.MaPhongBan,  // Khóa ngoại ở NhanVien
                    pb => pb.MaPhongBan,  // Khóa chính ở PhongBan
                    (nv, pb) => new { nv, pb })  // Kết hợp dữ liệu
                .Join(
                    Adapter.DM_ChucVu,  // Bảng ChucVu
                    nvpb => nvpb.nv.MaChucVu,  // Khóa ngoại ở NhanVien
                    cv => cv.MaChucVu,  // Khóa chính ở ChucVu
                    (nvpb, cv) => new // Kết hợp thêm dữ liệu của ChucVu
                    {
                        MaNhanVien = nvpb.nv.MaNhanVien,
                        TenNhanVien = nvpb.nv.TenNhanVien,
                        NgaySinh = nvpb.nv.NgaySinh,
                        DiaChi = nvpb.nv.DiaChi,
                        SoDienThoai = nvpb.nv.SoDienThoai,
                        TenPhongBan = nvpb.pb.TenPhongBan,  // Lấy tên phòng ban
                        TenChucVu = cv.TenChucVu,  // Lấy tên chức vụ
                        TinhTrangLamViec = nvpb.nv.TinhTrangLamViec
                    })
                .ToList<object>();
        }

        public string TaoMaNhanVienMoi()
        {
            // Tự động tạo mã nhân viên mới
            string lastMaNhanVien = Adapter.NhanVien
                .Where(nv => nv.MaNhanVien.StartsWith("TKD"))
                .OrderByDescending(nv => nv.MaNhanVien)
                .Select(nv => nv.MaNhanVien)
                .FirstOrDefault();

            string maNhanVien;
            if (!string.IsNullOrEmpty(lastMaNhanVien))
            {
                string prefix = "TKD";
                string numberPart = lastMaNhanVien.Substring(prefix.Length);
                int nextNumber = int.Parse(numberPart) + 1;
                maNhanVien = $"{prefix}{nextNumber.ToString("D2")}";
            }
            else
            {
                maNhanVien = "TKD01";
            }

            return maNhanVien;
        }
        public string layMaPhongBanByTen(string tenPhongBan)
        {
            // Truy vấn mã phòng ban từ tên phòng ban
            var phongBan = Adapter.PhongBan
                .FirstOrDefault(pb => pb.TenPhongBan.Equals(tenPhongBan, StringComparison.OrdinalIgnoreCase));

            return phongBan?.MaPhongBan; // Trả về mã phòng ban hoặc null nếu không tìm thấy
        }

        public string layMaChucVuByTen(string tenChucVu)
        {
            // Truy vấn mã chức vụ từ tên chức vụ
            var chucVu = Adapter.DM_ChucVu
                .FirstOrDefault(cv => cv.TenChucVu.Equals(tenChucVu, StringComparison.OrdinalIgnoreCase));

            return chucVu?.MaChucVu; // Trả về mã chức vụ hoặc null nếu không tìm thấy
        }

        public void Update_DMLuong()
        {
            try
            {
                var dsNhanVien = Adapter.NhanVien.ToList();
                var dsDMLuong = Adapter.DM_Luong.ToList();

                // Step 1: Remove records from DM_Luong if corresponding employee record doesn't exist
                foreach (var luong in dsDMLuong)
                {
                    var nhanVienRecord = dsNhanVien.FirstOrDefault(n => n.MaNhanVien == luong.MaNhanVien);
                    if (nhanVienRecord == null)
                    {
                        Adapter.DM_Luong.Remove(luong);
                    }
                }
                Adapter.SaveChanges();

                // Step 2: Add new records in DM_Luong for employees without existing records
                foreach (var nhanvien in dsNhanVien)
                {
                    var luongRecord = dsDMLuong.FirstOrDefault(l => l.MaNhanVien == nhanvien.MaNhanVien);

                    if (luongRecord == null)
                    {
                        // Create a new DM_Luong record if it doesn't exist for this employee
                        DM_Luong dmLuongMoi = new DM_Luong
                        {
                            MaNhanVien = nhanvien.MaNhanVien,
                            LuongCoBan = null,
                            PhuCap = null,
                            KhauTruThue = null
                        };
                        Adapter.DM_Luong.Add(dmLuongMoi);
                    }
                }

                // Save changes after adding any new records
                Adapter.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }



        public bool UpdateNhanVien(NhanVien nhanVienSua)
        {
            try
            {
                // Kiểm tra xem đối tượng nhân viên cần cập nhật có tồn tại hay không
                var nhanVien = Adapter.NhanVien.FirstOrDefault(x => x.MaNhanVien == nhanVienSua.MaNhanVien);
                if (nhanVien == null)
                {
                    throw new Exception($"Nhân viên với mã {nhanVienSua.MaNhanVien} không tồn tại.");
                }

                // Cập nhật các trường cần thiết nếu có dữ liệu
                if (!string.IsNullOrEmpty(nhanVienSua.TenNhanVien))
                    nhanVien.TenNhanVien = nhanVienSua.TenNhanVien;
                if (nhanVienSua.NgaySinh.HasValue)
                    nhanVien.NgaySinh = nhanVienSua.NgaySinh;
                if (!string.IsNullOrEmpty(nhanVienSua.DiaChi))
                    nhanVien.DiaChi = nhanVienSua.DiaChi;
                if (!string.IsNullOrEmpty(nhanVienSua.SoDienThoai))
                    nhanVien.SoDienThoai = nhanVienSua.SoDienThoai;
                if (!string.IsNullOrEmpty(nhanVienSua.MaPhongBan))
                    nhanVien.MaPhongBan = nhanVienSua.MaPhongBan;
                if (!string.IsNullOrEmpty(nhanVienSua.MaChucVu))
                    nhanVien.MaChucVu = nhanVienSua.MaChucVu;

                // Lưu các thay đổi vào CSDL
                Adapter.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }


        public bool ChoThoiViec(NhanVien nhanVien)
        {
            try
            {
                string maNV = nhanVien.MaNhanVien;
                NhanVien Row = Adapter.NhanVien.FirstOrDefault(x => x.MaNhanVien == maNV);
                Row.TinhTrangLamViec = false;

                Adapter.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Lỗi: " + ex.Message);

            }
        }

        public bool LamViecLai(NhanVien nhanVien)
        {
            try
            {
                string maNV = nhanVien.MaNhanVien;
                NhanVien Row = Adapter.NhanVien.FirstOrDefault(x => x.MaNhanVien == maNV);
                Row.TinhTrangLamViec = true;

                Adapter.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Lỗi: " + ex.Message);

            }
        }


        public bool AddNhanVien(NhanVien nhanVienMoi)
        {
            try
            {
                if (nhanVienMoi == null)
                {
                    throw new ArgumentNullException(nameof(nhanVienMoi), "Nhân viên mới không được null");
                }

                // Kiểm tra mã nhân viên đã tồn tại chưa
                var existingNhanVien = Adapter.NhanVien.FirstOrDefault(x => x.MaNhanVien == nhanVienMoi.MaNhanVien);
                if (existingNhanVien != null)
                {
                    throw new Exception($"Mã nhân viên {nhanVienMoi.MaNhanVien} đã tồn tại.");
                }

                // Thêm nhân viên vào bảng NhanVien
                Adapter.NhanVien.Add(nhanVienMoi);
                Adapter.SaveChanges(); // Lưu thay đổi vào CSDL

                // Thêm bản ghi mới vào bảng DM_Luong với MaNhanVien vừa thêm
                DM_Luong dmLuongMoi = new DM_Luong
                {
                    MaNhanVien = nhanVienMoi.MaNhanVien,
                    LuongCoBan = null,
                    PhuCap = null,
                    KhauTruThue = null
                };

                Adapter.DM_Luong.Add(dmLuongMoi);
                Adapter.SaveChanges(); // Lưu thay đổi vào CSDL cho DM_Luong

                return true; // Thêm thành công cả hai bảng
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm nhân viên mới", ex);
            }
        }

        public bool DeleteNhanVien(string maNV)
        {
            try
            {
                // Tìm nhân viên theo mã
                var nhanVien = Adapter.NhanVien.FirstOrDefault(x => x.MaNhanVien == maNV);
                if (nhanVien == null)
                {
                    throw new Exception($"Không tìm thấy nhân viên với mã: {maNV}");
                }

                // Xóa tất cả thông tin liên quan của nhân viên trong các bảng khác
                // Xóa QT_CongTac
                var qtcCongTacRecords = Adapter.QT_CongTac.Where(x => x.MaNhanVien == maNV).ToList();
                if (qtcCongTacRecords.Any())
                {
                    Adapter.QT_CongTac.RemoveRange(qtcCongTacRecords);
                }

                // Xóa DM_Luong
                var dmLuong = Adapter.DM_Luong.FirstOrDefault(x => x.MaNhanVien == maNV);
                if (dmLuong != null)
                {
                    Adapter.DM_Luong.Remove(dmLuong);
                }

                // Xóa NgayNghi
                var ngayNghiRecords = Adapter.NgayNghi.Where(x => x.MaNhanVien == maNV).ToList();
                if (ngayNghiRecords.Any())
                {
                    Adapter.NgayNghi.RemoveRange(ngayNghiRecords);
                }

                // Xóa Luong
                var luongRecords = Adapter.Luong.Where(x => x.MaNhanVien == maNV).ToList();
                if (luongRecords.Any())
                {
                    Adapter.Luong.RemoveRange(luongRecords);
                }

                // Xóa thông tin trong bảng NhanVien
                Adapter.NhanVien.Remove(nhanVien);

                // Lưu thay đổi vào CSDL
                Adapter.SaveChanges();

                return true; // Xóa thành công
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa nhân viên với mã: {maNV}", ex);
            }
        }



        // Giải phóng tài nguyên
        public void Dispose()
        {
            Adapter.Dispose();
        }
    }
}
