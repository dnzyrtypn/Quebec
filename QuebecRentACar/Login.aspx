<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="QuebecRentACar.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign In Sign Up</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="Blue Multiple Forms template Responsive, Login form web template,Flat Pricing tables,Flat Drop downs  Sign up Web Templates, Flat Web Templates, Login sign up Responsive web template, SmartPhone Compatible web template, free WebDesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- Custom Theme files -->
    <link href="LoginAssets/css/style.css" rel="stylesheet" type="text/css" media="all" />
    <!-- //Custom Theme files -->
    <!-- web font -->
    <link href="https://fonts.googleapis.com/css?family=Playfair+Display:400,400i,700,700i,900,900i" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Roboto+Condensed:300,300i,400,400i,700,700i" rel="stylesheet">
    <!-- //web font -->
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- main -->
            <div class="main">
                <h1></h1>
                <div class="main-w3lsrow">
                    
                    <!-- sign up form -->
                    <div class="login-form agileits-right" style="margin-right: 25%;">
                        <div class="agile-row">
                            <h3>Aramıza Katılın</h3>
                            <div class="login-agileits-top">
                                
                                    <p>E-mail Adresiniz:</p>
                                    <input type="email" id="emailKO" class="email" name="email" required="" runat="server" />
                                    <p>Şifreniz:</p>
                                    <input type="password" runat="server" id="passwordKO" class="password" name="password"  />
                                    <p>Şifreni Tekrarı:</p>
                                    <input type="password" id="passwordtekrar" runat="server" class="password" name="password" required="" />
                                <%--<asp:Label ID="lblerrorsignup" runat="server" Text="Label" class="alert alert-danger" role="alert" style="visibility:visible"></asp:Label>--%>
                                   <%-- <input type="submit" value="kayıt olun" />--%>
                                    <asp:Button ID="Button2" runat="server" Text="Kayıt Olun" CssClass="buttonLogin"  OnClick="Button2_Click"/>
                               
                            </div>
                        </div>
                    </div>
                    <div class="clear"></div>
                </div>
            </div>
            <!-- //main -->
            <!-- copyright -->
            <div class="copyright">
                <p>© 2017  QUABEC Rent A Car. All rights reserved | Design by XYZ</p>
            </div>
            <!-- //copyright -->
        </div>
    </form>
</body>
</html>
