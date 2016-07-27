<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlsDemo.aspx.cs" Inherits="Site.Demos.ControlsDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Your Name:
        <asp:TextBox ID="txt_MichaelMiles" runat="server"></asp:TextBox>
        <asp:Button ID="btn_Submit" runat="server" Text="Submit Information" OnClick="btn_Submit_Click" />
        <br />
        <asp:Label ID="lbl_Result" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
