<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Lab04.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Nome: "></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>

        <asp:RequiredFieldValidator ID="vldUserName" runat="server" 
            ControlToValidate="txtUserName" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>

        <br />
        <asp:Label ID="Label2" runat="server" Text="Senha:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        
        <asp:RequiredFieldValidator ID="vldUserPassword" runat="server" 
            ControlToValidate="txtPassword" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        
        <br />
        <br />
        <asp:Button ID="BTEntrar" runat="server" Text="Entrar" 
            onclick="BTEntrar_Click" />
        <asp:Button ID="butAddUser" runat="server" Text="Nvo User" 
            onclick="butAddUser_Click" Visible="False" />
        <br />
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
