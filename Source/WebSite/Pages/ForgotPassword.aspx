<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Login.master" AutoEventWireup="true" CodeFile="ForgotPassword.aspx.cs" Inherits="Pages_ForgotPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="clhContent" runat="Server">
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4">
            <section class="login-form">
                <div class="formlogin">
                    <div class="page-header">
                        <h2>Quên mật khẩu ?</h2>
                    </div>
                    <label>Vui lòng nhập email hoặc mã thẻ, chúng tôi sẽ khởi tạo mật khẩu mới qua email của bạn</label>
                    <asp:TextBox ID="txtUserName" placeholder="Nhập Card ID hoặc Email" class="form-control input-lg" runat="server"></asp:TextBox>
                    <asp:Button ID="btnSend" class="btn btn-lg btn-info btn-block" runat="server" Text="Gửi" />
                </div>
                <div class="form-links">
                    <a href="#"><%=HttpContext.Current.Request.Url.AbsoluteUri.ToString()%></a>
                </div>
            </section>
        </div>
        <div class="col-md-4"></div>
    </div>
</asp:Content>

