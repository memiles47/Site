using System;

//namespace Site
//{
//    public class BasePage
//    {
        
//    }
//}

namespace Site
{
    public class BasePage : System.Web.UI.Page
    {
        private void Page_PreRender(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Title) ||
                Title.Equals("Untitled Page", StringComparison.CurrentCultureIgnoreCase))
            {
                throw new Exception("Page title cannot be \"Untitled Page\" or an empty string.");
            }
        }

        private void Page_PreInit(object sender, EventArgs e)
        {
            var preferredTheme = Request.Cookies.Get("PreferredTheme");
            if (preferredTheme == null) return;
            var folder = Server.MapPath("~/App_Themes/" + preferredTheme.Value);

            if (System.IO.Directory.Exists(folder))
            {
                Page.Theme = preferredTheme.Value;
            }
        }

        protected BasePage()
        {
            PreRender += Page_PreRender;
            PreInit += Page_PreInit;
        }
    }
}

