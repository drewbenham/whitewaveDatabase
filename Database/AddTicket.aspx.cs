using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data;

namespace Database
{
    public partial class AddTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateTicket_Click1(object sender, EventArgs e)
        {
            string ticketName = txtTicketName.Text;
            string description = txtProbDescrip.Text;
            string techAssign = txtTechAssign.Text;
            int priority = Convert.ToInt32(ddPriority.SelectedValue);

            DataLayer.DataConnector dat = new DataLayer.DataConnector("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Server.MapPath("WhiteWave.accdb") + "'; Persist Security Info=False; ");
            DataTable dt = dat.DataSelect("select FullName from Login where FullName = '" + techAssign + "'");
            if (dt.Rows.Count > 0)
            {
                Tickets tick = new Tickets(ticketName, techAssign, 0, description, priority, true);
                dat.DataInsert("insert into Tickets (TicketName, Description, Priority, Technician, SupportTimer, Status) values('" + ticketName + "','" + description + "','" + priority + "','" + techAssign + "','" + 0 + "', Yes)");
                Response.Redirect("Tickets.aspx");
            }
            else
            {
                MessageBox.Show("Technician name entered does not exist");
            }
        }

        protected void btnCancelTicketCreation_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Tickets.aspx");
        }
    }
}