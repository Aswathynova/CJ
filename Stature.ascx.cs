﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Stature : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lbtnCodeInformatics_Click(object sender, EventArgs e)
    {
        Session["SubCtrl"] = "CodeInformatics.ascx";
        Response.Redirect("FJAHome.aspx");
    }
}
