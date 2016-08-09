<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Containers.aspx.cs" Inherits="Site.Demos.Containers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBox ID="cb_ShowPanel" runat="server" AutoPostBack="True" OnCheckedChanged="cb_ShowPanel_OnCheckedChanged"/>
        <asp:Panel ID="pnl_Panel1" runat="server" Visible="False">
            I am visible now
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
