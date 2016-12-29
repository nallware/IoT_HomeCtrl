<%@ Page Title="HomeCtrl" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="HomeControls._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
    <nav id="topnav" role="navigation">            
        <div class="menu-toggle">Menu</div>  
        	<ul class="srt-menu" id="menu-main-navigation">
            <li class="current"><a href="Default.aspx">HomeCtrl</a></li>
            <li><a href="KatLogin.aspx">KatLogin</a></li>
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
            <asp:Label ID="lblStatus" runat="server" Text="Light Status:"></asp:Label><br />
            <table style="float:left">
                <tr>
                    <td colspan = "2">
                        PASSCODE: <asp:TextBox ID="tbPasscode" runat="server" TextMode="Password" Width="124px" Height="42px" Font-Size="X-Large"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan = "2">
                        <asp:Button ID="btnLightOn" CssClass="mainbtn" runat="server" Text="Light On" Height="49px" Width="233px" OnClick="btnLightOn_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan = "2"><asp:Button ID="btnLightOff" CssClass="mainbtn" runat="server" Text="Light Off" Height="49px" Width="234px" OnClick="btnLightOff_Click" /></td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="tbBlinks" runat="server" Width="70px" Height="42px" Font-Size="X-Large" TextMode="Number"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnTest" CssClass="mainbtn" Width="136px" runat="server" Text="Test" Height="49px" OnClick="btnTest_Click" />                        
                    </td>
                </tr>
                <!--<tr>
                    <td colspan = "2"><asp:Button ID="btnCheckLight" CssClass="mainbtn" runat="server" Text="Check Light Status" Height="49px" Width="234px" OnClick="btnCheckLight_Click" /></td>
                </tr>
            <tr>
            
            <td><asp:TextBox ID="tbTimerOn" runat="server" TextMode="Number" Width="69px" 
                    Height="42px" Font-Size="X-Large"></asp:TextBox></td>
                    <td><asp:HyperLink ID="hlTimerOn" runat="server" CssClass="buttonlink" Width="249px">Timer On</asp:HyperLink></td>
            </tr>
            <tr>
            
            <td><asp:TextBox ID="tbTimerOff" runat="server" TextMode="Number" Width="69px" 
                    Height="42px" Font-Size="X-Large"></asp:TextBox></td>            
                    <td><asp:HyperLink ID="hlTimerOff" runat="server" CssClass="buttonlink" Width="249px">Timer Off</asp:HyperLink></td>
            </tr>-->
            </table>
             </section>
</asp:Content>
