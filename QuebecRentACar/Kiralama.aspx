<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Kiralama.aspx.cs" Inherits="QuebecRentACar.Kiralama" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!DOCTYPE html>
    <html>
    <head>
        <title>Kiralayın</title>
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
        <meta name="keywords" content="Error Page Widget Responsive, Login form web template,Flat Pricing tables,Flat Drop downs  Sign up Web Templates, Flat Web Templates, Login signup Responsive web template, Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
        <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
        <link href='https://fonts.googleapis.com/css?family=Yanone+Kaffeesatz:400,700' rel='stylesheet' type='text/css'>
        <link href='https://fonts.googleapis.com/css?family=Montserrat:700,400' rel='stylesheet' type='text/css'>
        
      
    </head>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body>
        <link href="KiralaAssets/css/style.css" rel="stylesheet" type="text/css" media="all">
        <link href="KiralaAssets/css/bootstrap.css" rel='stylesheet' type='text/css' media="all">
        <script src="KiralaAssets/js/jquery.min.js"></script>
          <script type="text/javascript">
              jQuery(document).ready(function ($) {
                  $(".scroll").click(function (event) {
                      event.preventDefault();
                      $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1000);
                  });
              });
        </script>
        <script type="text/javascript" src="KiralaAssets/js/move-top.js"></script>
        <script type="text/javascript" src="KiralaAssets/js/easing.js"></script>
        <div class="header">
            <h1></h1>
        </div>
        <div class="banner-top">
            <h2>Kusursuz Deneyimi Yaşayın</h2>
            <div class="banner-bottom">
                <div class="bnr-one">
                    <div class="bnr-left">
                        <p>Alış Tarihi:</p>
                    </div>
                    <div class="bnr-right" >
                        <asp:TextBox ID="txtalıştarihi" runat="server"></asp:TextBox>
                        <asp:Calendar ID="alıştarihicalendar" runat="server" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '';}"></asp:Calendar>
                       <%-- <input class="date" id="alıştarihi" runat="server" type="text" value="" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '';}" required="" >--%>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="bnr-one">
                    <div class="bnr-left">
                        <p>İade Tarihi:</p>
                    </div>
                    <div class="bnr-right">
                        <asp:TextBox ID="txtiadetarihi" runat="server"></asp:TextBox>
                        <asp:Calendar ID="iadetarihicalendar" runat="server" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '';}"></asp:Calendar>
                        <%--<input class="date" id="iadetarihi" runat="server" type="text" value="" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '';}" required="">--%>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="bnr-one">
                    <div class="bnr-left">
                        <p>Alış Yeri:</p>
                    </div>
                    <div class="bnr-right">
                        <asp:DropDownList ID="drpAlisYeri" CssClass="rm" runat="server"></asp:DropDownList>
                       <%-- <select id="alışyeri" runat="server">
                            <option class="rm" value="">İstanbul Atatürk Havalimanı</option>
                            <option class="rm" value="">İstanbul Sabiha Gökçen Havalimanı</option>
                            <option class="rm" value="">İzmir Adnan Menderes Havalimanı</option>
                            <option class="rm" value="">Ankara Esenboğa Havalimanı</option>
                        </select>--%>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="bnr-one">
                    <div class="bnr-left">
                        <p>İade Yeri:</p>
                    </div>
                    <div class="bnr-right">
                         <asp:DropDownList ID="drpIadeYeri" CssClass="rm" runat="server"></asp:DropDownList>
   <%--                     <select id="iadeyeri" runat="server">
                            <option class="rm" value="">İstanbul Atatürk Havalimanı</option>
                            <option class="rm" value="">İstanbul Sabiha Gökçen Havalimanı</option>
                            <option class="rm" value="">İzmir Adnan Menderes Havalimanı</option>
                            <option class="rm" value="">Ankara Esenboğa Havalimanı</option>
                        </select>--%>
                    </div>
                    
                   

                    <div class="clearfix"></div>
                </div>
                <div class="bnr-btn">
                    <form>
                        <asp:Button ID="btnkirala" runat="server" Text="Kiralayın" OnClick="btnkirala_Click"/>
                       <%-- <input type="submit" value="Kiralayın">--%>
                    </form>
                </div>
            </div>
            <!---start-date-piker---->
            <link rel="stylesheet" href="KiralaAssets/css/jquery-ui.css" />
            <script src="KiralaAssets/js/jquery-ui.js"></script>
            <script>
                $(function () {
                    $("#datepicker,#datepicker1").datepicker();
                });
            </script>
            <!---/End-date-piker---->
        </div>
        <div class="footer">
        </div>
    </body>
    </html>
</asp:Content>
