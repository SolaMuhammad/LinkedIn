﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkedIn.Controllers
{
    public partial class Experience : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var x = this.ComName =;
        }


        protected void Experience_Click(object sender, EventArgs e)
        {
            Response.Redirect("Log In");
        }
    }
}