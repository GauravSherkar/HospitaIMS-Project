<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Laboratorians.aspx.cs" Inherits="HospitalIMS.Views.Admin.Laboratorians" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h2>Laboratorian Detail</h2>
                <form runat="server">
                    <div class="mb-3">
                        <label for="NameTb" class="form-label">Name</label>
                        <input type="text" class="form-control" id="NameTb" runat="server" required="required" />
                    </div>
                    <div class="mb-3">
                        <label for="EmailTb" class="form-label">Email</label>
                        <input type="text" class="form-control" id="EmailTb" runat="server" required="required"/>
                    </div>
                     <div class="mb-3">
                        <label for="PasswordTb" class="form-label">Password</label>
                        <input type="text" class="form-control" id="PasswordTb" runat="server" required="required"/>
                    </div>  
                    <div class="mb-3">
                        <label for="PhoneTb" class="form-label">Phone</label>
                        <input type="number" class="form-control" id="PhoneTb" runat="server" required="required"/>
                    </div>

                    <div class="mb-3">
                        <label for="AddressTb" class="form-label">Address</label>
                        <input type="text" class="form-control" id="AddressTb" runat="server" required="required"/>
                    </div>
                    <div class="mb-3">
                        <label for="GenderTb" class="form-label">Gender</label>
                      <asp:DropDownList id="GenderTb" Class="form-control" runat="server" >
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                      </asp:DropDownList>
                    </div>
                   
                     <label runat="server" id="ErrMsg" class="text-danger">
                    </label>
                    <br />
                    <asp:Button ID="EditBtn" runat="server" Text="Edit" class="btn btn-warning" OnClick="EditBtn_Click" />
                    <asp:Button ID="AddBtn" runat="server" Text="Save" class="btn btn-primary" OnClick="AddBtn_Click" />
                    <asp:Button ID="DeleteBtn" runat="server" Text="Delete" class="btn btn-danger" OnClick="DeleteBtn_Click" />
                                      
            </div>
            <div class="col-md-8">
              <%--  <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/labs.jpg" height="450px" width="1000px" class="rounded-3" />
                    </div>
                </div>--%>
                <div class="row">
                    <div class="col">
                        <h1 style="text-align:center">Laboratorian Details</h1>
                        <asp:GridView ID="LabGV" class="table table-hover" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="LabGV_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanging="OnPageIndexChanging" PageSize="10">
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
          
        </div>
    </div>
    </form>
</asp:Content>
