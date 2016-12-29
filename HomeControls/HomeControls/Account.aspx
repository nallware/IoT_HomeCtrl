<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="HomeControls.Account" MasterPageFile="~/Site.master" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    </asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <nav id="topnav" role="navigation">            
        <div class="menu-toggle">Menu</div>  
        	<ul class="srt-menu" id="menu-main-navigation">
            <li><a href="Default.aspx">HomeCtrl</a></li>
            <li class="current"><a href="KatLogin.aspx">KatLogin</a></li>
            <li><a href="Account.aspx">Account</a></li>
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
            <h2>Account Page</h2>
                <p>
                    <strong>Change Password</strong><br />                    
                    Old Password:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbOldPass" runat="server" TextMode="Password"></asp:TextBox><br />
                    New Password:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbNewPass" runat="server" TextMode="Password"></asp:TextBox><br />
                    New Password:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbNewPassMatch" runat="server" TextMode="Password"></asp:TextBox><br />
                    <asp:Button ID="btnChangePassword" runat="server" Text="Change My Password" OnClick="btnChangePassword_Click" ></asp:Button><br /><br />

                    <strong>Change Email</strong><br />
                    Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbEmail" TextMode="Email" runat="server" Width="190px"></asp:TextBox><br />
                    <asp:Button ID="btnChangeEmail" runat="server" Text="Change My Email" OnClick="btnChangeEmail_Click"></asp:Button><br /><br />

                    <strong>Change Name</strong><br />
                    First Name:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox><br />
                    Last Name:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbLastName" runat="server"></asp:TextBox><br />
                    <asp:Button ID="btnChangeName" runat="server" Text="Change My Name" OnClick="btnChangeName_Click"></asp:Button><br /><br />
                    
                </p>


            </section>

</asp:Content>