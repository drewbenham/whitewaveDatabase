using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database
{
    public partial class AddAsset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateAsset_Click(object sender, EventArgs e)
        {
            var id = Request.QueryString["CustomerID"];
            string assetName = txtAssetName.Text;
            string ipAddress = txtIP.Text;
            string password = txtAssetPass.Text;
            string model = txtModel.Text;

            DataLayer.DataConnector dat = new DataLayer.DataConnector("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Server.MapPath("WhiteWave.accdb") + "'; Persist Security Info=False; ");
            dat.DataInsert("insert into Assets (AssetName, IPaddress, AssetPassword, Model) values('" + assetName + "','" + ipAddress + "','" + password + "','" + model + "')");
            string assetId = dat.DataScalar("select AssetID from Assets where AssetName = '" + assetName + "'");
            dat.DataUpdate("update Customers set Assets = '" + assetId + "' where CustomerID = " +id);
            Response.Redirect("ViewCustomer.aspx?CustomerID=" + id, false);
        }
    }
}