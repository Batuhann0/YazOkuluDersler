using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        int Id = int.Parse(Request.QueryString["OGRID"]); //ogrencinin ıd sini 

        TxtId.Text = Id.ToString();
        TxtId.Enabled = false;

        if (Page.IsPostBack == false)
        {
            List<EntityOgrenci> ogrList = BLLOgrenci.BLLDetay(Id);
            TxtAd.Text = ogrList[0].Ad.ToString();
            txtsoyad.Text = ogrList[0].Soyad.ToString();
            txtnumara.Text = ogrList[0].Numara.ToString();
            txtsifre.Text = ogrList[0].SIFRE.ToString();
        }

    }

    //GÜNCELLEME
    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ogr = new EntityOgrenci();
        ogr.OGRENCİId = int.Parse(TxtId.Text);
        ogr.Ad = TxtAd.Text;
        ogr.Soyad = txtsoyad.Text;
        ogr.Numara = txtnumara.Text;
        ogr.SIFRE = txtsifre.Text;
        ogr.Fotograf = FileUploadfoto.FileName;

        BLLOgrenci.OgrenciGuncelleBll(ogr);
        Response.Redirect("OgrenciListesi.aspx");
    }
}