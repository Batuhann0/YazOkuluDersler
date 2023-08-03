using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer; //bunu yazabilmek için önce references dan entitylayeri referans verdik

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        #region EKLEME İŞLEMİ
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tbl_Ogrenci(OGRAD,OGRSOYAD,OGRNUMARA,OGRFOTO,OGRSIFRE)" +
                "values(@p1,@p2,@p3,@p4,@p5)", Baglanti.sql);

            if (komut1.Connection.State != ConnectionState.Open) //baglantı kapalıysa
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.Ad);
            komut1.Parameters.AddWithValue("@p2", parametre.Soyad);
            komut1.Parameters.AddWithValue("@p3", parametre.Numara);
            komut1.Parameters.AddWithValue("@p4", parametre.Fotograf);
            komut1.Parameters.AddWithValue("@p5", parametre.SIFRE);

            return komut1.ExecuteNonQuery(); //etkilenen kayıt sayısını geriye döndür
        }
        #endregion

        
        #region LİSTELEME İŞLEMİ
        public static List<EntityOgrenci> OgrenciListesi() // entityogrenci türünde OgrenciListesi adında metot
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("select * from Tbl_Ogrenci", Baglanti.sql);

            if (komut2.Connection.State != ConnectionState.Open) //baglantı kapalıysa
            {
                komut2.Connection.Open();
            }

            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.OGRENCİId = int.Parse(dr["OGRID"].ToString());
                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Numara = dr["OGRNUMARA"].ToString();
                ent.Fotograf = dr["OGRFOTO"].ToString();
                ent.SIFRE = dr["OGRSIFRE"].ToString();
                ent.Bakiye = double.Parse(dr["OGRBAKIYE"].ToString());

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        #endregion


        #region OGRENCİ SİLME İŞLEMİ
        public static bool OgrenciSil(int parametre) //bool veritipinde metot(çünkü ya sildi yada silmedi 0 1)
        {
            SqlCommand komutsil = new SqlCommand("delete from Tbl_Ogrenci where OGRID=@p1", Baglanti.sql);
            if (komutsil.Connection.State != ConnectionState.Open) //baglantı kapalıysa
            {
                komutsil.Connection.Open();
            }

            komutsil.Parameters.AddWithValue("@p1", parametre);
            return komutsil.ExecuteNonQuery() > 0; //yani sildiyse(1) değeri döndürcek
        }
        #endregion


        #region OGRENCİ listeleme ıd ye göre
        public static List<EntityOgrenci> OgrenciDetay(int ıd) 
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("select * from Tbl_Ogrenci where OGRID=@p1", Baglanti.sql);

            komut2.Parameters.AddWithValue("@p1", ıd);

            if (komut2.Connection.State != ConnectionState.Open) //baglantı kapalıysa
            {
                komut2.Connection.Open();
            }

            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Numara = dr["OGRNUMARA"].ToString();
                ent.Fotograf = dr["OGRFOTO"].ToString();
                ent.SIFRE = dr["OGRSIFRE"].ToString();
                ent.Bakiye = double.Parse(dr["OGRBAKIYE"].ToString());

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        #endregion

        #region OGRENCİ GÜNCELLEME
        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komutgüncelle = new SqlCommand("update Tbl_Ogrenci set OGRAD=@P1,OGRSOYAD=@P2,OGRNUMARA=@P3,OGRFOTO=@P4,OGRSIFRE=@P5 WHERE OGRID=@P6", Baglanti.sql);
            if (komutgüncelle.Connection.State != ConnectionState.Open) 
            {
                komutgüncelle.Connection.Open();
            }

            komutgüncelle.Parameters.AddWithValue("@P1", deger.Ad);
            komutgüncelle.Parameters.AddWithValue("@P2", deger.Soyad);
            komutgüncelle.Parameters.AddWithValue("@P3", deger.Numara);
            komutgüncelle.Parameters.AddWithValue("@P4", deger.Fotograf);
            komutgüncelle.Parameters.AddWithValue("@P5", deger.SIFRE);
            komutgüncelle.Parameters.AddWithValue("@P6", deger.OGRENCİId);

            return komutgüncelle.ExecuteNonQuery() > 0;
        }
        #endregion

    }
}
