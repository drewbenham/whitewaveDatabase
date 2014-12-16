using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Database
{
    public partial class Default : System.Web.UI.Page
    {
        public string user;
        public class User
        {
            private string user;
            public User(string name)
            {
                user = name;
            }
            public string User1
            {
                get { return user; }
                set { user = value; }
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bnLogin_Click(object sender, EventArgs e)
        {
            DataLayer.DataConnector dat = new DataLayer.DataConnector("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='"+Server.MapPath("WhiteWave.accdb")+"'; Persist Security Info=False; ");
            DataTable dt = dat.DataSelect("select UserID from Login where Username = '" + txtUsername.Text.Replace("'", "''") + "' and Pwd = '" + txtPassword.Text.Replace("'", "''") + "'");
            if (dt.Rows.Count > 0)
            {
                user = txtUsername.Text;
                Response.Redirect("MyTickets.aspx?Username=" + user, false);
            }
        }
    }
}