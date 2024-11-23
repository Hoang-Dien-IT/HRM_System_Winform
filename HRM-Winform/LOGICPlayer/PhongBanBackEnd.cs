using DATAPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICPlayer
{
    public class PhongBanBackEnd
    {
        readonly HRMEntities Adapter = new HRMEntities();
        public List<PhongBan> LoadDataTable() => Adapter.PhongBan.AsNoTracking().ToList();

        public List<PhongBan> Load_DataTimKiem() => Adapter.PhongBan.AsNoTracking().ToList();

        public void Add(PhongBan ThemPhongBan)
        {
            try
            {
                Adapter.PhongBan.Add(ThemPhongBan);
                Adapter.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);

            }

        }
        public void Update(PhongBan UpdatePhongBan)
        {
            try
            {
                String String_MaPhongBan = UpdatePhongBan.MaPhongBan;
                PhongBan Row = Adapter.PhongBan.FirstOrDefault(x => x.MaPhongBan == String_MaPhongBan);
                Row.TenPhongBan = UpdatePhongBan.TenPhongBan;
                Row.VanPhong = UpdatePhongBan.VanPhong;

                Adapter.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);

            }
        }
        public void Remove(PhongBan RemovePhongBan)
        {
            try
            {
                PhongBan Row = Adapter.PhongBan.FirstOrDefault(x => x.MaPhongBan == RemovePhongBan.MaPhongBan);

                Adapter.PhongBan.Remove(Row);

                Adapter.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);

            }
        }

    }
}

        
