﻿using System;
using System.Web.UI.WebControls;

namespace Site.Demos
{
    public partial class ListControls : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            lbl_Output.Text = "In the DDL you selected " + ddl_LanguageSelect.SelectedValue + "<br />";

            foreach(ListItem item in cbl_LanguageSelect.Items)
            {
                if (item.Selected)
                {
                    lbl_Output.Text += "In the CBL you selected " + item.Value + "<br />";
                }
            }
        }
    }
}