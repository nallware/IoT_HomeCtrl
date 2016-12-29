<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KatLogin.aspx.cs" Inherits="HomeControls.KatLogin" MasterPageFile="~/Site.master" %>

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
            <h2>Login</h2>
             <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label><asp:TextBox ID="tbUsername" runat="server"></asp:TextBox><br /><br />
                <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label><asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox><br /><br />
                <asp:Label ID="lblMessage" runat="server" Text=" "></asp:Label><br />
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="mainbtn" OnClick="btnLogin_Click" Width="161px" />

            </section>

</asp:Content>
