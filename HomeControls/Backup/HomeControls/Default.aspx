<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="HomeControls._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

<!-- sidebar -->    
    
            <section id="content">
            
            <table style="float:left">
            <tr>
            <td colspan = "2">
                <asp:Button ID="btnLightOn" CssClass="buttonlink" runat="server" 
                    Text="Light On" Height="49px" Width="346px" />
                </td>            
            </tr>            
            <tr>
            <td colspan = "2"><asp:HyperLink ID="hlLightOff" runat="server" CssClass="buttonlink" Width="329px">Light Off</asp:HyperLink></td>            
            </tr>
            <tr>
            
            <td><asp:TextBox ID="tbTest" runat="server" TextMode="Number" Width="69px" 
                    Height="42px" Font-Size="X-Large"></asp:TextBox></td>
                    <td><asp:HyperLink ID="hlTest" runat="server" CssClass="buttonlink" Width="249px">Test</asp:HyperLink></td>
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
            </tr>
            </table>
             </section>
      <!-- #end sidebar -->
    <!--
    
                <h1>Header 1</h1>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum</p>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum</p>
                               
<h2>Header 2</h2>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum</p>
                
<h3>Header 3</h3>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum</p>
                
<h4>Header 4</h4>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum</p>
                
      <h5>Header 5</h5>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum</p>
                

</section><!-- #end content area -->
</asp:Content>
