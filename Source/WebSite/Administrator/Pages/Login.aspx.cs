using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administrator_Pages_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            System.Data.DataTable dt = BUS.tblStaff.Login(txtUserName.Text, txtPassword.Text);
            lbError.Text = "";
            if (dt.Rows.Count > 0)
            {
                if (Request.Browser.Cookies)
                {
                    System.Data.DataRow row = dt.Rows[0];
                    Logout();
                    HttpCookie aCookie = new HttpCookie("staffInfo");
                    aCookie.Values.Add("StaffID", row[0].ToString());
                    aCookie.Values.Add("StaffName", Server.UrlEncode(row[1].ToString()));
                    aCookie.Expires = DateTime.Now.AddDays(7);
                    Response.Cookies.Add(aCookie);
                    Response.Redirect("~/admin/index.html");
                }
            }
            else
            {
                lbError.Text = "Mã thẻ và email không tồn tại hoặc mật khẩu không chính xác";
            }
        }
    }

    private void Logout()
    {
        HttpCookie aCookie;
        string cookieName;
        int limit = Request.Cookies.Count;
        for (int i = 0; i < limit; i++)
        {
            cookieName = Request.Cookies[i].Name;
            aCookie = new HttpCookie(cookieName);
            aCookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(aCookie);

        }
    }
}