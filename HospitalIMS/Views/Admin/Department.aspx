<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="HospitalIMS.Views.Admin.Department" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            display: block;
            width: 100%;
            font-size: 1rem;
            font-weight: 400;
            line-height: 1.5;
            color: #212529;
            background-clip: padding-box;
            -webkit-appearance: none;
            -moz-appearance: none;
            appearance: none;
            border-radius: .375rem;
            transition: none;
            height: 115px;
            border: 1px solid #ced4da;
            background-color: #fff;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-2">
                <h2>Department</h2>
                <form runat="server">
                    <asp:Button ID="DeptList" runat="server" Class="btn btn-danger" Text="Department List" OnClick="DeptList_Click" />
                    <div class="mb-3">
                        <br />
                        <label for="DeptNameTb" class="form-label">Department Name</label>
                        <input type="text" class="form-control" id="DeptNameTb" runat="server" />
                    </div>

                    <div class="mb-3">
                        <label for="DescriptionTb" class="form-label">Description</label>
                        <input type="text" class="form-control" id="DescriptionTb" runat="server" />
                    </div>

                    <div class="mb-3">
                        <label for="StatusTb" class="form-label">status</label>
                        <asp:CheckBoxList ID="StatusTb" runat="server">
                            <asp:ListItem>Active</asp:ListItem>
                            <asp:ListItem>Inctive</asp:ListItem>
                        </asp:CheckBoxList>
                    </div>


                    <label runat="server" id="ErrMsg" class="text-danger">
                    </label>
                    <br />
                    <asp:Button ID="AddBtn" runat="server" Text="Save" class="btn btn-primary" OnClick="AddBtn_Click" />
            </div>
        </div>
    </div>
    </form>
</asp:Content>
