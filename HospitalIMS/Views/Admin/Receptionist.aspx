<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Receptionist.aspx.cs" Inherits="HospitalIMS.Views.Admin.Receptionist" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h2>Receptionist Detail</h2>
                <form runat="server">
                    <div class="mb-3">
                        <label for="RecNameTb" class="form-label">Name</label>
                        <input type="text" class="form-control" id="RecNameTb" runat="server" required="required" />
                    </div>
                    <div class="mb-3">
                        <label for="RecEmailTb" class="form-label">Email</label>
                        <input type="email" class="form-control" id="RecEmailTb" runat="server" required="required" />
                    </div>
                    <div class="mb-3">
                        <label for="RecAddressTb" class="form-label">Address</label>
                        <input type="text" class="form-control" id="RecAddressTb" runat="server" required="required" />
                    </div>
                    <div class="mb-3">
                        <label for="RecPhoneTb" class="form-label">Phone</label>
                        <input type="text" class="form-control" id="RecPhoneTb" runat="server" required="required" />
                    </div>

                    <div class="mb-3">
                        <label for="RecPasswordT" class="form-label">Password</label>
                        <input type="text" class="form-control" id="RecPasswordT" runat="server" required="required" />
                    </div>
                    <label runat="server" id="ErrMsg" class="text-danger">
                    </label>
                    <br />
                    <asp:Button ID="EditBtn" runat="server" Text="Edit" class="btn btn-warning" OnClick="EditBtn_Click" />
                    <asp:Button ID="AddBtn" runat="server" Text="Save" class="btn btn-primary" OnClick="AddBtn_Click" />
                    <asp:Button ID="DeleteBtn" runat="server" Text="Delete" class="btn btn-danger" OnClick="DeleteBtn_Click" />
            </div>
            <%--<form runat="server">--%>
            <div class="col-md-8">
                
                <div class="row">
                    <div class="col">
                        <h1>Receptionist Details</h1>
                        <asp:GridView ID="ReceptionistGV" class="table table-hover" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" AutoGenerateSelectButton="True" OnSelectedIndexChanged="ReceptionistGV_SelectedIndexChanged" AllowPaging="true" OnPageIndexChanging="OnPageIndexChanging" PageSize="10">
                             <AlternatingRowStyle BackColor="#F7F7F7" />
                            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                            <SortedAscendingCellStyle BackColor="#F4F4FD" />
                            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                            <SortedDescendingCellStyle BackColor="#D8D8F0" />
                            <SortedDescendingHeaderStyle BackColor="#3E3277" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
            <%--</form>--%>
        </div>
    </div>
    </form>

</asp:Content>
