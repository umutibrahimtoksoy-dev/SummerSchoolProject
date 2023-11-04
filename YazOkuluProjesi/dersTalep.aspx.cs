using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class dersTalep : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {       
            //List<string> dersler = new List<string>();
            //List<EntityDersler> lessons = new List<EntityDersler>();
            //lessons = DalOgrenci.dersListele();
            //foreach (var item in lessons)
            //{
            //    dersler.Add(item.DersAd);
            //}
            //DropDownList1.DataSource =dersler;
            //DropDownList1.DataBind();          
            DropDownList1.DataSource = BllOgrenci.dersListele();
            DropDownList1.DataTextField = "DersAd";
            DropDownList1.DataValueField = "DersId";
            DropDownList1.DataBind();
            DropDownList2.DataSource = BllOgrenci.ogrenciListele();
            DropDownList2.DataTextField = "OgrAd";
            DropDownList2.DataValueField = "OgrId";
            DropDownList2.DataBind();

        }     

    }
    protected void kaydet_Click(object sender, EventArgs e)
    {
        EntityBasvurular nesne = new EntityBasvurular();
        nesne.DersId = Convert.ToInt32(DropDownList1.SelectedValue);
        nesne.OgrId = Convert.ToInt32(DropDownList2.SelectedValue);
        BllOgrenci.dersTalep(nesne);
    }
}