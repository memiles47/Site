using System;

namespace Site.Demos
{
    public partial class CodeBehind : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_DateTime.Text = "Hello World; the time is now " + DateTime.Now;
        }
    }
}