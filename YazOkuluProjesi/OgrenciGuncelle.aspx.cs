using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using EntityLayer;

public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            string id = Request.QueryString["OgrId"];
            Txtid.Text = id;
            Txtid.Enabled = false;
            EntityOgrenci obj = new EntityOgrenci();
            obj = BllOgrenci.ogrenciDetay(Convert.ToInt32(id));
            TxtAd.Text = obj.OgrAd;
            TxtSoyad.Text = obj.OgrSoyad;
            TxtNumara.Text = obj.OgrNumara;
            TxtFotograf.Text = obj.OgrFotograf;
            TxtSifre.Text = obj.OgrSifre;
        }
      

    }

    protected void guncelle_Click(object sender, EventArgs e)
    {
        EntityOgrenci obj = new EntityOgrenci();
        obj.OgrId = Convert.ToInt32(Txtid.Text);
        obj.OgrAd = TxtAd.Text;
        obj.OgrSoyad = TxtSoyad.Text;
        obj.OgrNumara = TxtNumara.Text;
        obj.OgrFotograf = TxtFotograf.Text;
        obj.OgrSifre = TxtSifre.Text;
        BllOgrenci.ogrenciGuncelle(obj);
        Response.Redirect("OgrenciListeleme.aspx");
    }
}