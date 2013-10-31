<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DemoAjax.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 196px;
            width: 587px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </ajaxToolkit:ToolkitScriptManager>
        <asp:TextBox ID="TextBox1" runat="server" Columns="50" Rows="15" TextMode="MultiLine" Width="594px"></asp:TextBox>
        <ajaxToolkit:HtmlEditorExtender ID="TextBox1_HtmlEditorExtender" runat="server" Enabled="True" EnableSanitization="False" TargetControlID="TextBox1">
        </ajaxToolkit:HtmlEditorExtender>
    </div>
    </form>
</body>
</html>
