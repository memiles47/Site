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
            <asp:Wizard ID="Wizard1" runat="server" Width="600px" ActiveStepIndex="0">
                <WizardSteps>
                    <asp:WizardStep runat="server" title="About You">
                        <asp:Label ID="lbl_YourName" runat="server" Text="Type your name"></asp:Label>
                        <asp:TextBox ID="tb_YourName" runat="server"></asp:TextBox>
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" title="Favorite Language" StepType="Finish">
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" StepType="Complete" Title="Ready">
                    </asp:WizardStep>
                </WizardSteps>
            </asp:Wizard>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
