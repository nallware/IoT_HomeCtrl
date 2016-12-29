<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="HomeControls.Admin" MasterPageFile="~/Site.master" %>
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
            <h2>Login Helper Admin Page</h2>
                <p>
                    <strong>Add New User</strong><br />
                    Username:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox><br />
                    Password:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbPassword" runat="server"></asp:TextBox><br />
                    Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox><br />
                    First Name:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox><br />
                    Last Name:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbLastName" runat="server"></asp:TextBox><br />
                    <asp:Button ID="btnAddNewUser" runat="server" Text="Add New User" OnClick="btnAddNewUser_Click"></asp:Button>
                </p>

                <p>
                    <strong>Reset User Password</strong><br />
                    <asp:DropDownList ID="ddlResetUser" runat="server" Width="180px"></asp:DropDownList><br />
                    <asp:Button ID="btnResetPassword" runat="server" Text="Reset Password" OnClick="btnResetPassword_Click"></asp:Button>
                </p>
                
                <p>
                    <strong>Emergency Decrypt</strong><br />
                    Encrypted:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbEncrypted" runat="server"></asp:TextBox><br />
                    Decrypted:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbDecrypted" runat="server"></asp:TextBox><br />
                    <asp:Button ID="btnEncDec" runat="server" Text="Encrypt/Decrypt" OnClick="btnEncDec_Click" ></asp:Button>
                </p>

            </section>

</asp:Content>