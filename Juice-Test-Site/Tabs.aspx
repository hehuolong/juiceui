﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tabs.aspx.cs" Inherits="Juice_Sample_Site.Tabs" masterpagefile="~/Base.Master" %>
<asp:content contentplaceholderid="_Content" runat="server">

	<asp:button ID="_Button" runat="server" Text="Postback"/>

  <Juice:Tabs ID="_Tabs" runat="server" PanelTemplate="<div>!&lt;/div&gt;" AutoPostBack="true">
	<tabpages>
		<juice:tabpage
	</tabpages>
<%--    <Juice:TabPage Title="Tab 1" ID="Tab1">
			<TabContent>
				<p>This should display on tab 1.</p>
				<asp:textbox ID="_Textbox" runat="server"/>
      </TabContent>
    </Juice:TabPage>

    <Juice:TabPage Title="Tab 2" ID="Tab2">
      <TabContent>
        <p>This should display on tab 2.</p>
      </TabContent>
    </Juice:TabPage>--%>
  </Juice:Tabs>

</asp:content>
