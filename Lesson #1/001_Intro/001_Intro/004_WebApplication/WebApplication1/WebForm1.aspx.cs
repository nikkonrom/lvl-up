using System;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {        
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text;
        }
    }
}