<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Doctors.aspx.cs" Inherits="HospitalIMS.Views.Admin.Doctors" enableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h2>Doctors Detail</h2>
                   <form runat="server">
                    <div class="mb-3">
                        <label for="DocNameTb" class="form-label">Doctor Name</label>
                        <input type="text" class="form-control" id="DocNameTb" runat="server" required="required" />
                    </div>

                    <div class="mb-3">
                        <label for="DocPhoneTb" class="form-label">Phone number</label>
                        <input type="text" class="form-control" id="DocPhoneTb" runat="server" required="required" />
                    </div>

                    <div class="mb-3">
                        <label for="DocExpTb" class="form-label">Experience</label>
                        <input type="text" class="form-control" id="DocExpTb" runat="server" required="required" />
                    </div>

                    <div class="mb-3">
                        <label for="SpecilisationTb" class="form-label">Specilisation</label>
                        <input type="text" class="form-control" id="SpecilisationTb" runat="server" required="required" />
                    </div>
                   

                    <div class="mb-3">
                        <label for="GenderTb" class="form-label">Gender</label>
                        <asp:DropDownList id="GenderTb" runat="server" class="form-control" required="required">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                    </div>               
                        

                    <div class="mb-3">
                        <label for="AddressTb" class="form-label">Address</label>
                        <input type="text" class="form-control" id="AddressTb" runat="server" required="required" />
                    </div>

                    <div class="mb-3">
                        <label for="DOBTb" class="form-label">Date Of Birth</label>
                        <input type="date" class="form-control" id="DOBTb" runat="server" />
                    </div>
                       <div class="mb-3">
                           <label for="Password" class="form-label">Password</label>
                           <input type="text" class="form-control" id="Password" runat="server" required="required" />
                       </div>
                        <div class="mb-3">
                        <label for="EmailTb" class="form-label">Email</label>
                        <input type="email" class="form-control" id="EmailTb" runat="server" required="required" />
                    </div>

                    <label runat="server" id="ErrMsg" class="text-danger">
                        
                    </label><br />
                        <asp:Button ID="EditBtn" runat="server" Text="Edit" class="btn btn-warning" OnClick="EditBtn_Click" />
                        <asp:Button ID="AddBtn" runat="server" Text="Save" class="btn btn-primary" OnClick="AddBtn_Click" />
                        <asp:Button ID="DeleteBtn" runat="server" Text="Delete" class="btn btn-danger" OnClick="DeleteBtn_Click"/>
                </div>

            <div class="col-md-8" >
               <%-- <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/Doctor.jpg" height="450px" width="1000px" class="rounded-3" />
                    </div>
                </div>--%>
                <div class="row">
                    <div class="col">
                        <h1 style="text-align:center">Doctors Details</h1>                   
                       
                      
                        <asp:GridView ID="DoctorGV" class="table table-hover" runat="server" BackColor="White" CellPadding="3" BorderStyle="None" OnSelectedIndexChanged="DoctorGV_SelectedIndexChanged" BorderWidth="1px" ForeColor="#333333" GridLines="Horizontal" AutoGenerateSelectButton="True" AllowPaging="True" OnPageIndexChanging="OnPageIndexChanging" PageSize="10">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                    </div>
                </div>
            </div>
           
        </div>
      </div>
    </form>
</asp:Content>







