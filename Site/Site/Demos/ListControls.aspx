<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListControls.aspx.cs" Inherits="Site.Demos.ListControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ddl_LanguageSelect" runat="server">
            <asp:ListItem>C#</asp:ListItem>
            <asp:ListItem>CSS</asp:ListItem>
            <asp:ListItem>Visual Basic</asp:ListItem>
            <asp:ListItem>Python</asp:ListItem>
        </asp:DropDownList>
        <asp:CheckBoxList ID="cbl_LanguageSelect" runat="server">
            <asp:ListItem>C#</asp:ListItem>
            <asp:ListItem>CSS</asp:ListItem>
            <asp:ListItem>Visual Basic</asp:ListItem>
            <asp:ListItem>Python</asp:ListItem>
        </asp:CheckBoxList>
        <asp:Button ID="btn_Submit" runat="server" Text="Submit" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="lbl_Output" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
