using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace Site.App_Code
//{
//    public class BasePage
//    {
//    }
//}

namespace Site.App_Code
{
    public class BasePage : System.Web.UI.Page
    {
        private void Page_PreRender(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Title) || this.Title.Equals("Untitled Page", StringComparison.CurrentCultureIgnoreCase))
            {
                throw new Exception("Page Title cannot be \"Untitled Page\" or an empty string.");
            }
        }

        public BasePage()
        {
            this.PreRender += Page_PreRender;
        }
    } 
}