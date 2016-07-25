<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TableDemo.aspx.cs" Inherits="Site.Demos.TableDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Bulleted List</td>
                <td>
                    <ul>
                        <li>Classic Rock</li>
                        <li>Reggae</li>
                        <li>Plays</li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Numbered List</td>
                <td>
                    <ol>
                        <li>Sugarland</li>
                        <li>Rascal Flats</li>
                        <li>Kenny Chesney</li>
                    </ol>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Hyperlink</td>
                <td><a href="../Default.aspx">Go to the homepage of Planet Wrox</a></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
