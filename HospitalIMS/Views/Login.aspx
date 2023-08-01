<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HospitalIMS.Views.Login" EnableEventValidation="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Libs/Bootstrap/css/bootstrap.min.css" />
    <link rel="stylesheet" href="../CSS/Login.css" />
</head>
<body style="background-image: url('/Assets/Images/beds.jpg'); background-size:cover">
    <div class="container-fluid">
        <div class="row" style="height: 120px">
        </div>
        <div class="row">
            <div class="col-md-4"></div>
            <div class="col-md-4 S">
                <h1 class="T">Hospital Management System</h1>
                <form id="form1" runat="server">
                    <div class="mb-3">
                        <label for="Emailtb" class="form-label">Email address</label>
                        <input type="email" class="form-control" id="Emailtb" placeholder="Email id" aria-describedby="emailHelp" runat="server" />
                    </div>
                    <div class="mb-3">
                        <label for="PasswordTb" class="form-label">Password</label>
                        <input type="password" class="form-control" placeholder="Password" id="passwordTb" runat="server" />
                    </div>
                    <div class="mb-3 form-check">
                        <asp:DropDownList ID="Rolecb" class="form-control" runat="server" runat="server" >
                            <asp:ListItem>--Select User Role--</asp:ListItem>
                            <asp:ListItem>Admin</asp:ListItem>
                            <asp:ListItem>Doctor</asp:ListItem>
                            <asp:ListItem>Receptionist</asp:ListItem>
                            <asp:ListItem>Laboratorian</asp:ListItem>
                            <asp:ListItem>nurse</asp:ListItem>
                            <asp:ListItem>pharmacist</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="d-grid">
                        <label runat="server" id="ErrMsg" class="text-danger"></label>                
                        <asp:Button ID="EditBtn" runat="server" Text="Login"  class="btn btn-primary btn-block" OnClick="EditBtn_Click"/>
                    </div>
                    <b>
                        <div>
                            <br />
                            <br />
                            UserName Admin@gmail.com
                            <br />
                            Password Admin
                        </div>
                    </b>
                    
                    
                </form>
                <div class="row" style="height:10px">

            </div>
            </div>
        </div>
        <div class="col-md-3">
           
        </div>
    </div>
</body>
</html>
