using DATAPlayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace LOGICPlayer
{
    public class Logic_TaiKhoan
    {
        
        public static string LinkConnectData()
        {  //Chọn một cái đi
            // string str = "Data Source=MICHAEL\\SQLEXPRESS;Initial Catalog=HRM;Integrated Security=True";

            string str = "Data Source=LAPTOP-881KRHJ2\\SQLEXPRESS;Initial Catalog=HRM;Integrated Security=True";

            //string str= "Data Source=localhost;Initial Catalog=HRM;Integrated Security=True";

            return str;
        }

        public string connectionString = LinkConnectData();

        readonly HRMEntities Adapter = new HRMEntities();
        public List<TaiKhoan> LoadDataTable() => Adapter.TaiKhoan.AsNoTracking().ToList();
        public bool CapQuyen(TaiKhoan taiKhoan)
        {
            try
            {
                int stt_TK = taiKhoan.STT_Tk;
                TaiKhoan Row = Adapter.TaiKhoan.FirstOrDefault(x => x.STT_Tk == stt_TK);
                Row.TinhTrang = true;

                Adapter.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Lỗi: " + ex.Message);

            }
        }

        public bool ThuHoi(TaiKhoan taiKhoan)
        {
            try
            {
                int stt_TK = taiKhoan.STT_Tk;
                TaiKhoan Row = Adapter.TaiKhoan.FirstOrDefault(x => x.STT_Tk == stt_TK);
                Row.TinhTrang = false;

                Adapter.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Lỗi: " + ex.Message);

            }
        }

        //public bool Xoa(TaiKhoan taiKhoan)
        //{
        //    try
        //    {
        //        TaiKhoan Row = Adapter.TaiKhoan.FirstOrDefault(x => x.STT_Tk == taiKhoan.STT_Tk);

        //        Adapter.TaiKhoan.Remove(Row);

        //        Adapter.SaveChanges();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //        throw new Exception("Lỗi: " + ex.Message);

        //    }
        //}


        // Transaction xóa tài khoản
        public bool Xoa(TaiKhoan taiKhoan)
        {
            // Sử dụng try-catch để bắt lỗi và rollback nếu có lỗi xảy ra
            using (var transaction = Adapter.Database.BeginTransaction())
            {
                try
                {
                    // Tìm tài khoản trong DbContext
                    TaiKhoan Row = Adapter.TaiKhoan.FirstOrDefault(x => x.STT_Tk == taiKhoan.STT_Tk);

                    // Nếu không tìm thấy tài khoản, trả về false
                    if (Row == null)
                    {
                        return false;
                    }

                    // Xóa tài khoản khỏi DbSet
                    Adapter.TaiKhoan.Remove(Row);

                    // Lưu các thay đổi vào cơ sở dữ liệu
                    Adapter.SaveChanges();

                    // Commit transaction nếu mọi thứ thành công
                    transaction.Commit();

                    return true;
                }
                catch (Exception ex)
                {
                    // Nếu có lỗi, rollback transaction
                    transaction.Rollback();
                    // Thực thi ngoại lệ để thông báo lỗi
                    throw new Exception("Lỗi: " + ex.Message);
                }
            }
        }


        public Object[] KiemTraDangNhap(string username, string password)
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            //Trust Server Certificate = True; Encrypt = True;
            //string connectionString = "Data Source=localhost;Initial Catalog=HRM;Integrated Security=True";
            // Truy vấn SQL kiểm tra tài khoản
            string query = "SELECT COUNT(1) FROM TaiKhoan WHERE TenTaiKhoan = @username AND MatKhau = @password";
            string query_Ktra_Actived = "SELECT TinhTrang FROM TaiKhoan WHERE TenTaiKhoan = @username AND MatKhau = @password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo đối tượng SqlCommand
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlCommand cmd_Ktra_Active = new SqlCommand(query_Ktra_Actived, conn);

                    string hashedPassword = HashPassword(password);

                    //Console.Write($" hash: {hashedPassword}");

                    // Thêm tham số để tránh SQL Injection
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);


                    // Thêm tham số để tránh SQL Injection
                    cmd_Ktra_Active.Parameters.AddWithValue("@username", username);
                    cmd_Ktra_Active.Parameters.AddWithValue("@password", hashedPassword);

                    // Thực thi truy vấn và lấy kết quả
                    int count = (int)cmd.ExecuteScalar();
                    

                    bool KetQua = false;
                    string ThongBao = "";

                    // Nếu count = 1, tức là tài khoản tồn tại
                    if (count == 1)
                    {
                        // Thực hiện kiểm tra NULL trước khi chuyển đổi
                        Object result_TinhTrang = cmd_Ktra_Active.ExecuteScalar();
                        if (result_TinhTrang != null && result_TinhTrang != DBNull.Value)
                        {
                            // Chuyển kiểu dữ liệu BIT (bool)
                            bool TinhTrang = (bool)result_TinhTrang;

                            if (TinhTrang) // TK đã kích hoạt (TinhTrang = 1)
                            {
                                KetQua = true;
                                ThongBao = "";
                            }
                            else // TK chưa kích hoạt (TinhTrang = 0)
                            {
                                KetQua = false;
                                ThongBao = "Tài khoản này chưa được kích hoạt";
                            }
                        }
                    } else // Sai tk mật khẩu
                    {
                        KetQua = false;
                        ThongBao = "Sai tài khoản hoặc mật khẩu";
                    }
                    return new object[] { KetQua, ThongBao};
                }
                catch (Exception ex)
                {
                    // Ném ngoại lệ để xử lý ở lớp UI
                    throw new Exception("Lỗi kết nối: " + ex.Message);
                }
            }
        }

        public bool TrungTaiKhoan(string username)
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            //Trust Server Certificate = True; Encrypt = True;
            //string connectionString = "Data Source = localhost; Initial Catalog = HRM; Integrated Security = True";

            // Truy vấn SQL kiểm tra tài khoản
            string query = "SELECT COUNT(1) FROM TaiKhoan WHERE TenTaiKhoan = @username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo đối tượng SqlCommand
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Thêm tham số để tránh SQL Injection
                    cmd.Parameters.AddWithValue("@username", username);
                    // Thực thi truy vấn và lấy kết quả
                    int count = (int)cmd.ExecuteScalar();

                    // Nếu count = 1, tức là tài khoản tồn tại
                    return count == 1;
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi kết nối: " + ex.Message);
                }
            }
        }
        
        // Procedure
        public bool TrungTaiKhoan1(string username)
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            //Trust Server Certificate = True; Encrypt = True;
            //string connectionString = "Data Source = localhost; Initial Catalog = HRM; Integrated Security = True";


            // Tạo kết nối
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Tạo SqlCommand để gọi stored procedure
                    using (SqlCommand command = new SqlCommand("TrungTaiKhoan", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số
                        command.Parameters.AddWithValue("@TenTaiKhoan", username); // Giả sử bạn có một TextBox để nhập tên tài khoản

                        // Thực thi và nhận kết quả
                        int ketQua = (int)command.ExecuteScalar();

                        // Xử lý kết quả, 
                        if (ketQua == 1) // k có tk trong csdl
                        {
                            return true; // trùng tk
                        } else
                        {
                            return false; // Tên tài khoản k tồn tại trong csdl
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi kết nối: " + ex.Message);
                }
            }
        }

        public bool ThemTaiKhoan(string Username, string Password, string Email, int TinhTrang = 0)
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            //Trust Server Certificate = True; Encrypt = True;
            //string connectionString = "Data Source=localhost;Initial Catalog=HRM;Integrated Security=True";

        // Truy vấn SQL kiểm tra tài khoản
        string query = "INSERT INTO TaiKhoan (STT_Tk, TenTaiKhoan, MatKhau, Email, TinhTrang) VALUES (@count_acc, @Username, @Password, @Email, @TinhTrang)";
        string query_count_acc = "SELECT COUNT(*) FROM TaiKhoan";
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            try
            {
                // Mở kết nối
                conn.Open();

                // Tạo đối tượng SqlCommand
                SqlCommand cmd_count_acc = new SqlCommand(query_count_acc, conn);
                int count_acc = (int)cmd_count_acc.ExecuteScalar();
                count_acc += 1;

                // Mã hóa mật khẩu
                string hashedPassword = HashPassword(Password);

                SqlCommand cmd = new SqlCommand(query, conn);
                // Thêm các tham số vào câu lệnh SQL
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", hashedPassword); // Sử dụng mật khẩu đã mã hóa
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@TinhTrang", TinhTrang);
                cmd.Parameters.AddWithValue("@count_acc", count_acc);
                // Thực thi câu lệnh SQL
                int rowsAffected = cmd.ExecuteNonQuery();

                // Nếu count = 1, thêm tk thành công
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Ném ngoại lệ để xử lý ở lớp UI
                throw new Exception("Lỗi kết nối: " + ex.Message);
            }
        }
    }


        // Có Function đếm số account
        public bool ThemTaiKhoan1(string Username, string Password, string Email, int TinhTrang = 0)
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            //Trust Server Certificate = True; Encrypt = True;
            //string connectionString = "Data Source=localhost;Initial Catalog=HRM;Integrated Security=True";

            // Truy vấn SQL kiểm tra tài khoản
            string query = "INSERT INTO TaiKhoan (STT_Tk, TenTaiKhoan, MatKhau, Email, TinhTrang) VALUES (@count_acc, @Username, @Password, @Email, @TinhTrang)";
            string query_count_acc = "SELECT dbo.LaySoTaiKhoan()";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo đối tượng SqlCommand
                    SqlCommand cmd_count_acc = new SqlCommand(query_count_acc, conn);
                    int count_acc = (int)cmd_count_acc.ExecuteScalar();
                    count_acc = count_acc + 1;


                    string hashedPassword = HashPassword(Password);

                    SqlCommand cmd = new SqlCommand(query, conn);
                    // Thêm các tham số vào câu lệnh SQL
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword); // Bạn nên mã hóa mật khẩu trước khi lưu vào DB
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@TinhTrang", TinhTrang);
                    cmd.Parameters.AddWithValue("@count_acc", count_acc);

                    // Thực thi câu lệnh SQL
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Nếu count = 1, thêm tk thành công
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Ném ngoại lệ để xử lý ở lớp UI
                    throw new Exception("Lỗi kết nối: " + ex.Message);
                }
            }
        }

        // Hàm băm mật khẩu: sha256Hash
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert the byte array to a string.
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }

    

}
