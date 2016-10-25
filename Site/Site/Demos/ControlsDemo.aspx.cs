using System;

namespace Site.Demos
{
    public partial class ControlsDemo : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Denial of service attack caused me to miss a push to GIT
        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            lbl_Result.Text = "Your name is: " + txt_MichaelMiles.Text;
        }
    }
}