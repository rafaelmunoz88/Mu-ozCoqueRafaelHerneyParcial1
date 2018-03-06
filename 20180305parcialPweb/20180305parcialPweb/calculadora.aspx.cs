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
            string numero1 = txtnum1.Text;
            string numero2 = txnum2.Text;
            txtresultado.Text = "" + (Int32.Parse(numero1) + Int32.Parse(numero2));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string numero1 = txtnum1.Text;
            string numero2 = txnum2.Text;
            txtresultado.Text = "" + (Int32.Parse(numero1) - Int32.Parse(numero2));
        }

        protected void num1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void num2_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void BtnMult_Click(object sender, EventArgs e)
        {
            string numero1 = txtnum1.Text;
            string numero2 = txnum2.Text;
            txtresultado.Text = "" + (Int32.Parse(numero1) * Int32.Parse(numero2));
        }

        protected void BtnDiv_Click(object sender, EventArgs e)
        {
            string numero1 = txtnum1.Text;
            string numero2 = txnum2.Text;
            if ((Int32.Parse(numero2) <= 0))
            {
                txtresultado.Text = "El segundo numero debe ser mayor a cero";
            }
             else
            { 
                txtresultado.Text = "" + (Int32.Parse(numero1) / Int32.Parse(numero2));
            }
        }
    }
}