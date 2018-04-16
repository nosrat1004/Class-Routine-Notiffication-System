using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

namespace sendemail
{
    public partial class Mailsending : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("Smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("nosratfarzana123@gmail.com", "farzana1996");
                MailMessage msgobj = new MailMessage();
                msgobj.To.Add(txtTo.Text);
                msgobj.From = new MailAddress("nosratfarzana123@gmail.com");
                msgobj.Subject = txtSub.Text;
                msgobj.Body = txtBody.Text;
                client.Send(msgobj);
                Response.Write("Email has been send successfully");
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('message has been sent successfully');", true);


            }
            catch (Exception ex)
            {
                lblStatus.Text= "Could not send the email !";

            }
        }
    }
}