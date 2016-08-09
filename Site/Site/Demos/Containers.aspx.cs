using System;
namespace Site.Demos
{
    public partial class Containers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cb_ShowPanel_OnCheckedChanged(object sender, EventArgs e)
        {
            pnl_Panel1.Visible = cb_ShowPanel.Checked;
        }
    }
}