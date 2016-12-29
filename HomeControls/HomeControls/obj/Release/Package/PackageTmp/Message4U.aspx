<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Message4U.aspx.cs" Inherits="HomeControls.Error" MasterPageFile="~/Site.master" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    </asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <nav id="topnav" role="navigation">            
        <div class="menu-toggle">Menu</div>  
        	<ul class="srt-menu" id="menu-main-navigation">
            <li><a href="Default.aspx">HomeCtrl</a></li>
            <li class="current"><a href="KatLogin.aspx">KatLogin</a></li>
			<!--<li><a href="#">menu item 3</a>
				<ul>
					<li>
						<a href="#">menu item 3.1</a>
					</li>
					<li class="current">
						<a href="#">menu item 3.2</a>
						<ul>
							<li><a href="#">menu item 3.2.1</a></li>
							<li><a href="#">menu item 3.2.2 with longer link name</a></li>
							<li><a href="#">menu item 3.2.3</a></li>
							<li><a href="#">menu item 3.2.4</a></li>
							<li><a href="#">menu item 3.2.5</a></li>
						</ul>
					</li>
					<li><a href="#">menu item 3.3</a></li>
					<li><a href="#">menu item 3.4</a></li>
				</ul>
			</li>-->
			<!--<li>
				<a href="#">menu item 4</a>
				<ul>
					<li><a href="#">menu item 4.1</a></li>
					<li><a href="#">menu item 4.2</a></li>
				</ul>
			</li>
			<li>
				<a href="#">menu item 5</a>
			</li>-->	
		</ul>     
		</nav>
            <section id="content">
            <h2><asp:Label ID="lblHeader" runat="server" Text="Label"></asp:Label></h2>
                <p>
                    <strong><asp:Label ID="lblSubtitle" runat="server" Text="Label"></asp:Label></strong><br />                    
                    
                    <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
                </p>


            </section>

</asp:Content>