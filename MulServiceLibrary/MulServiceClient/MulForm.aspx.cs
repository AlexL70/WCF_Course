using System;

namespace MulServiceClient
{
    public partial class MulForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MulServiceReference.MulServiceClient client = new MulServiceReference.MulServiceClient("BasicHttpBinding_IMulService");
            int resp = client.Mult(5, 5);
            Response.Write(resp);
        }
    }
}