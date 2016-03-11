<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Pages_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="clhContent" runat="Server">
    <div class="row">
        <div class="col-xs-12 col-sm-12 col-md-6 col-lg-6">
            <div class="form-horizontal">
                <div class="form-group">
                    <div class="col-xs-6">
                        <h4 style="color:#2d5c8a">Thông tin cá nhân</h4>
                    </div>
                    <div class="col-xs-6">
                        <a class="col-xs-5  btn btn-primary" href="/cap-nhat-thong-tin.html">Chỉnh sửa</a>
                    </div>
                </div>
            </div>
            <div class="form-horizontal text-center">
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Họ và tên:</label>
                    </div>
                    <div class="col-xs-6 text-left">
                        <asp:Label ID="lbFullname" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Giới tính: </label>
                    </div>
                    <div class="col-xs-6 text-left">
                        <asp:Label ID="lbGender" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Ngày sinh: </label>
                    </div>
                    <div class="col-xs-6 text-left">
                        <asp:Label ID="lbDOBYOB" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Địa chỉ: </label>
                    </div>
                    <div class="col-xs-6 text-left">
                        <asp:Label ID="lbAddressLine" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Điện thoại: </label>
                    </div>
                    <div class="col-xs-6 text-left">
                        <asp:Label ID="lbMobilePhone" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Email: </label>
                    </div> 
                    <div class="col-xs-6 text-left">
                        <asp:Label ID="lbEmail" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Nơi điều trị: </label>
                    </div>
                    <div class="col-xs-6 text-left">
                        <asp:Label ID="lbPlaceName" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-xs-12 col-sm-12 col-md-6 col-lg-6 ">
            <div class="form-horizontal">
                <div class="form-group">
                    <h4 style="color:#2d5c8a">Thông tin thẻ</h4>
                </div>
            </div>
            <div class="form-horizontal text-center">
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Mã thẻ:</label>
                    </div>
                    <div class="col-xs-6 text-left">
                        <asp:Label ID="lbCard_ID" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Loại thẻ: </label>
                    </div>
                    <div class="col-xs-6 text-left">
                        <asp:Label ID="lbCardType_ID" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Ngày cấp thẻ: </label>
                    </div>
                    <div class="col-xs-6 text-left">
                        <asp:Label ID="lbIssueDate" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Ngày hết hạn: </label>
                    </div>
                    <div class="col-xs-6 text-left">
                        <asp:Label ID="lbExpDate" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Tình trạng thẻ: </label>
                    </div>
                    <div class="col-xs-6 text-left">
                        <asp:Label ID="lbStatus_ID" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Số điểm tích lũy: </label>
                    </div>
                    <div class="col-xs-6 text-left">
                        <asp:Label ID="lbTotalPoint" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-6">
                        <label>Giao dịch điểm: </label>
                    </div>
                    <div class="col-xs-6 text-left">
                        <a href="/chi-riet-giao-dich-diem.html">Xem chi tiết</a>
                    </div>
                </div>
            </div>

        </div>
    </div>
</asp:Content>

