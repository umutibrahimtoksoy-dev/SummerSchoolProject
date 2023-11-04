using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;

public partial class OgrenciSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["OgrId"]);
        EntityOgrenci obj = new EntityOgrenci();
        obj.OgrId = id;
        BllOgrenci.ogrenciSil(obj.OgrId);
        Response.Redirect("OgrenciListeleme.aspx");
    }
}