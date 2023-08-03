using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;

public partial class OgrenciSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int ıd = int.Parse(Request.QueryString["OGRID"]);

        EntityOgrenci ent = new EntityOgrenci();
        ent.OGRENCİId = ıd;

        BLLOgrenci.OgrenciSilBLL(ent.OGRENCİId); //ıd ye göre silme işlemi yap
        Response.Redirect("OgrenciListesi.aspx"); //bu sayfaya tekrar yönlendirmek için
        //!! ilişkli alanı silmeye çalışırsan hata verir
    }
}