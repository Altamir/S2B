<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DemoValidacao.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Nome: "></asp:Label>
        <asp:TextBox ID="TBNome"
            runat="server" MaxLength="10"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TBNome" ErrorMessage="Nome é Obrigatorio" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
        <asp:Label ID="Label2" runat="server" Text="Idade:  "></asp:Label>
        <asp:TextBox ID="TBIdade"
            runat="server" TextMode="Number"></asp:TextBox>
            <br />
        <asp:Button ID="Button1" runat="server" Text="Enviar" onclick="Button1_Click" /><br />
            <asp:Label ID="LbResultado" runat="server"></asp:Label>
    </div>
    </form>
        
</body>
</html>
