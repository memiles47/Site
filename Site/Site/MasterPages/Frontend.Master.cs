using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.MasterPages
{
    public partial class Frontend : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ThemeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var preferredTheme = new HttpCookie("PreferredTheme")
            {
                Expires = DateTime.Now.AddMonths(3),
                Value = ThemeList.SelectedValue
            };
            Response.Cookies.Add(preferredTheme);
            Response.Redirect(Request.Url.ToString());
        }
    }
}