<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="DemoBD2.WebForm3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
Moedas:

    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListView1" runat="server" DataSourceID="EntityDataSource1">
            <AlternatingItemTemplate>
                <span style="">Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                <br />
                CurrencyCode:
                <asp:Label ID="CurrencyCodeLabel" runat="server" 
                    Text='<%# Eval("CurrencyCode") %>' />
                <br />
                <br />
                </span>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <span style="">Name:
                <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                <br />
                CurrencyCode:
                <asp:TextBox ID="CurrencyCodeTextBox" runat="server" 
                    Text='<%# Bind("CurrencyCode") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" 
                    Text="Update" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                    Text="Cancel" />
                <br />
                <br />
                </span>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <span>No data was returned.</span>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <span style="">Name:
                <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                <br />
                CurrencyCode:
                <asp:TextBox ID="CurrencyCodeTextBox" runat="server" 
                    Text='<%# Bind("CurrencyCode") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" 
                    Text="Insert" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                    Text="Clear" />
                <br />
                <br />
                </span>
            </InsertItemTemplate>
            <ItemTemplate>
                <span style="">Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                <br />
                CurrencyCode:
                <asp:Label ID="CurrencyCodeLabel" runat="server" 
                    Text='<%# Eval("CurrencyCode") %>' />
                <br />
                <br />
                </span>
            </ItemTemplate>
            <LayoutTemplate>
                <div ID="itemPlaceholderContainer" runat="server" style="">
                    <span runat="server" id="itemPlaceholder" />
                </div>
                <div style="">
                </div>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <span style="">Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                <br />
                CurrencyCode:
                <asp:Label ID="CurrencyCodeLabel" runat="server" 
                    Text='<%# Eval("CurrencyCode") %>' />
                <br />
                <br />
                </span>
            </SelectedItemTemplate>
        
        </asp:ListView>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" 
            ConnectionString="name=AdventureWorks2008_DataEntities" 
            DefaultContainerName="AdventureWorks2008_DataEntities" EnableFlattening="False" 
            EntitySetName="Currencies" Select="it.[Name], it.[CurrencyCode]" 
            EntityTypeFilter="Currency">
            
        </asp:EntityDataSource>
    </div>
    </form>
</body>
</html>
