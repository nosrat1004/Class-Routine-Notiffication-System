using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.UI
{
    public partial class UploadRoutine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUploadRoutine_Click(object sender, EventArgs e)
        {
            if (fuRoutine.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(fuRoutine.FileName);

                if (fileExtension.ToLower() != ".xls" && fileExtension.ToLower() != ".xlsx")

                {
                    lblMessage.Text = "Only files with .xls or .xslx are allowed";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
                else
                {

                    int fileSize = fuRoutine.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        lblMessage.Text = "Maximum file size (2mb) exceeded";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        fuRoutine.SaveAs(Server.MapPath("~/Uploads/" + fuRoutine.FileName));
                        lblMessage.Text = "File Uploaded";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
            else
            {
                lblMessage.Text = "Please select a file to upload";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }

}