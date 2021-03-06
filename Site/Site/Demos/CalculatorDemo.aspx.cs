﻿using System;

namespace Site.Demos
{
    public partial class CalculatorDemo : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Calculate_Click(object sender, EventArgs e)
        {
            var myCalculator = new Calculator();

            if (txt_ValueOne.Text.Length == 0 || txt_ValueTwo.Text.Length == 0)
                return;
            /*
             * Added temp variable for the additional checks for a valid entry
             * into the value1 and value2 variables
             */

            double temp;
            var result = 0.0;
            var value1 = double.TryParse(txt_ValueOne.Text, out temp) ? temp : 0;
            var value2 = double.TryParse(txt_ValueTwo.Text, out temp) ? temp : 0;

            switch (ddl_OperatorList.SelectedValue)
            {
                case "+":
                    result = myCalculator.Add(value1, value2);
                    break;
                case "-":
                    result = myCalculator.Subtract(value1, value2);
                    break;
                case "*":
                    result = myCalculator.Multiply(value1, value2);
                    break;
                case "/":
                    result = myCalculator.Divide(value1, value2);
                    break;
            }

            // 'Divide by zero' statement for divide by zero errors
            lbl_ResultLable.Text = result == 0.0 && ddl_OperatorList.SelectedValue == "/"? "Divide by zero error!" : result.ToString();
        }
    }
}