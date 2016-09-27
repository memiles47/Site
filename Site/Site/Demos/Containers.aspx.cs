using System;
namespace Site.Demos
{
    public partial class Containers : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cb_ShowPanel_OnCheckedChanged(object sender, EventArgs e)
        {
            pnl_Panel1.Visible = cb_ShowPanel.Checked;
        }

        protected void Wizard1_FinishButtonClick(object sender, System.Web.UI.WebControls.WizardNavigationEventArgs e)
        {
            lbl_Result.Text = "Your name is" + tb_YourName.Text;
            lbl_Result.Text += "<br />Your favorite language is " + ddl_FavoriteLanguage.SelectedValue;
        }
    }
}