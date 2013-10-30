<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="DemoBD2.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label2" runat="server" Text="Codigo : "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="184px"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nome:    "></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="181px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Pais:    "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" 
            DataSourceID="EntityDataSource1" DataTextField="CountryRegionCode" 
            DataValueField="CountryRegionCode">
        </asp:DropDownList>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Enviar" onclick="Button1_Click" />
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" 
            ConnectionString="name=AdventureWorks2008_DataEntities" 
            DefaultContainerName="AdventureWorks2008_DataEntities" EnableFlattening="False" 
            EntitySetName="CountryRegionCurrencies" 
            EntityTypeFilter="CountryRegionCurrency" Select="it.[CountryRegionCode]">
        </asp:EntityDataSource>
    </div>
    </form>
</body>
</html>
