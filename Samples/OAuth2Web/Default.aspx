<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Google.Apis.Samples.OAuth2Web._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Google API Explorer</title>
    <link type="text/css" href="main.css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="col">
            <h1>Services:</h1>
            <asp:TreeView runat="server" ID="apiTreeView" 
                onselectednodechanged="apiTreeView_SelectedNodeChanged" ShowLines="True" CssClass="apiTree">
                <SelectedNodeStyle CssClass="selectedNode" />
            </asp:TreeView>
        </div>
        <asp:Panel runat="server" ID="methodParametersPanel" CssClass="col" Visible="false">
            <h1>Method Parameters</h1>
            <asp:Repeater ID="methodParametersRepeater" runat="server">
                <HeaderTemplate><dl></HeaderTemplate>
                <FooterTemplate></dl></FooterTemplate>
                <ItemTemplate>
                    <dt><asp:Label runat="server" ID="parameterNameLabel" Text="<%# Container.DataItem %>"></asp:Label></dt>
                    <dd>
                        <asp:TextBox runat="server" ID="parameterValueTextBox"></asp:TextBox>
                    </dd>
                </ItemTemplate>
            </asp:Repeater>
            <asp:Button runat="server" ID="executeMethodButton" Text="Execute" 
                onclick="executeMethodButton_Click" />
        </asp:Panel>
    </div>
    </form>
</body>
</html>
