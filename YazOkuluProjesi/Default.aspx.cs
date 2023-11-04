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
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci islem = new EntityOgrenci();
        islem.OgrAd = TxtAd.Text;
        islem.OgrSoyad = TxtSoyad.Text;
        islem.OgrNumara = TxtNumara.Text;
        islem.OgrFotograf = TxtFotograf.Text;
        islem.OgrSifre = TxtSifre.Text;
        BllOgrenci.ogrenciEkle(islem);
    }

    protected void TxtNumara_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TxtFotograf_TextChanged(object sender, EventArgs e)
    {

    }
}