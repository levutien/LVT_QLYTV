using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administrator_MasterPage_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CheckLogin();
    }

    private void CheckLogin()
    {
        HttpCookie myCookie = Request.Cookies["staffInfo"];
        if (myCookie != null)
        {
            if (string.IsNullOrEmpty(myCookie.Values["StaffID"]))
            {
                Response.Redirect(Page.ResolveUrl("~/admin/dang-nhap.html"));
            }
            if (!string.IsNullOrEmpty(myCookie.Values["StaffName"]))
                lbFullName.Text = Server.UrlDecode(myCookie.Values["StaffName"].ToString());
        }
        else
        {
            Response.Redirect(Page.ResolveUrl("~/admin/dang-nhap.html"));
        }
    }

    public int StaffID
    {
        get
        {
            string result = "";
            HttpCookie myCookie = Request.Cookies["staffInfo"];
            if (myCookie != null)
            {
                if (!string.IsNullOrEmpty(myCookie.Values["StaffID"]))
                {
                    result = myCookie.Values["StaffID"].ToString();
                }
            }
            if (result != "")
                return Convert.ToInt32(result);
            return 0;
        }
    }   

    public string StaffName
    {
        get
        {
            string result = "";
            HttpCookie myCookie = Request.Cookies["staffInfo"];
            if (myCookie != null)
            {
                if (!string.IsNullOrEmpty(myCookie.Values["StaffName"]))
                {
                    result = myCookie.Values["StaffName"].ToString();
                }
            }
            if (result != "")
                return result;
            return "";
        }
    }
}
