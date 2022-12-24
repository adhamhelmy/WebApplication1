using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class SamView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddMatch(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["database"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            String hostname = hname.Text;
            String guestname = gname.Text;
            String start = stime.Text;
            String end = etime.Text;
            SqlCommand addmatch = new SqlCommand("addNewMatch", conn);
            addmatch.CommandType = System.Data.CommandType.StoredProcedure;
            addmatch.Parameters.AddWithValue("@hostclub", hostname);
            addmatch.Parameters.AddWithValue("@guestclub", guestname);
            addmatch.Parameters.AddWithValue("@start", start);
            addmatch.Parameters.AddWithValue("@end", end);


            conn.Open();
            addmatch.ExecuteNonQuery();
            conn.Close();
        }
    }
}