using DATAPlayer;
using LOGICPlayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICPlayer
{
    public class CongTacBackEnd
    {
        Logic_TaiKhoan Logic_TaiKhoan = new Logic_TaiKhoan();
        public string connectionString = Logic_TaiKhoan.LinkConnectData();
        readonly HRMEntities Adapter = new HRMEntities();
        public List<QT_CongTac> LoadDataTable() => Adapter.QT_CongTac.AsNoTracking().ToList();



        public string TaoMaCongTacMoi()
        {
            Random random = new Random();
            string maCT;
            bool isDuplicate;

            do
            {
                // Tạo 2 chữ cái in hoa bất kỳ
                string letters = $"{(char)random.Next('A', 'Z' + 1)}{(char)random.Next('A', 'Z' + 1)}";

                // Tạo 2 chữ số bất kỳ
                string numbers = random.Next(0, 100).ToString("D2");

                // Tạo mã công tác mới
                maCT = $"{letters}{numbers}";

                // Kiểm tra xem mã đã tồn tại trong cơ sở dữ liệu hay chưa
                isDuplicate = Adapter.QT_CongTac.Any(nv => nv.MaCT == maCT);

            } while (isDuplicate);  // Nếu mã trùng, tiếp tục tạo mã mới

            return maCT;
        }
        public bool UpdateCongTac(QT_CongTac congTacSua)
        {
            string query = "UPDATE QT_CongTac SET ";
            List<string> updateFields = new List<string>();
            if (congTacSua.BatDau.HasValue)
                updateFields.Add("BatDau = @BatDau");
            if (congTacSua.KetThuc.HasValue)
                updateFields.Add("KetThuc = @KetThuc");
            if (!string.IsNullOrEmpty(congTacSua.GhiChu))
                updateFields.Add("GhiChu = @GhiChu");

            if (updateFields.Count == 0)
                return false;  // Không có gì để cập nhật

            query += string.Join(", ", updateFields) + " WHERE MaCT = @MaCT AND MaNhanVien = @MaNhanVien";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaCT", congTacSua.MaCT);
                        cmd.Parameters.AddWithValue("@MaNhanVien", congTacSua.MaNhanVien);
                        if (congTacSua.BatDau.HasValue)
                            cmd.Parameters.AddWithValue("@BatDau", congTacSua.BatDau.Value);
                        if (congTacSua.KetThuc.HasValue)
                            cmd.Parameters.AddWithValue("@KetThuc", congTacSua.KetThuc.Value);
                        if (!string.IsNullOrEmpty(congTacSua.GhiChu))
                            cmd.Parameters.AddWithValue("@GhiChu", congTacSua.GhiChu);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool AddCongTac(QT_CongTac CongTacMoi)
        {
            try
            {
                if (CongTacMoi == null)
                {
                    throw new ArgumentNullException(nameof(CongTacMoi), "Công tác mới không được null");
                }

                // Chuyển MaCT sang chữ viết hoa
                CongTacMoi.MaCT = CongTacMoi.MaCT.ToUpper();

                // Kiểm tra khóa chính (MaCT, MaNhanVien) tồn tại chưa
                var existingCongTac = Adapter.QT_CongTac
                    .FirstOrDefault(x => x.MaCT == CongTacMoi.MaCT && x.MaNhanVien == CongTacMoi.MaNhanVien);

                if (existingCongTac != null)
                {
                    throw new Exception($"Công tác {CongTacMoi.MaCT} của nhân viên {CongTacMoi.MaNhanVien} đã tồn tại.");
                }

                Adapter.QT_CongTac.Add(CongTacMoi);
                Adapter.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                return true; // Thêm thành công
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm công tác mới", ex);
            }
        }


        public bool DeleteCongTac(string maCT, string maNhanVien)
        {
            try
            {
                // Tìm công tác dựa trên khóa chính (MaCT, MaNhanVien)
                var qtcCongTacRecord = Adapter.QT_CongTac.FirstOrDefault(x => x.MaCT == maCT && x.MaNhanVien == maNhanVien);

                if (qtcCongTacRecord == null)
                {
                    throw new Exception($"Không tìm thấy công tác với Mã công tác {maCT} và Mã nhân viên {maNhanVien}");
                }

                Adapter.QT_CongTac.Remove(qtcCongTacRecord);

                // Lưu thay đổi vào csdl
                Adapter.SaveChanges();
                return true; 
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa công tác với Mã công tác {maCT} và Mã nhân viên {maNhanVien}", ex);
            }
        }


        // Giải phóng tài nguyên
        public void Dispose()
        {
            Adapter.Dispose();
        }
    }
}
