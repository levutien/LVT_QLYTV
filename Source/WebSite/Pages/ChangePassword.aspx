<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="Pages_ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="clhContent" runat="Server">
    <div class="row">
        <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
            <div class="form-horizontal">
                <div class="form-group">
                    <div class=" col-xs-12 col-sm-12 col-md-offset-3 col-md-6 col-ld-offset-3 col- col-lg-6 text-center">
                        <h2>Đổi mật khẩu</h2>
                    </div>
                </div>
            </div>
            <div class=" col-xs-12 col-sm-12 col-md-offset-3 col-md-6 col-ld-offset-3 col- col-lg-6">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-xs-6 control-label">Mật khẩu cũ:</label>
                        <div class="col-xs-6">
                            <asp:TextBox ID="txtAccessCodeOld" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
                            <small class="help-block">
                                <asp:RequiredFieldValidator ID="rfvAccessCodeOld" runat="server" ErrorMessage=" Vui lòng nhập mật khẩu cũ." ValidationGroup="Data" ControlToValidate="txtAccessCodeOld" CssClass="help-block" Display="Dynamic" ForeColor="#C10841"></asp:RequiredFieldValidator>
                            </small>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-xs-6 control-label">Mật khẩu mới: </label>
                        <div class="col-xs-6">
                            <asp:TextBox ID="txtAccessCodeNew" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
                            <small class="help-block">
                                <asp:RequiredFieldValidator ID="rfvAccessCodeNew" runat="server" ErrorMessage=" Vui lòng nhập mật khẩu mới." ValidationGroup="Data" ControlToValidate="txtAccessCodeNew" CssClass="help-block" Display="Dynamic" ForeColor="#C10841"></asp:RequiredFieldValidator>
                            </small>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-xs-6 control-label">Nhập lại mật khẩu mới:</label>
                        <div class="col-xs-6">
                            <asp:TextBox ID="txtAccessCodeConfirm" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
                            <small class="help-block">
                                <asp:RequiredFieldValidator ID="rfvAccessCodeConfirm" runat="server" ErrorMessage=" Vui lòng nhập lại mật khẩu mới." ValidationGroup="Data" ControlToValidate="txtAccessCodeConfirm" CssClass="help-block" Display="Dynamic" ForeColor="#C10841"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="cvAccessCodeConfirm" ControlToValidate="txtAccessCodeNew" runat="server" ErrorMessage="Mật khẩu nhập lại không đúng" CssClass="help-block" Display="Dynamic" ForeColor="#C10841" ControlToCompare="txtAccessCodeConfirm" ValidationGroup="Data"></asp:CompareValidator>
                            </small>

                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-xs-offset-3 col-xs-6 text-center">
                            <small class="help-success">
                                <asp:Label ID="lbSuccess" runat="server" CssClass="label label-success" Text=""></asp:Label>
                            </small>
                            <small class="has-success">
                                <asp:Label ID="lbError" runat="server" CssClass="label label-danger" Text=""></asp:Label>
                            </small>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-xs-offset-3 col-xs-6">
                            <asp:Button ID="btnChange" class="btn btn-lg btn-info btn-block" runat="server" ValidationGroup="Data" Text="Đổi mật khẩu" OnClick="btnChange_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
