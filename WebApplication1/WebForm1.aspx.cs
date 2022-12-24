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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["database"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            String user = username.Text;
            String pass = password.Text;
            SqlCommand loginproc = new SqlCommand("userLogin", conn);
            loginproc.CommandType = System.Data.CommandType.StoredProcedure;
            loginproc.Parameters.AddWithValue("@username", user);
            loginproc.Parameters.AddWithValue("@password", pass);

            SqlParameter success = loginproc.Parameters.Add("@success", SqlDbType.Int);
            SqlParameter type = loginproc.Parameters.Add("@type", SqlDbType.Int);


            success.Direction = ParameterDirection.Output;
            type.Direction = ParameterDirection.Output;


            conn.Open();
            loginproc.ExecuteNonQuery();
            conn.Close();

            if(success.Value.ToString()=="1")
            {
                if (type.Value.ToString() == "1")
                {
                    Response.Redirect("SystemAdmin.aspx");
                }
                else if (type.Value.ToString() == "2")
                {
                    Response.Redirect("SamView.aspx");
                }
                else if (type.Value.ToString() == "3")
                {
                    Response.Redirect(".aspx");
                }
                else if (type.Value.ToString() == "4")
                {
                    Response.Redirect(".aspx");
                }
                else if (type.Value.ToString() == "5")
                {
                    Response.Redirect(".aspx");
                } 
            }
        }

    }
}