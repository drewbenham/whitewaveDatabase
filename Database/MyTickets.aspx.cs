using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;


namespace Database
{
    public partial class MyTickets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var username = Request.QueryString["Username"];
            
            if (!this.IsPostBack)
            {
                DataLayer.DataConnector dat = new DataLayer.DataConnector("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Server.MapPath("WhiteWave.accdb") + "'; Persist Security Info=False; ");
                string name = dat.DataScalar("select FullName from Login where Username='" + username + "'");
                DataTable dt = dat.DataSelect("select * from Tickets where Technician = '" + name + "'");
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void btnMyEdit_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedIndex != -1)
            {
                var id = Convert.ToInt32(GridView1.DataKeys[GridView1.SelectedIndex].Value);
                Response.Redirect("ViewTicket.aspx?TicketID=" + id, false);
            }
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}