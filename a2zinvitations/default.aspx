<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="a2zinvitations._default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 1857px;
            height: 995px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Timer ID="Timer1" runat="server" Interval="20000" ontick="Timer1_Tick">
        </asp:Timer>
        <table style="margin: auto; background-color: White">
            <tr>
                <td>  
                    <!--Next to appear-->
                    <asp:Panel ID="pnl04" runat="server" Visible="false">
                        <asp:HyperLink ID="HyperLink5" runat="server">
                            <img src="img/Page05.png" />
                        </asp:HyperLink>
                    </asp:Panel>        
                    <!--Next to appear-->
                    <asp:Panel ID="pnl03" runat="server" Visible="false">
                        <asp:HyperLink ID="HyperLink4" NavigateUrl="http://www.pleated-jeans.com/2013/03/04/20-funny-and-clever-desktop-wallpapers/" runat="server">
                            <img src="img/Page04.png" />
                        </asp:HyperLink>
                    </asp:Panel>  
                    <!--Next to appear-->
                    <asp:Panel ID="pnl02" runat="server" Visible="false">
                        <asp:HyperLink ID="HyperLink3" NavigateUrl="http://hqbackground.com/funny-background-1-widescreen-background-and-wallpaper.html" runat="server">
                            <img src="img/Page03.png" />
                        </asp:HyperLink>
                    </asp:Panel>    
                    <!--Next to appear-->
                    <asp:Panel ID="pnl01" runat="server" Visible="false">
                        <asp:HyperLink ID="HyperLink2" NavigateUrl="https://www.google.com/" runat="server">
                            <img src="img/Page02.png" />
                        </asp:HyperLink>
                    </asp:Panel>
                    <!--Shown by default-->
                    <asp:Panel ID="pnlwebsite" runat="server" Visible="true">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://invys.com/design-your-cards.html">
                            <img alt="http://invys.com/design-your-cards.html" class="style1" longdesc="http://invys.com/design-your-cards.html" src="img/Page01.png" />
                        </asp:HyperLink>
                    </asp:Panel> 
                                
                         
                                
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
