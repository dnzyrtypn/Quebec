<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OturumAç.aspx.cs" Inherits="QuebecRentACar.OturumAç" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Sign In Sign Up</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="Blue Multiple Forms template Responsive, Login form web template,Flat Pricing tables,Flat Drop downs  Sign up Web Templates, Flat Web Templates, Login sign up Responsive web template, SmartPhone Compatible web template, free WebDesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- Custom Theme files -->
    <link href="LoginAssets/css/style.css" rel="stylesheet" type="text/css" media="all" />
    <!-- //Custom Theme files -->
    <!-- web font -->
    <link href="https://fonts.googleapis.com/css?family=Playfair+Display:400,400i,700,700i,900,900i" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Roboto+Condensed:300,300i,400,400i,700,700i" rel="stylesheet"/>
    <!-- //web font -->

</head>
<body>
   <form id="form1"   runat="server" >
        <div>
            <!-- main -->
            <div class="main" >
                <h1></h1>
                <div class="main-w3lsrow">
                    <!-- login form -->
                    <div class="login-form login-form-left" style="margin-left: 25%;">
                        <div class="agile-row">
                            <h2>Oturum Açın</h2>
                            <div class="login-agileits-top">
                                
                                    <p>E-Mail Adresiniz:</p>
                                
                                    <input type="text" class="name" id="mailOA" name="Mail" required=""  runat="server" />
                                    <p>Şifreniz:</p>
                                <input type="password" id="passwordOA" runat="server" class="password" name="Password" required="" />
                                    <label class="anim">
                                        <input type="checkbox" class="checkbox" />
                                      
                                    </label>
                                <asp:Label ID="lblerror" runat="server" Text="Beni Hatırla" class="alert alert-danger" role="alert" style="visibility:visible" runat="server"></asp:Label>
                                <br />
                                <br />
                                <asp:Button ID="btnsignin" runat="server" Text="Oturum Aç" CssClass="buttonLogin" OnClick="btnsignin_Click"  />
                                <p style="color:white">Kayıt Olmak İçin<a href="Login.aspx" style="color:aqua" > Tıklayınız</a></p>
                                <%--<asp:Button ID="btnkayıt" runat="server" Text="Kayıt Olmak İçin" CssClass="buttonLogin" BackColor="Purple" OnClick="btnkayıt_Click"/> --%> 
                            </div>
                            <div class="login-agileits-bottom">
                                <h6></h6>
                                <br />
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
