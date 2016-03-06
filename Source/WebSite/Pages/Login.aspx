<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Login.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="clhContent" runat="Server">
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4">
            <section class="login-form">
                <div class="formlogin">
                    <div class="page-header">
                        <h2>Đăng nhập</h2>
                    </div>
                    <asp:TextBox ID="txtUserName" placeholder="Nhập Card ID hoặc Email" class="form-control input-lg" runat="server"></asp:TextBox>
                    <small class="help-block">
                        <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ErrorMessage="Vui lòng Card ID hoặc Email" ValidationGroup="Data" ControlToValidate="txtUserName" CssClass="help-block" Display="Dynamic" ForeColor="#C10841"></asp:RequiredFieldValidator>
                    </small>
                    <asp:TextBox ID="txtPassword" placeholder="Nhập Access Code" class="form-control input-lg" ValidationGroup="Data" runat="server"></asp:TextBox>
                    <small class="help-block">
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Vui lòng nhập Access Code" ValidationGroup="Data" ControlToValidate="txtPassword" CssClass="help-block" Display="Dynamic" ForeColor="#C10841"></asp:RequiredFieldValidator>
                    </small>
                    <div>
                        Quên mật khẩu? Nhấn vào <a href="/quen-mat-khau.html">đây</a>
                    </div>
                    <asp:Button ID="btnLogin" class="btn btn-lg btn-info btn-block" runat="server" ValidationGroup="Data" Text="Đăng Nhập" OnClick="btnLogin_Click" />
                </div>
                <div class="form-links">
                    <a href="#"><%=HttpContext.Current.Request.Url.AbsoluteUri.ToString()%></a>
                </div>
            </section>
        </div>
        <div class="col-md-4"></div>
    </div>

</asp:Content>

