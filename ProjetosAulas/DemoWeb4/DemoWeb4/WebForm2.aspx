﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="DemoWeb4.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDLEstados" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDLEstados_SelectedIndexChanged">            
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="BtEnviar" runat="server" Text="Enviar" 
            onclick="BtEnviar_Click" />
        <br />
        <br />
        <asp:Label ID="LbEstado" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
