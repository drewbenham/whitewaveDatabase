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
    public partial class RegisterNewUser : System.Web.UI.Page
    {
        Technician tech;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtFullName.Text;
                string username = txtUsername.Text;
                string pass = txtPassword.Text;
                string email = txtEmail.Text;
                tech = new Technician(name, email, username, pass);
                DataLayer.DataConnector dat = new DataLayer.DataConnector("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Server.MapPath("WhiteWave.accdb") + "'; Persist Security Info=False; ");
                DataTable dt = dat.DataSelect("select UserID from Login where Username = '" + username + "' and Password = '" + pass + "'");
               
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Username or Password already in use");
                }
                else
                {
                    dat.DataInsert("insert into Login (FullName, Username, Pwd, Email) values ('" + name + "','" + username +  "','" + pass + "','" + email + "')");
                    MessageBox.Show("Registered Successfully!", "Registered");
                }
                Response.Redirect("Default.aspx");
            }
            catch(Exception err)
            {
                //MessageBox.Show("Wrong Information", "Error");
            }
        }
        public Technician getTechInfo()
        {
            return tech;
        }
    }
}