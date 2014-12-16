using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Database
{
    public partial class ViewTicket : System.Web.UI.Page
    {
        double start;
        double end;
        int newId;
        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Request.QueryString["TicketID"];
            newId = Convert.ToInt32(id);
            if (!this.IsPostBack)
            {
                DataLayer.DataConnector dat = new DataLayer.DataConnector("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Server.MapPath("WhiteWave.accdb") + "'; Persist Security Info=False; ");
                DataTable dt = dat.DataSelect("select * from Tickets where TicketID = " + id);
                GridView1.DataBind();
            }
        }
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        protected void btnStart_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
            start = DateTime.Now.ToOADate();
            lblStart.Text = DateTime.Now.ToLongTimeString();
        }

        protected void btnStop_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = false;
            end = DateTime.Now.ToOADate();
            lblStop.Text = DateTime.Now.ToLongTimeString();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = false;
            lblTime.Text = "0.0";
        }

        protected void btnAddSuppEvent_Click(object sender, EventArgs e)
        {
            string supportEvent = TextArea1.Value;
            double time = end - start;

            DataLayer.DataConnector dat = new DataLayer.DataConnector("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Server.MapPath("WhiteWave.accdb") + "'; Persist Security Info=False; ");
            dat.DataUpdate("UPDATE Tickets SET SupportEvents = '" + supportEvent + "', SupportTimer = " + time + " WHERE TicketID = " + newId);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnOpen_Click(object sender, EventArgs e)
        {
            DataLayer.DataConnector dat = new DataLayer.DataConnector("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Server.MapPath("WhiteWave.accdb") + "'; Persist Security Info=False; ");
            string status = dat.DataScalar("select Status from Tickets where TicketID = " + newId);
            dat.DataUpdate("UPDATE Tickets SET Status = 'Yes' where TicketID = " + newId);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            DataLayer.DataConnector dat = new DataLayer.DataConnector("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Server.MapPath("WhiteWave.accdb") + "'; Persist Security Info=False; ");
            string status = dat.DataScalar("select Status from Tickets where TicketID = " + newId);
            dat.DataUpdate("UPDATE Tickets SET Status = No where TicketID = " + newId);
            Response.Redirect(Request.RawUrl, false);
        }
    }
}