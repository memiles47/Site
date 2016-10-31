using System;
using System.Web;

namespace Site.MasterPages
{
    public partial class Frontend : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var selectedTheme = Page.Theme;
                var preferredTheme = Request.Cookies.Get("PreferredTheme");

                if (preferredTheme != null)
                {
                    selectedTheme = preferredTheme.Value;
                }

                if (!string.IsNullOrEmpty(selectedTheme))
                {
                    var item = ThemeList.Items.FindByValue(selectedTheme);

                    if (item != null)
                    {
                        item.Selected = true;
                    }
                }
            }
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