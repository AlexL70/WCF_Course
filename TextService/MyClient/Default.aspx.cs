using System;
using System.Linq;
using MyClient.MyServiceReference;

namespace MyClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyServiceClient client = new MyServiceClient();
            DropDownList1.DataSource = client.GetAllCountries().ToList();
            DropDownList1.DataValueField = nameof(Country.Id);
            DropDownList1.DataTextField = nameof(Country.Name);
            DropDownList1.DataBind();
        }
    }
}