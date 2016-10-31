using System;

namespace Site.Demos
{
    public partial class State : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_SetDate_Click(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString();
        }

        protected void btn_PlainPostBack_Click(object sender, EventArgs e)
        {

        }
    }
}