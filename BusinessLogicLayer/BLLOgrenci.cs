using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer; //referanslarımızı ekledik
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        //İŞ MANTIK KATMANI

        #region ÖĞRENCİ EKLE METODU
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad != null && p.Numara != null && p.SIFRE != null && p.Fotograf != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1; //boş
        }
        #endregion

        #region ÖĞRENCİ LİSTELE METODU
        public static List<EntityOgrenci> BLLlistele()
        {
            return DALOgrenci.OgrenciListesi();
        }
        #endregion

        #region ÖĞRENCİ SİLME METODU
        public static bool OgrenciSilBLL(int p)
        {
            if (p != null) 
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false; 
        }
        #endregion

        #region ÖĞRENCİ listeleme ıd ye göre
        public static List<EntityOgrenci> BLLDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }
        #endregion

        #region OGRENCİ GÜNCELLEME
        public static bool OgrenciGuncelleBll(EntityOgrenci p)
        {
            if (p.OGRENCİId > 0 && p.Ad != null && p.Soyad != null && p.Numara != null && p.SIFRE != null && p.Fotograf != null) 
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false; //boş
        }
        #endregion
    }
}
