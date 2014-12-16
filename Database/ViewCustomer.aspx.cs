using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Database
{
    public partial class ViewCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Request.QueryString["CustomerID"];
            if (!this.IsPostBack)
            {
                DataLayer.DataConnector dat = new DataLayer.DataConnector("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Server.MapPath("WhiteWave.accdb") + "'; Persist Security Info=False; ");
                DataTable dt = dat.DataSelect("select * from Customers where CustomerID = " + id);
                GridView1.DataBind();
            }
        }

        protected void btnAddAsset_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedIndex != -1)
            {
                var id = Convert.ToInt32(GridView1.DataKeys[GridView1.SelectedIndex].Value);
                Response.Redirect("AddAsset.aspx?CustomerID=" + id, false);
            }
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}