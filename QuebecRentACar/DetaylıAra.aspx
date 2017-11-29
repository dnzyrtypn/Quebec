<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DetaylıAra.aspx.cs"enableEventValidation="false" Inherits="QuebecRentACar.DetaylıAra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!DOCTYPE html>
    <html>
    <head>
        <title>Detaylı Arama</title>
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
        <meta name="keywords" content="Detaylı Arama" />
        <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
        <link href='https://fonts.googleapis.com/css?family=Yanone+Kaffeesatz:400,700' rel='stylesheet' type='text/css'>
        <link href='https://fonts.googleapis.com/css?family=Montserrat:700,400' rel='stylesheet' type='text/css'>
        <link href="DetaylıAraAssets/css/bootstrap.css" rel='stylesheet' type='text/css' media="all">
        <script src="DetaylıAraAssets/js/jquery.min.js"></script>
        <script type="text/javascript" src="DetaylıAraAssets/js/move-top.js"></script>
        <script type="text/javascript" src="DetaylıAraAssets/js/easing.js"></script>
        <script type="text/javascript">
            jQuery(document).ready(function ($) {
                $(".scroll").click(function (event) {
                    event.preventDefault();
                    $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1000);
                });
            });
        </script>
    </head>
    </html>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body>
         <link href="DetaylıAraAssets/css/style.css" rel="stylesheet" type="text/css" media="all">     
       <div>
           <br />
           <br />
       </div>
        <div class="banner-top">
            <h2> Detaylı Arama</h2>
            <div class="banner-bottom">
                <div class="bnr-one">
                    <div class="bnr-right">
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="bnr-one">
                    <div class="bnr-right">
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="bnr-one">
                    <div class="bnr-left">
                        <p>Marka:</p>
                       
                    </div>

                    <div class="bnr-right">
                         <asp:DropDownList ID="Marka" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                      
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="bnr-one">
                    <div class="bnr-left">
                        <p>Model:</p>

                    </div>
                    <div class="bnr-right">
                        <asp:DropDownList ID="ArabaModel" runat="server" OnSelectedIndexChanged="Model_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="bnr-one">
                    <div class="bnr-left">
                        <p>Yakıt Tipi:</p>
                    </div>
                    <div class="bnr-right">
                        <asp:DropDownList ID="Yakıt" runat="server" OnSelectedIndexChanged="Yakıt_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="bnr-one">
                    <div class="bnr-left">
                        <p>Vites</p>
                    </div>
                    <div class="bnr-right">
                        <asp:DropDownList ID="Vites" runat="server" OnSelectedIndexChanged="Vites_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="bnr-one">
                    <div class="bnr-left">
                        <p>Segment:</p>
                    </div>
                    <div class="bnr-right">
                        <asp:DropDownList ID="Segment" runat="server" OnSelectedIndexChanged="Segment_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="bnr-one">
                    <div class="bnr-left">
                        <p>Kasa Tipi:</p>
                    </div>
                    <div class="bnr-right">
                        <asp:DropDownList ID="KasaTipi" runat="server"></asp:DropDownList>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="bnr-btn">
                    <form>
                        <%--<input type="submit" value="Görüntüleyin" style="margin:20px">--%>
                        <asp:Button ID="Button1" runat="server" style="margin:20px" Text="Kiralayın" OnClick="Button1_Click" />
                    </form>
                </div>
            </div>
        </div>
    </body>
</asp:Content>
