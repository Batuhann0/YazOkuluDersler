using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class Dersler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            DropDownList1.DataSource = BLLDers.BLLListele();
            DropDownList1.DataTextField = "DERSAD"; //veritabanında bize gözükücek olan alan
            DropDownList1.DataValueField = "DERSID"; //Arkaplanda tutalacak olan değer
            DropDownList1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityBasvurular ent = new EntityBasvurular();
        //değer ataması yaptık
        ent.OGRENCİID = int.Parse(txtogrenciıd.Text);
        ent.DERSID = int.Parse(DropDownList1.SelectedValue);

        //metodu çağırdık(ent den gelen değerleri ekle)
        BLLDers.TalepEkleBll(ent);

    }
}