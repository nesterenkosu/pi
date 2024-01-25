using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class MyCalcWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MyCalc.MyCalc calc = new MyCalc.MyCalc();
            double res;
            try
            {
                res = calc.Divide(
                    Convert.ToDouble(tb_a.Text),
                   Convert.ToDouble(tb_b.Text)
                );
            }
            catch (Exception)
            {
                lb_Result.Text = "Деление на ноль!";
                return;
            }

            lb_Result.Text = res.ToString();
        }
    }
}