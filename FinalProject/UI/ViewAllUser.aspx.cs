
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
    public partial class ViewAllUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnViewStudent_Click(object sender, EventArgs e)
        {
            gv.DataSource = ExecuteProcedure("SELECT_STUDENT", null);
            gv.DataBind();
        }

        protected void btnViewTeacher_Click(object sender, EventArgs e)
        {
            gv.DataSource = ExecuteProcedure("SELECT_TEACHER", null);
            gv.DataBind();
        }

        protected void btnViewGuardin_Click(object sender, EventArgs e)
        {
            gv.DataSource = ExecuteProcedure("SELECT_GUARDIAN", null);
            gv.DataBind();
        }

        private DataTable ExecuteProcedure(string procedureName, SqlParameter[] parameters)
        {
            string connString = "data source=NOSRAT\\NOSRAT;database = CRNDB; integrated security=true";

            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = procedureName;

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                cmd.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();

                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    return new DataTable();
                }

                return dt;
            }
        }
    }
}