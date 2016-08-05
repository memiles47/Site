using System;

namespace Site.Demos
{
    public partial class ControlsDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            lbl_Result.Text = "Your name is: " + txt_MichaelMiles.Text;
        }
    }
}