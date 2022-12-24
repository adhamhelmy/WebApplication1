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
    public partial class SystemAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddClub(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["database"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            String name = clubname.Text;
            String loc = clublocation.Text;
            SqlCommand addclub = new SqlCommand("addClub", conn);
            addclub.CommandType = System.Data.CommandType.StoredProcedure;
            addclub.Parameters.AddWithValue("@name", name);
            addclub.Parameters.AddWithValue("@location", loc);

            conn.Open();
            addclub.ExecuteNonQuery();
            conn.Close();
        }
        protected void DeleteClub(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["database"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            String name = clubnamedelete.Text;
            
            SqlCommand deleteclub = new SqlCommand("deleteClub", conn);
            deleteclub.CommandType = System.Data.CommandType.StoredProcedure;
            deleteclub.Parameters.AddWithValue("@name", name);
           

            conn.Open();
            deleteclub.ExecuteNonQuery();
            conn.Close();
        }
        protected void AddStadium(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["database"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            String name = stadiumname.Text;
            String loc = stadiumlocation.Text;
            int cap = Int32.Parse(stadiumcapacity.Text);
            SqlCommand addstadium = new SqlCommand("addStadium", conn);
            addstadium.CommandType = System.Data.CommandType.StoredProcedure;
            addstadium.Parameters.AddWithValue("@name", name);
            addstadium.Parameters.AddWithValue("@location", loc);
            addstadium.Parameters.AddWithValue("@c", cap);

            conn.Open();
            addstadium.ExecuteNonQuery();
            conn.Close();
        }
        protected void DeleteStadium(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["database"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            String name = stadiumnamedelete.Text;

            SqlCommand deletestadium = new SqlCommand("deleteStadium", conn);
            deletestadium.CommandType = System.Data.CommandType.StoredProcedure;
            deletestadium.Parameters.AddWithValue("@name", name);


            conn.Open();
            deletestadium.ExecuteNonQuery();
            conn.Close();
        }
        protected void BlockFan(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["database"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            int id = Int16.Parse(fanid.Text);

            SqlCommand blockfan = new SqlCommand("deleteStadium", conn);
            blockfan.CommandType = System.Data.CommandType.StoredProcedure;
            blockfan.Parameters.AddWithValue("@nID", id);


            conn.Open();
            blockfan.ExecuteNonQuery();
            conn.Close();
        }
    }
}