using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SportAssociationManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Register(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["database"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            String nam = name.Text;
            String user = username.Text;
            String pass = password.Text;
            SqlCommand addSAMproc = new SqlCommand("addAssociationManager", conn);
            addSAMproc.CommandType = System.Data.CommandType.StoredProcedure;
            addSAMproc.Parameters.AddWithValue("@name", nam);
            addSAMproc.Parameters.AddWithValue("@username", user);
            addSAMproc.Parameters.AddWithValue("@password", pass);

            conn.Open();
            addSAMproc.ExecuteNonQuery();
            conn.Close();

        }
    }
}