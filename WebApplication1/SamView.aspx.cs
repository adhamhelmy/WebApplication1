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
        protected void DeleteMatch(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["database"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            String hostname = hname2.Text;
            String guestname = gname2.Text;
           
            SqlCommand delmatch = new SqlCommand("deletematch", conn);

            delmatch.CommandType = System.Data.CommandType.StoredProcedure;
            delmatch.Parameters.AddWithValue("@hostname", hostname);
            delmatch.Parameters.AddWithValue("@guestname", guestname);
            
            conn.Open();
            delmatch.ExecuteNonQuery();
            conn.Close();
        }
        protected void AllUpcomingMatches(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["database"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            DataTable table = new DataTable();

            SqlCommand AllUpcomingMatches = new SqlCommand("select * from match where match.start_time > CURRENT_TIMESTAMP", conn);

           
            conn.Open();
            table.Load(AllUpcomingMatches.ExecuteReader());

            Table1.DataSource = table;
            Table1.DataBind();

            conn.Close();
        }
        protected void AlreadyPlayedMatches(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["database"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            DataTable table = new DataTable();

            SqlCommand AlreadyPlayedMatches = new SqlCommand("select * from match where match.end_time < CURRENT_TIMESTAMP", conn);


            conn.Open();
            table.Load(AlreadyPlayedMatches.ExecuteReader());

            Table2.DataSource = table;
            Table2.DataBind();
            conn.Close();
        }
        protected void NeverMatched(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["database"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            DataTable table = new DataTable();

            SqlCommand NeverMatched = new SqlCommand("clubsNeverMatched", conn);


            conn.Open();
            table.Load(NeverMatched.ExecuteReader());

            Table3.DataSource = table;
            Table3.DataBind();
            conn.Close();
        }
    }
}