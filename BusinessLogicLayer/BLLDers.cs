using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDersler> BLLListele()
        {
            return DALDers.DersListesi();
        }


        public static int TalepEkleBll(EntityBasvurular p)
        {
            if (p.BASVURUID != null && p.DERSID != null)
            {
                return DALDers.TalepEkle(p);
            }
            return -1;
        }
    }
}
