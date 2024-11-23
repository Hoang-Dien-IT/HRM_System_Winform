using DATAPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICPlayer
{
    public class InBackend
    {
        public int TinhTongLuongThucLanh(string thangNam)
        {
            using (var context = new HRMEntities())
            {
                return context.Luong
                              .Where(l => l.ThangNam == thangNam)
                              .Sum(l => (int?)l.LuongThucLanh) ?? 0;
            }
        }
    }
}
