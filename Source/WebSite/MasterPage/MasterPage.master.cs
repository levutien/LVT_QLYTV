using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CheckLogin();
    }

    private void CheckLogin()
    {
        HttpCookie myCookie = Request.Cookies["userInfo"];
        if (myCookie != null)
        {
            if (string.IsNullOrEmpty(myCookie.Values["Card_ID"]))
            {
                Response.Redirect(Page.ResolveUrl("~/dang-nhap.html"));
            }
            if (!string.IsNullOrEmpty(myCookie.Values["FullName"]))
                lbFullName.Text = Server.UrlDecode(myCookie.Values["FullName"].ToString());
        }
        else
        {
            Response.Redirect(Page.ResolveUrl("~/dang-nhap.html"));
        }
    }

    public int Card_ID
    {
        get
        {
            string result = "";
            HttpCookie myCookie = Request.Cookies["userInfo"];
            if (myCookie != null)
            {
                if (!string.IsNullOrEmpty(myCookie.Values["Card_ID"]))
                {
                    result = myCookie.Values["Card_ID"].ToString();
                }
            }
            return Convert.ToInt32(result);
        }
    }

    public int Customer_ID
    {
        get
        {
            string result = "";
            HttpCookie myCookie = Request.Cookies["userInfo"];
            if (myCookie != null)
            {
                if (!string.IsNullOrEmpty(myCookie.Values["Customer_ID"]))
                {
                    result = myCookie.Values["Customer_ID"].ToString();
                }
            }
            return Convert.ToInt32(result);
        }
    }
}
