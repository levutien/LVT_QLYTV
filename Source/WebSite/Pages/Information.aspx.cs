using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Information : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PageLoad();
            PageLoadData();
        }
    }
    private void PageLoadData()
    {
        DTO.tblCustomer customer = BUS.tblCustomer.GetByID(((MasterPage_MasterPage)Master).Customer_ID);
        if (customer != null)
        {
            txtFullName.Text = customer.FullName;
            txtAddressLine1.Text = customer.AddressLine1;
            txtAddressLine2.Text = customer.AddressLine2;
            ddlGender_ID.SelectedValue = customer.Gender_ID.ToString();
            txtEmail.Text = customer.Email;
            txtMobilePhone.Text = customer.MobilePhone;
            if (customer.DOB == null)
            {
                ddlYear.SelectedItem.Value = customer.YOB.ToString();
            }
            else
            {
                ddlYear.SelectedValue = ((DateTime)customer.DOB).Year.ToString();
                ddlMonth.SelectedValue = ((DateTime)customer.DOB).Month.ToString();
                ddlDay.SelectedValue = ((DateTime)customer.DOB).Day.ToString();

            }
            lbEMRPlace_ID.Text = BUS.tblServicePlace.GetByID((int)BUS.tblMemberCard.GetByID(((MasterPage_MasterPage)Master).Card_ID).EMRPlace_ID).PlaceName;
        }
    }
    private void PageLoad()
    {
        ddlGender_ID.DataSource = BUS.tblGender.GetAll();
        ddlGender_ID.DataValueField = "Gender_ID";
        ddlGender_ID.DataTextField = "Description";
        if (ddlGender_ID.Items.Count > 0)
            ddlGender_ID.SelectedIndex = 0;
        ddlGender_ID.DataBind();

        ddlDay.Items.Add(new ListItem("[Chọn]", ""));
        for (int i = 1; i <= 31; i++)
        {
            ddlDay.Items.Add(new ListItem(i.ToString(), i.ToString()));
        }
        if (ddlDay.Items.Count > 0)
            ddlDay.SelectedIndex = 0;
        ddlDay.DataBind();

        ddlMonth.Items.Add(new ListItem("[Chọn]", ""));
        for (int i = 1; i <= 12; i++)
        {
            ddlMonth.Items.Add(new ListItem(i.ToString(), i.ToString()));
        }
        if (ddlMonth.Items.Count > 0)
            ddlMonth.SelectedIndex = 0;
        ddlMonth.DataBind();

        ddlYear.Items.Add(new ListItem("[Chọn]", ""));
        for (int i = DateTime.Now.Year; i >= 1900; i--)
        {
            ddlYear.Items.Add(new ListItem(i.ToString(), i.ToString()));
        }
        if (ddlYear.Items.Count > 0)
            ddlYear.SelectedIndex = 0;
        ddlYear.DataBind();

    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            DTO.tblCustomer item = new DTO.tblCustomer();
            item.Customer_ID = ((MasterPage_MasterPage)Master).Customer_ID;
            item.FullName = txtFullName.Text;
            item.Gender_ID = Convert.ToInt32(ddlGender_ID.SelectedItem.Value);
            item.MobilePhone = txtMobilePhone.Text;
            item.Email = txtEmail.Text;
            item.AddressLine1 = txtAddressLine1.Text;
            item.AddressLine2 = txtAddressLine2.Text;
            if (ddlYear.SelectedItem.Value != "")
            {
                item.YOB = Convert.ToInt32(ddlYear.SelectedItem.Value);
                if (ddlMonth.SelectedItem.Value != "" && ddlDay.SelectedItem.Value != "")
                {
                    item.DOB = new DateTime(Convert.ToInt32(ddlYear.SelectedItem.Value), Convert.ToInt32(ddlMonth.SelectedItem.Value), 1);
                    int day = item.DOB.Value.AddMonths(1).AddDays(-1).Day <= Convert.ToInt32(ddlDay.SelectedItem.Value) ? item.DOB.Value.AddMonths(1).AddDays(-1).Day : Convert.ToInt32(ddlDay.SelectedItem.Value);
                    item.DOB = item.DOB.Value.AddDays(day - 1);

                }
            }

            if (BUS.tblCustomer.Create(item) > 0)
            {
                lbSuccess.Text = "cập nhật thông tin thành công";
                lbError.Text = "";
                PageLoadData();
            }
            else
            {
                lbError.Text = "Cập nhật thông tin không thành công";
                lbSuccess.Text = "";
            }

        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        PageLoadData();
    }
}