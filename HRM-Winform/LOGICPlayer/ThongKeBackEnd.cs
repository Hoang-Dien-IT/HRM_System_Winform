using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATAPlayer;

namespace LOGICPlayer
{
    public class ThongKeBackEnd
    {
        readonly HRMEntities Adapter = new HRMEntities();
        public long TongLuongNhanVien_ddMMyyy(string NgayBatDau, string NgayKetThuc)
        {
            try
            {
                using (var context = new HRMEntities())
                {
                    // Chuyển NgayBatDau và NgayKetThuc thành định dạng YYYYMM để so sánh
                    int ngayBatDauInt = int.Parse(NgayBatDau.Substring(6, 4)) * 100 + int.Parse(NgayBatDau.Substring(3, 2));
                    int ngayKetThucInt = int.Parse(NgayKetThuc.Substring(6, 4)) * 100 + int.Parse(NgayKetThuc.Substring(3, 2));

                    long totalSalary = context.Luong
                        .AsEnumerable()
                        .Where(l =>
                            (int.Parse(l.ThangNam.Substring(3, 4)) * 100 + int.Parse(l.ThangNam.Substring(0, 2))) >= ngayBatDauInt &&
                            (int.Parse(l.ThangNam.Substring(3, 4)) * 100 + int.Parse(l.ThangNam.Substring(0, 2))) <= ngayKetThucInt)
                        .Sum(l => (long)l.LuongThucLanh);
                    return totalSalary; // Trả về 0 nếu totalSalary là null
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi1: " + ex.Message);
            }
        }

        //input: mm/yyyy
        public int TinhSoThang(string NgayBatDau, string NgayKetThuc)
        {
            try
            {
                // Chuyển NgayBatDau và NgayKetThuc thành định dạng YYYYMM để so sánh
                int ngayBatDauInt = int.Parse(NgayBatDau.Substring(6, 4)) * 100 + int.Parse(NgayBatDau.Substring(3, 2));
                int ngayKetThucInt = int.Parse(NgayKetThuc.Substring(6, 4)) * 100 + int.Parse(NgayKetThuc.Substring(3, 2));

                return ngayKetThucInt - ngayBatDauInt + 1;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi2: " + ex.Message);
            }
        }

        public int LuongCaoNhatTrongThang(string thangNam)
        {
            //Console.WriteLine($"thangNam3: {thangNam}");
            try
            {
                using (var context = new HRMEntities())
                {
                    // Find the minimum salary for the specified month and year
                    var maxSalary = context.Luong
                        .AsEnumerable()
                        .Where(l => l.ThangNam == thangNam)
                        .Max(l => l.LuongThucLanh);

                    // Return the minimum salary or 0 if no salary is found
                    return maxSalary ?? 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi3: " + ex.Message);
            }
        }

        public int LuongThapNhatTrongThang(string thangNam)
        {
            try
            {
                using (var context = new HRMEntities())
                {
                    // Find the minimum salary for the specified month and year
                    var minSalary = context.Luong
                        .AsEnumerable()
                        .Where(l => l.ThangNam == thangNam)
                        .Min(l => l.LuongThucLanh);

                    // Return the minimum salary or 0 if no salary is found
                    return minSalary ?? 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi4: " + ex.Message);
            }
        }

        public long TrungBinhLuongNVMotThang(string thangNam)
        {
            try
            {
                using (var context = new HRMEntities())
                {
                    //Console.Write($"thangNam: {thangNam}");

                    // Đếm số lượng nhân viên có lương trong tháng-năm cụ thể
                    int employeeCount = context.Luong
                        .AsEnumerable()
                        .Where(l => l.ThangNam == thangNam)
                        .Select(l => l.MaNhanVien)
                        .Distinct()
                        .Count();
                    long tongLuong = TongLuongNhanVien_MMyyy(thangNam, thangNam);

                    // k có nv thì lương tb=0
                    if (employeeCount == 0) return 0;
                    else return tongLuong / employeeCount;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi5: " + ex.Message);
            }
        }

        public long TongLuongNhanVien_MMyyy(string NgayBatDau, string NgayKetThuc)
        {
            try
            {
                using (var context = new HRMEntities())
                {
                    // Hiển thị giá trị để kiểm tra
                    //Console.WriteLine($"NgayBatDau: {NgayBatDau}, NgayKetThuc: {NgayKetThuc}");

                    // Chuyển NgayBatDau và NgayKetThuc thành định dạng YYYYMM để so sánh
                    int ngayBatDauInt = int.Parse(NgayBatDau.Substring(3, 4)) * 100 + int.Parse(NgayBatDau.Substring(0, 2));
                    int ngayKetThucInt = int.Parse(NgayKetThuc.Substring(3, 4)) * 100 + int.Parse(NgayKetThuc.Substring(0, 2));

                    // Hiển thị giá trị để kiểm tra

                    //Console.WriteLine($"NgayBatDauInt: {ngayBatDauInt}, NgayKetThucInt: {ngayKetThucInt}");
                    long totalSalary = context.Luong
                        .AsEnumerable()
                        .Where(l =>
                            (int.Parse(l.ThangNam.Substring(3, 4)) * 100 + int.Parse(l.ThangNam.Substring(0, 2))) >= ngayBatDauInt &&
                            (int.Parse(l.ThangNam.Substring(3, 4)) * 100 + int.Parse(l.ThangNam.Substring(0, 2))) <= ngayKetThucInt)
                        .Sum(l => (long)l.LuongThucLanh);

                    return totalSalary; // Trả về 0 nếu totalSalary là null
                }
            }
            catch (Exception ex)
            {
                return 0;
                throw new Exception("Lỗi6: " + ex.Message);
            }
        }

        public int LayLuongThucLanh(string thangNam)
        {
            try
            {
                // Print thangNam to console
                //Console.WriteLine($"thangNam7: {thangNam}");

                using (var context = new HRMEntities())
                {
                    // Chuyển đổi chuỗi 'mm/yyyy' thành định dạng số nguyên 'yyyymm'
                    int thangNamInt = int.Parse(thangNam.Substring(3, 4)) * 100 + int.Parse(thangNam.Substring(0, 2));

                    // Truy vấn lương thực lãnh cho tháng-năm cụ thể
                    var totalLuongThucLanh = context.Luong
                        .AsEnumerable()
                        .Where(l => int.Parse(l.ThangNam.Substring(3, 4)) * 100 + int.Parse(l.ThangNam.Substring(0, 2)) == thangNamInt)
                        .Sum(l => l.LuongThucLanh);

                    return totalLuongThucLanh ?? 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
                throw new Exception("Lỗi7: " + ex.Message);
            }
        }
    }
}
