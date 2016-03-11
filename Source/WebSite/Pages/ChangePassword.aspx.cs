using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ChangePassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnChange_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            if (BUS.tblMemberCard.ChangePassword(((MasterPage_MasterPage)Page.Master).Card_ID, txtAccessCodeOld.Text, txtAccessCodeNew.Text))
            {
                lbSuccess.Text = "Thay đổi mật khẩu thành công";
                lbError.Text = "";
            }
            else
            {
                lbError.Text = "Mật khẩu cũ không đúng";
                lbSuccess.Text = "";
            }
        }
    }
}