<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="ServiceTransaction.aspx.cs" Inherits="Pages_ServiceTransaction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="clhContent" runat="Server">
    <div class="row">
        <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12 text-center">
            <asp:GridView ID="gvData" runat="server" CssClass="table table-hover table-striped table-bordered" GridLines="None" AutoGenerateColumns="False" HeaderStyle-CssClass="text-center">
                <Columns>
                    <asp:BoundField DataField="STT" HeaderText="STT" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-left" />
                    <asp:BoundField DataField="ServiceDate" HeaderText="Ngày giao dịch" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-left" DataFormatString="{0:dd/MM/yyyy}" />
                    <asp:BoundField DataField="PlaceName" HeaderText="Dịch vụ sử dụng" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-left" />
                    <asp:BoundField DataField="Increase_Decrease" HeaderText="Loại giao dịch" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-left" />
                    <asp:BoundField DataField="PointRec" HeaderText="Điểm tích lũy" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-right" DataFormatString="{0:N0}" />
                </Columns>
                <HeaderStyle CssClass="text-center" />
                <RowStyle CssClass="cursor-pointer" />
                <PagerStyle CssClass="pagination-ys" />
            </asp:GridView>
        </div>
    </div>


</asp:Content>

