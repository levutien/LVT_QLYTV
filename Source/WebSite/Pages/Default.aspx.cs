using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PageLoad();
        }
    }

    private void PageLoad()
    {
        DTO.tblMemberCard memberCard = BUS.tblMemberCard.GetByID(((MasterPage_MasterPage)Master).Card_ID);
        if (memberCard != null)
        {
            lbPlaceName.Text = BUS.tblServicePlace.GetByID((int)memberCard.EMRPlace_ID).PlaceName;
            lbCard_ID.Text = memberCard.Card_ID.ToString();
            lbCardType_ID.Text = BUS.tblCardType.GetByID(memberCard.CardType_ID).Description;
            lbIssueDate.Text = memberCard.IssueDate.ToString("dd/MM/yyyy");
            lbExpDate.Text = memberCard.ExpDate == null ? "Không thời hạn" : ((DateTime)memberCard.ExpDate).ToString("dd/MM/yyyy");
            lbStatus_ID.Text = memberCard.Status_ID == null ? " - " : BUS.tblStatus.GetByID((int)memberCard.Status_ID).Description;
            lbTotalPoint.Text = memberCard.TotalPoint == null ? "Không có điểm" : ((int)memberCard.TotalPoint).ToString("N0");
        }
        DTO.tblCustomer customer = BUS.tblCustomer.GetByID(((MasterPage_MasterPage)Master).Customer_ID);
        if (customer != null)
        {
            lbFullname.Text = customer.FullName;
            lbAddressLine.Text = customer.AddressLine1 + " " + customer.AddressLine2;
            lbGender.Text = BUS.tblGender.GetByID(customer.Gender_ID).Description;
            lbEmail.Text = customer.Email;
            lbMobilePhone.Text = customer.MobilePhone;
            if (customer.DOB == null)
            {
                lbDOBYOB.Text = customer.YOB.ToString();
            }
            else
            {
                lbDOBYOB.Text = ((DateTime)customer.DOB).ToString("dd/MM/yyyy");
            }
        }
    }
}