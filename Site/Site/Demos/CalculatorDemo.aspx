<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorDemo.aspx.cs" Inherits="Site.Demos.CalculatorDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 1660px;
        }
        .auto-style3 {
            width: 1289px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td colspan="3">
                    <asp:Label ID="lbl_ResultLable" runat="server" Text="[ResultLable]"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:TextBox ID="txt_Value1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddl_OperatorList" runat="server">
                        <asp:ListItem>+</asp:ListItem>
                        <asp:ListItem>-</asp:ListItem>
                        <asp:ListItem>*</asp:ListItem>
                        <asp:ListItem>/</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="txt_Value2" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="btn_Calculate" runat="server" Text="Calculate" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
