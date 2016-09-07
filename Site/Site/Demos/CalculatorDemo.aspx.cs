using System;

namespace Site.Demos
{
    public partial class CalculatorDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Calculate_Click(object sender, EventArgs e)
        {
            if (txt_Value1.Text.Length == 0 || txt_Value2.Text.Length == 0)
                return;
            
            decimal temp;
            var result = 0.0m;
            var value1 = decimal.TryParse(txt_Value1.Text, out temp) ? temp : 0;
            var value2 = decimal.TryParse(txt_Value2.Text, out temp) ? temp : 0;

            switch (ddl_OperatorList.SelectedValue)
            {
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
                case "*":
                    result = value1*value2;
                    break;
                case "/":
                    result = value2 == 0.0m ? 0 : value1/value2;
                    break;
            }

            lbl_ResultLable.Text = value2 == 0.0m && ddl_OperatorList.SelectedValue == "/"? "Divide by zero error!" : result.ToString();
        }
    }
}