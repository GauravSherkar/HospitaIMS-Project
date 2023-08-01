<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Doctors/DoctorMaster.Master" AutoEventWireup="true" CodeBehind="Prescriptions.aspx.cs" Inherits="HospitalIMS.Views.Doctors.Prescriptions"  EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
     <div class="container-fluid">
        <div class="row">
            <div class="col-md-2">
                <h2>Doctors Prescriptions Details</h2>
              
                <form runat="server">
                 <asp:Button id="DeptList" type="submit" runat="server" Class="btn btn-danger" Text="Precscription List" OnClick="DeptList_Click"  />

                     <div class="mb-3">
                        <label for="DocNameTb" class="form-label">Doctor</label>
                        <asp:DropDownList id="DocNameTb" Class="form-control" runat="server"></asp:DropDownList>
                    </div> 
                    <div class="mb-3">
                        <label for="Patientcb" class="form-label">Patient</label>
                        <asp:DropDownList id="Patientcb" Class="form-control" runat="server"></asp:DropDownList>
                    </div> 
                      
                     <div class="mb-3">
                        <label for="MedicineTb" class="form-label">Medicines</label>
                        <input type="text" class="form-control" id="MedicineTb" runat="server"/>
                    </div>
                    
                    <div class="mb-3">
                        <label for="Testcb" class="form-label">Lab Test</label>
                        <asp:DropDownList id="Testcb" Class="form-control" runat="server" ></asp:DropDownList> 
                    </div>

                    <div class="mb-3">
                        <label for="CostTb" class="form-label">Cost</label>
                        <input type="text" class="form-control" id="CostTb" runat="server" />
                    </div>                               
                                                       
                    <label runat="server" id="ErrMsg" class="text-danger">
                    </label>
                    <br />
                    <asp:Button ID="AddBtn" runat="server" Text="Save" class="btn btn-warning" width="190px" OnClick="AddBtn_Click"   />
                                      
            </div>
           <%-- <div class="col-md-8">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/labs.jpg" height="450px" width="1000px" class="rounded-3" />
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <h1>Patients Details</h1>
                        <asp:GridView ID="PresGV" class="table table-hover" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None"   >
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
                </div>--%>
            </div>
        </div>
    </div>
    </form>
</asp:Content>
