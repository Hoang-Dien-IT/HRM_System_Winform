using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATAPlayer;
using LOGICPlayer;

namespace LOGICPlayer
{
    public class BackendDMLuong
    {
        readonly HRMEntities Adapter = new HRMEntities();

        Logic_TaiKhoan Logic_TaiKhoan = new Logic_TaiKhoan();
        public string connectionString = Logic_TaiKhoan.LinkConnectData();
        public List<object> LoadDataTable()
        {
            return Adapter.DM_Luong
                .AsNoTracking()
                .Join(
                    Adapter.NhanVien.Where(nv => nv.TinhTrangLamViec == true),  // Chỉ lấy nhân viên đang làm việc
                    dmLuong => dmLuong.MaNhanVien,  // Khóa ngoại ở DM_Luong
                    nv => nv.MaNhanVien,  // Khóa chính ở NhanVien
                    (dmLuong, nv) => new  // Kết quả sau khi join
                    {
                        MaNhanVien = dmLuong.MaNhanVien,
                        TenNhanVien = nv.TenNhanVien,
                        LuongCoBan = dmLuong.LuongCoBan,
                        PhuCap = dmLuong.PhuCap,
                        KhauTruThue = dmLuong.KhauTruThue
                    })
                .ToList<object>();
        }



        // Thêm lương cho nhân viên mới với các hệ số là null
        public bool ThemLuongMoi(string maNhanVien)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO DM_Luong (MaNhanVien, LuongCoBan, PhuCap, KhauTruThue) VALUES (@MaNhanVien, NULL, NULL, NULL)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        // Sửa lương của nhân viên
        public bool SuaLuong(string maNhanVien, decimal? luongCoBan, decimal? phuCap, decimal? khauTruThue)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE DM_Luong SET LuongCoBan = @LuongCoBan, PhuCap = @PhuCap, KhauTruThue = @KhauTruThue WHERE MaNhanVien = @MaNhanVien";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    cmd.Parameters.AddWithValue("@LuongCoBan", (object)luongCoBan ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@PhuCap", (object)phuCap ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@KhauTruThue", (object)khauTruThue ?? DBNull.Value);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        // Xóa lương của nhân viên
        public bool XoaLuong(string maNhanVien)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM DM_Luong WHERE MaNhanVien = @MaNhanVien";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
