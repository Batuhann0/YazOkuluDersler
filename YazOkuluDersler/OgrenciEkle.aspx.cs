using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class _Default : System.Web.UI.Page
{

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.Ad = TxtAd.Text;
        ent.Soyad = txtsoyad.Text;
        ent.Numara = txtnumara.Text;
        ent.SIFRE = txtsifre.Text;
        ent.Fotograf = FileUploadfoto.FileName;

        BLLOgrenci.OgrenciEkleBLL(ent);

        TxtAd.Text = null;
        txtsoyad.Text = null;
        txtnumara.Text = null;
        txtsifre.Text = null;
        FileUploadfoto.Dispose();
    }
}