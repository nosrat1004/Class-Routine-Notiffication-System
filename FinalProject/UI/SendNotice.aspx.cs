using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.UI
{
    public partial class SendNotice : System.Web.UI.Page
    {
        private static string[] Days = { "saturday", "sunday", "monday", "tuesday", "wednesday", "thursday" };
        public string[] CourseCodes = { "SWE426A", "SWE423B", "SWE425C", "SWE332D", "SWE332C", "SWE423A" }; 
        public string[] Batchs = { "16A", "16B", "16C", "16D", "16C", "16A" };
        public string time;

        
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckAndSendEmail();
        }

        
        private void CheckAndSendEmail()
        {
            string currentDay = DateTime.Now.DayOfWeek.ToString();

            for (int i = 0; i < Days.Length; i++)
            {
                if (Days[i].Equals(currentDay.ToLower()))
                {
                    CheckIfNoticeble(Days[i + 1]); 
                }
            }

        }
        
        private void CheckIfNoticeble(string nextDay)
        {
            string connString = "data source=NOSRAT\\NOSRAT;database = CRNDB; integrated security=true";

            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                string cmdtext = "IS_HAVE_CLASS";

                SqlCommand cmd = new SqlCommand(cmdtext, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dayName", nextDay);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); 
                da.Fill(dt);
                DataTable dt2 = new DataTable();

                
                for (int i = 0; i < 6; i++)
                {
                    if (dt.Rows[0]["CourseCode"].ToString().Equals(CourseCodes[i]))
                    {
                        dt2 = SelectGuardianEmailsThroughStudent(Batchs[i]);
                        time = dt.Rows[0]["Time"].ToString();
                    }
                }


                if (dt2.Rows.Count > 0)
                {
                    SendMail(nextDay, dt2, time);
                }
            }
        }

        private DataTable SelectGuardianEmailsThroughStudent(string studentBatch)
        {
            string connString = "data source=NOSRAT\\NOSRAT;database = CRNDB; integrated security=true";

            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                string cmdtext = "select_guardian_email_by_student";

                SqlCommand cmd = new SqlCommand(cmdtext, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@batch", studentBatch);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        private void SendMail(string dayName, DataTable dt, string time)
        {
            try
            {
                SmtpClient client = new SmtpClient("Smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("nosratfarzana123@gmail.com", "farzana1996");
                MailMessage msgobj = new MailMessage();

                foreach (DataRow dr in dt.Rows)
                {
                    msgobj.To.Add(dr["email"].ToString());
                }
                
                msgobj.From = new MailAddress("nosratfarzana123@gmail.com");


                msgobj.Subject = "Class Notice";
                msgobj.Body = "Respected guardian, your daughter/son have a class on :" + dayName + " at: " + time;

                client.Send(msgobj);
                lblMessage.Text = "Email has been send successfully";

                //ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('message has been sent successfully');", true);
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Could not send the email !"; 
            }
        }
    }
}