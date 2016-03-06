using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            int card_id = 0;
            if (int.TryParse(txtUserName.Text, out card_id))
                card_id = Convert.ToInt32(txtUserName.Text.Trim());
            System.Data.DataTable dt = BUS.tblMemberCard.Login(card_id, txtUserName.Text, txtPassword.Text);
            if (dt.Rows.Count > 0)
            {
                if (Request.Browser.Cookies)
                {
                    System.Data.DataRow row = dt.Rows[0];
                    Logout();
                    HttpCookie aCookie = new HttpCookie("userInfo");
                    aCookie.Values.Add("Card_ID", row[0].ToString());
                    aCookie.Values.Add("Customer_ID", row[1].ToString());
                    aCookie.Values.Add("FullName", Server.UrlEncode(row[2].ToString()));
                    aCookie.Expires = DateTime.Now.AddDays(7);
                    Response.Cookies.Add(aCookie);
                    Response.Redirect("index.html");
                }
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