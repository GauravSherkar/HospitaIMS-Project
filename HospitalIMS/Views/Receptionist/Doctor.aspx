<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Receptionist/ReceptionistMaster.Master" AutoEventWireup="true" CodeBehind="Doctor.aspx.cs" Inherits="HospitalIMS.Views.Receptionist.Doctor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
     <form runat="server">
        <div class="row">
            <div class="col">
                <h1>DashBoard Doctor</h1>
               
                <h3>Doctors Details</h3>
                <asp:GridView ID="DoctorGV" class="table table-hover" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="true" OnPageIndexChanging="OnPageIndexChanging" PageSize="10">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </div>
        </div>
    </form>
</asp:Content>
