﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Demos
{
    public partial class State : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Check on the warning on 'ToString()
        protected void btn_SetDate_Click(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString();
        }

        protected void btn_PlainPostBack_Click(object sender, EventArgs e)
        {

        }
    }
}