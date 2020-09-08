using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppToExplainingBranching
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblMsg.Visible = true;
            if(string.IsNullOrEmpty(txtUName.Text)||string.IsNullOrEmpty(txtUPwd.Text))
            {
                lblMsg.Text = "UserName and Password Required...";
            }
            else
            {
                if((txtUName.Text=="sam123")&&(txtUPwd.Text=="sam@123"))
                {
                    lblMsg.Text = "Login Success!!";
                }
                else
                {
                    lblMsg.Text = "Invalid Credentials..!";
                }
            }
        }
    }
}