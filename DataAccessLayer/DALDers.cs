using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALDers //bu katmanda değer atamalını yapıyoruz
    {
        #region DERSLER LİSTELEME
        public static List<EntityDersler> DersListesi()
        {
            List<EntityDersler> degerler = new List<EntityDersler>();

            SqlCommand komut = new SqlCommand("select * from Tbl_Ders", Baglanti.sql);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDersler entdersler = new EntityDersler();
                entdersler.DERSID = int.Parse(dr["DERSID"].ToString());
                entdersler.DERSAD = dr["DERSAD"].ToString();
                entdersler.MAKSKONT = int.Parse(dr["DERSMAKSKONT"].ToString());
                entdersler.MINKONT = int.Parse(dr["DERSMINKONT"].ToString());

                degerler.Add(entdersler);
            }
            dr.Close();
            return degerler;
        }
        #endregion


        #region Talep EKLEME
        public static int TalepEkle(EntityBasvurular p)
        {
            SqlCommand komutekle = new SqlCommand("insert into Tbl_Basvurular(OGRENCID,DERSID) values(@p1,@p2)", Baglanti.sql);
            komutekle.Parameters.AddWithValue("@p1", p.OGRENCİID);
            komutekle.Parameters.AddWithValue("@p2", p.DERSID);

            if (komutekle.Connection.State != ConnectionState.Open)
            {
                komutekle.Connection.Open();
            }

            return komutekle.ExecuteNonQuery();
        }
        #endregion

    }
}
