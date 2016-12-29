<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KatApp.aspx.cs" Inherits="HomeControls.KatApp" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .auto-style7 {
            filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#991821', endColorstr='#80141C');
            background-color: #991821;
            color: #FFFFFF;
            font-size: 15px;
            font-weight: bold;
            border-left: 1px solid #B01C26;
            width: 105px;
        }
        .auto-style8 {
            background: #F7CDCD;
            color: #80141C;
            width: 281px;
        }
    </style>
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
            <h2>Login Helper</h2>
                <strong>Site Information Lookup</strong><br />
             <asp:Label ID="Label1" runat="server" Text="Website: "></asp:Label><asp:DropDownList ID="ddlSites" runat="server" Width="130px"> </asp:DropDownList>
                <asp:Button ID="btnGet" runat="server" Text="Get Info" OnClick="btnGet_Click" Width="109px" Height="25px"/>
                <div class="datagrid">
                    <table>
                        <tr>
                            <td class="auto-style7">Site Name</td>
                            <td class="auto-style8"><asp:Label ID="lblSiteName" runat="server" Text="SiteName"></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="auto-style7">Site Link</td>
                            <td class="auto-style8"><asp:HyperLink ID="hlSiteUrl" runat="server">Site Link</asp:HyperLink></td>
                        </tr>
                        <tr>
                            <td class="auto-style7">Username</td>
                            <td class="auto-style8"><asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="auto-style7">Password</td>
                            <td class="auto-style8"><asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="auto-style7">Notes</td>
                            <td class="auto-style8"><asp:Label ID="lblNotes" runat="server" Text="Notes"></asp:Label></td>
                        </tr>
                    </table>
                </div>

                <br />
                <br />
                <br />
                <strong>Add a New Site</strong>
                    <div class="datagrid">
                    <table>
                        <tr>
                            <td class="auto-style7">Site Name</td>
                            <td class="auto-style8"><asp:TextBox ID="tbNewSiteName" runat="server" BackColor="#F7CDCD" BorderStyle="None" Width="100%"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td class="auto-style7">Site Link</td>
                            <td class="auto-style8"><asp:TextBox ID="tbNewSiteUrl" runat="server" BackColor="#F7CDCD" BorderStyle="None" Width="100%"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td class="auto-style7">Username</td>
                            <td class="auto-style8"><asp:TextBox ID="tbNewSiteUsername" runat="server" BackColor="#F7CDCD" BorderStyle="None" Width="100%"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td class="auto-style7">Password</td>
                            <td class="auto-style8"><asp:TextBox ID="tbNewSitePassword" runat="server" BackColor="#F7CDCD" BorderStyle="None" Width="100%"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td class="auto-style7">Notes</td>
                            <td class="auto-style8"><asp:TextBox ID="tbNewSiteNotes" runat="server" BackColor="#F7CDCD" BorderStyle="None" Width="100%"></asp:TextBox></td>
                        </tr>
                    </table>
                </div>
                    <!--<table>
                        <thead>
                            <tr>
                                <th class="auto-style1">Site Name</th>
                                <th>Site Link</th>
                                <th class="auto-style2">Username</th>
                                <th class="auto-style3">Password</th>
                                <th>Notes</th>
                            </tr>
                        </thead>
                        <!--<tfoot>
                            <tr>
                                <td colspan="4">
                                    <div id="paging">
                                        <ul>
                                            <li><a href="#"><span>Previous</span></a></li>
                                            <li><a href="#" class="active"><span>1</span></a></li>
                                            <li><a href="#"><span>2</span></a></li>
                                            <li><a href="#"><span>3</span></a></li>
                                            <li><a href="#"><span>4</span></a></li>
                                            <li><a href="#"><span>5</span></a></li>
                                            <li><a href="#"><span>Next</span></a></li>
                                        </ul>
                                    </div>
                                    </tr>
                        </tfoot>-->
                        <!--<tbody>                            
                            <tr class="alt">
                                <td class="auto-style1"></td>
                                <td></td>
                                <td class="auto-style2"></td>
                                <td class="auto-style3"></td>
                                <td></td>
                            </tr>
                        </tbody>
                    </table>
                </div>-->

                <asp:Button ID="btnAdd" runat="server" Text="Add New"  Width="105px" Height="25px" OnClick="btnAdd_Click" />

                <br />
                <br />
                <br />
                <br />
                <asp:Label ID="lblMessage" runat="server" Text=" "></asp:Label><br />
                

            </section>

</asp:Content>