<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Laboratorian/LaboratorianMaster.Master" AutoEventWireup="true" CodeBehind="LabTest.aspx.cs" Inherits="HospitalIMS.Views.Laboratorian.LabTest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">

    <div class="container-fluid" style="background-image: url('labbs.jpg')">


        <div class="row" style="height: 30px"></div>
        <div class="row">
            <div class="col-md-4">
                <h2>Laboratory Test Detail</h2>
                <form runat="server">
                     <div class="mb-3">
                            <label for="Patientcb" class="form-label">Patient</label>
                            <asp:DropDownList ID="Patientcb" Class="form-control" runat="server"></asp:DropDownList>
                        </div>
                    <div class="mb-3">
                        
                        <label for="NameTb" class="form-label">Test Name</label>
                        <input type="text" class="form-control" id="NameTb" runat="server" required="required" />
                    </div>
                   
                    <div class="mb-3">
                        <label for="TestCostTb" class="form-label">Test Cost</label>
                        <input type="number" class="form-control" id="TestCostTb" runat="server" required="required" />
                    </div>

                    <%--<div class="row" style="height:100px"></div>--%>
                    <label runat="server" id="ErrMsg" class="text-danger">
                    </label>
                    <br />
                    <asp:Button ID="EditBtn" runat="server" Text=" Edit " class="btn btn-warning" OnClick="EditBtn_Click" />
                    <asp:Button ID="AddBtn" runat="server" Text=" Save " class="btn btn-primary" OnClick="AddBtn_Click" />
                    <asp:Button ID="DeleteBtn" runat="server" Text=" Delete " class="btn btn-danger" OnClick="DeleteBtn_Click" />
            </div>
            <%--<form runat="server">--%>
            <%--  <div class="col-md-8">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/labbs.jpg" height="400px" width="1000px" class="rounded-3" />
                    </div>
                </div>--%>
            <div class="row">
                <div class="col">
                    <h1 style="text-align: center">Lab Test Details</h1>
                    <asp:GridView ID="LabTestGV" class="table table-hover" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="LabTestGV_SelectedIndexChanged" AllowPaging="true" OnPageIndexChanging="OnPageIndexChanging" PageSize="10">
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
        <%--</form>--%>
    </div>
    </div>
    </form>

</asp:Content>
