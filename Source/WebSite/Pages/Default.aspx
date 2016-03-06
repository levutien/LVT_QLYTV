<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Pages_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="clhContent" runat="Server">
    <div class="row">
        <div class="col-xs-12 col-sm-12 col-md-6 col-lg-6">
            <div class="form-horizontal">
                <div class="form-group">
                    <div class="col-xs-9">
                        <h4>Thông tin cá nhân</h4>
                    </div>
                    <asp:Button ID="btnEdit" CssClass="col-xs-3 btn btn-default btn-primary" runat="server" Text="Chỉnh sửa" />
                </div>
            </div>
            <div class="form-horizontal">
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Họ và tên:</label>
                    </div>
                    <div class="col-xs-6">
                        <asp:Label ID="lbFullname" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Giới tính: </label>
                    </div>
                    <div class="col-xs-6">
                        <asp:Label ID="lbGender" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Ngày sinh: </label>
                    </div>
                    <div class="col-xs-6">
                        <asp:Label ID="lbDOBYOB" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Địa chỉ: </label>
                    </div>
                    <div class="col-xs-6">
                        <asp:Label ID="lbAddressLine" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Điện thoại: </label>
                    </div>
                    <div class="col-xs-6">
                        <asp:Label ID="lbMobilePhone" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Email: </label>
                    </div>
                    <div class="col-xs-6">
                        <asp:Label ID="lbEmail" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Nơi điều trị: </label>
                    </div>
                    <div class="col-xs-6">
                        <asp:Label ID="lbPlaceName" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-xs-12 col-sm-12 col-md-6 col-lg-6 ">
            <div class="form-horizontal">
                <div class="form-group">
                    <h4>Thông tin thẻ</h4>
                </div>
            </div>
            <div class="form-horizontal">
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Họ và tên:</label>
                    </div>
                    <div class="col-xs-6">
                        <label>Fullname</label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Giới tính: </label>
                    </div>
                    <div class="col-xs-6">
                        <label>Description (tblGender)</label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Ngày sinh: </label>
                    </div>
                    <div class="col-xs-6">
                        <label>DOB + YOB</label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Địa chỉ: </label>
                    </div>
                    <div class="col-xs-6">
                        <label>AddressLine1+AddressLine2</label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Điện thoại: </label>
                    </div>
                    <div class="col-xs-6">
                        <label>MobilePhone</label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Email: </label>
                    </div>
                    <div class="col-xs-6">
                        <label>Email</label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Nơi điều trị: </label>
                    </div>
                    <div class="col-xs-6">
                        <label>PlaceName</label>
                    </div>
                </div>
            </div>

        </div>
    </div>
</asp:Content>

