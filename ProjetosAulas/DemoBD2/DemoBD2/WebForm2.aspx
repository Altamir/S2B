<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="DemoBD2.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" 
            ConnectionString="name=AdventureWorks2008_DataEntities1" 
            DefaultContainerName="AdventureWorks2008_DataEntities1" 
            EnableFlattening="False" EntitySetName="CountryRegionCurrencies">
        </asp:EntityDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="EntityDataSource1">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
