using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICPlayer
{
    public static class ThongBao
    {
        public static event Action Load_TableThoiViec;

        public static void CapNhatBang_ChoThoiViec()
        {
            Load_TableThoiViec?.Invoke();
        }

        public static event Action Load_TableLamViec;

        public static void CapNhatBang_LamViecLai()
        {
            Load_TableLamViec?.Invoke();
        }
        public static event Action Load_DM_Luong;

        public static void CapNhatBang_DMLuong()
        {
            Load_DM_Luong?.Invoke();
        }
        public static event Action Load_TableLuong;

        public static void CapNhatBang_Luong()
        {
            Load_TableLuong?.Invoke();
        }
        public static event Action Load_TableDM_ChucVu;

        public static void CapNhatBang_DMChucVu()
        {
            Load_TableDM_ChucVu?.Invoke();
        }
        public static event Action Load_TableNhanVien;

        public static void CapNhatBang_NhanVien()
        {
            Load_TableNhanVien?.Invoke();
        }

    }
}
