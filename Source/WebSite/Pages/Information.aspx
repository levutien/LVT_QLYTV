<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="Information.aspx.cs" Inherits="Pages_Information" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="clhContent" runat="Server">
    <div class="row">
        <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
            <div class="form-horizontal">
                <div class="form-group">
                    <div class=" col-xs-12 col-sm-12 col-md-offset-3 col-md-6 col-ld-offset-3 col- col-lg-6 text-center">
                        <h2>Cập nhật thông tin</h2>
                    </div>
                </div>
            </div>
            <div class=" col-xs-12 col-sm-12 col-md-offset-2 col-md-8 col-ld-offset-2 col- col-lg-8">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label class="col-xs-2 control-label">Họ và tên:</label>
                        <div class="col-xs-10">
                            <div class="col-xs-12">
                                <asp:TextBox ID="txtFullName" CssClass="form-control" runat="server"></asp:TextBox>
                                <small class="help-block">
                                    <asp:RequiredFieldValidator ID="rfvFullName" runat="server" ErrorMessage=" Vui lòng nhập họ và tên." ValidationGroup="Data" ControlToValidate="txtFullName" CssClass="help-block" Display="Dynamic" ForeColor="#C10841"></asp:RequiredFieldValidator>
                                </small>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-xs-2 control-label">Giới tính: </label>
                        <div class="col-xs-10">
                            <div class="col-xs-12">
                                <asp:DropDownList ID="ddlGender_ID" CssClass="form-control" runat="server"></asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-xs-2 control-label">Ngày sinh: </label>
                        <div class="col-xs-10 text-left">
                            <div class="col-xs-3">
                                <asp:DropDownList ID="ddlDay" CssClass="form-control" runat="server"></asp:DropDownList>
                            </div>
                            <div class="col-xs-3">
                                <asp:DropDownList ID="ddlMonth" CssClass="form-control" runat="server"></asp:DropDownList>
                            </div>
                            <div class="col-xs-3">
                                <asp:DropDownList ID="ddlYear" CssClass="form-control" runat="server"></asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-xs-2 control-label">Địa chỉ:</label>
                        <div class="col-xs-10">
                            <div class="col-xs-6">
                                <asp:TextBox ID="txtAddressLine1" CssClass="form-control" placeholder="Số nhà + đường + phường xã, tổ ấp" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-xs-6">
                                <asp:TextBox ID="txtAddressLine2" CssClass="form-control" placeholder="Quận huyện + Thành phố, tỉnh" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-xs-2 control-label">Điện thoại:</label>
                        <div class="col-xs-10">
                            <div class="col-xs-12">
                                <asp:TextBox ID="txtMobilePhone" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-xs-2 control-label">Email:</label>
                        <div class="col-xs-10">
                            <div class="col-xs-12">
                                <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-xs-2 control-label">Nơi điều trị:</label>
                        <div class="col-xs-10">
                            <div class="col-xs-12">

                                <asp:Label ID="lbEMRPlace_ID" runat="server" CssClass="form-control" BackColor="Menu" Text=""></asp:Label>
                            </div>
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
                            <div class="col-xs-6">
                                <asp:Button ID="btnUpdate" class="btn btn-lg btn-info btn-block" runat="server" ValidationGroup="Data" Text="Lưu lại" OnClick="btnUpdate_Click" />
                            </div>
                            <div class="col-xs-6">
                                <asp:Button ID="btnCancel" class="btn btn-lg btn-info btn-block" runat="server" ValidationGroup="Data" Text="Hủy" OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>


