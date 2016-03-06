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
        }
        DTO.tblCustomer customer = BUS.tblCustomer.GetByID(((MasterPage_MasterPage)Master).Customer_ID);
        if (customer != null)
        {
            lbFullname.Text = customer.FullName;
            lbAddressLine.Text = customer.AddressLine1 + " " + customer.AddressLine2;
            lbGender.Text = BUS.tblGender.GetByID(customer.Gender_ID).Description;
            lbEmail.Text = customer.Email;
            lbMobilePhone.Text = customer.MobilePhone;
        }
    }
}