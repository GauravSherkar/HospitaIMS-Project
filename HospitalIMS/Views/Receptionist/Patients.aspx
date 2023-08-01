<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Receptionist/ReceptionistMaster.Master" AutoEventWireup="true" CodeBehind="Patients.aspx.cs" Inherits="HospitalIMS.Views.Receptionist.Patients" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h2>Patient Details</h2>
                <form runat="server">
                    <div class="mb-3">
                        <label for="NameTb" class="form-label">Patient Name</label>
                        <input type="text" class="form-control" id="NameTb" runat="server" required="required" />
                    </div>

                     <div class="mb-3">
                        <label for="PhoneTb" class="form-label">Phone</label>
                        <input type="number" class="form-control" id="PhoneTb" runat="server" required="required"/>
                    </div>

                      <div class="mb-3">
                        <label for="GenderTb" class="form-label">Gender</label>
                      <asp:DropDownList id="GenderTb" Class="form-control" runat="server" >
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                      </asp:DropDownList>
                    </div>

                     <div class="mb-3">
                        <label for="DOBTb" class="form-label">Date Of Birth</label>
                        <input type="date" class="form-control" id="DOBTb" runat="server"/>
                    </div>
                    
                    <div class="mb-3">
                        <label for="AddressTb" class="form-label">Address</label>
                        <input type="text" class="form-control" id="AddressTb" runat="server" required="required"/>
                    </div>

                    <div class="mb-3">
                        <label for="AllergyTb" class="form-label">Patient Allergies</label>
                        <input type="text" class="form-control" id="AllergyTb" runat="server" required="required"/>
                    </div>              

                  
                   
                    <label runat="server" id="ErrMsg" class="text-danger">
                    </label>
                    <br />
                    <asp:Button ID="EditBtn" runat="server" Text="Edit" class="btn btn-warning" OnClick="EditBtn_Click" />
                    <asp:Button ID="AddBtn" runat="server" Text="Save" class="btn btn-primary" OnClick="AddBtn_Click"  />
                    <asp:Button ID="DeleteBtn" runat="server" Text="Delete" class="btn btn-danger" OnClick="DeleteBtn_Click" />
                                      
            </div>
            <div class="col-md-8">
               <%-- <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/labs.jpg" height="450px" width="1000px" class="rounded-3" />
                    </div>
                </div>--%>
                <div class="row">
                    <div class="col">
                        <h1>Patients Details</h1>
                        <asp:GridView ID="PatGV" class="table table-hover" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="OnSelectedIndexChanged"   AllowPaging="true"  PageSize="10" OnPageIndexChanging="OnPageIndexChanging">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#E3EAEB" />
                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F8FAFA" />
                            <SortedAscendingHeaderStyle BackColor="#246B61" />
                            <SortedDescendingCellStyle BackColor="#D4DFE1" />
                            <SortedDescendingHeaderStyle BackColor="#15524A" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</asp:Content>
