using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string connString = "data source=NOSRAT\\NOSRAT;database = CRNDB; integrated security=true";

            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                string cmdtext = "Select * from Teacher where Id=@id and password=@password";
                SqlCommand cmd = new SqlCommand(cmdtext, con);
                cmd.Parameters.AddWithValue("@Id", txtID.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["Category"].ToString().Equals("admin"))
                    {
                        Session["IsAdminLogin"] = true;
                        Response.Redirect("~/UI/AdminDashBoard.aspx");
                    }else
                    {
                        Session["IsLogin"] = true;
                        Response.Redirect("~/UI/Teacherdashboard.aspx");
                    }
                }

            }
        }
    }
}