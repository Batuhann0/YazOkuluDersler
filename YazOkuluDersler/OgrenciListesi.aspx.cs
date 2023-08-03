using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class OgrenciListesi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntityOgrenci> Ogrlist = BLLOgrenci.BLLlistele();
        Repeater1.DataSource = Ogrlist; //repeaterin veri kaynağı olarak ogrlisti ver
        Repeater1.DataBind();

    }
}