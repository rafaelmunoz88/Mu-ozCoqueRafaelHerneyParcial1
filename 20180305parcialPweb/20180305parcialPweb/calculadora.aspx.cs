using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20180305parcialPweb
{
    public partial class calculadora : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string numero1 = num1.Text;
            string numero2 = num2.Text;
            TBresultado.Text = numero1 + numero2;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

        protected void num1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void num2_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void BtnMult_Click(object sender, EventArgs e)
        {
            
        }

        protected void BtnDiv_Click(object sender, EventArgs e)
        {
            
        }
    }
}