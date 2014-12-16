using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateCust_Click(object sender, EventArgs e)
        {
            string companyName = txtCompanyName.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            DataLayer.DataConnector dat = new DataLayer.DataConnector("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Server.MapPath("WhiteWave.accdb") + "'; Persist Security Info=False; ");
            dat.DataInsert("insert into Customers (CompanyName, Email, Location, Phone) values ('" + companyName + "','" + email + "','" + address + "','" + phone + "')");
            Response.Redirect("Customers.aspx");
        }

    }
}