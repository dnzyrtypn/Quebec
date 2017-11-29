<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MüşteriBilgileri.aspx.cs" Inherits="QuebecRentACar.MüşteriBilgileri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Müşteri Bilgileri</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="Dragging register form Responsive, Login Form Web Template, Flat Pricing Tables, Flat Drop-Downs, Sign-Up Web Templates, Flat Web Templates, Login Sign-up Responsive Web Template, Smartphone Compatible Web Template, Free Web Designs for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>

    <!-- custom css file -->
    <link rel="stylesheet" href="MusteriBilgileriAssets/css/style.css" />
    <!-- //custom css file -->

    <!-- google fonts -->
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:400,300italic,300,400italic,600,600italic,700,700italic,800,800italic' rel='stylesheet' type='text/css' />
    <link href='https://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css' />
    <!-- //google fonts -->
    <style>
        .buttonCSS {
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" method="post" enctype="multipart/form-data">
        <div>
            <h1></h1>
            <div class="agile-its">
                <h2>Lütfen Bilgilerinizi Giriniz...</h2>
                <div class="w3layouts">
                    <div class="photos-upload-view">
                        <%--	<form id="upload" action="index.html" method="post" enctype="multipart/form-data">--%>
                        <input type="hidden" id="MAX_FILE_SIZE" name="MAX_FILE_SIZE" value="300000" />

                        <div class="agileinfo-row">
                            <div class="ferry ferry-from">
                                <label>TC Kimlik Numaranız:</label>
                                <input type="text" id="tc" runat="server" name="Name" placeholder="" required="" />
                            </div>
                            <div class="ferry ferry-from">
                                <label>Adınız:</label>
                                <input type="text" name="Name" runat="server" id="ad" placeholder="" required="">
                            </div>
                            <div class="ferry ferry-from">
                                <label>Soyadınız:</label>
                                <input type="text" name="Name" id="soyad" runat="server" placeholder="" required="">
                            </div>
                            <div class="ferry ferry-from">
                                <label>E-mail Adresiniz:</label>
                                <input type="email" name="email" id="mail" runat="server" placeholder="" required="">
                            </div>
                            <div class="ferry ferry-from">
                                <label>Telefon Numaranız:</label>
                                <input type="text" name="Name" placeholder="" runat="server" id="telno" required="">
                            </div>
                            <div class="ferry ferry-from">
                                <label>Adresiniz:</label>
                                <input type="text" name="Name" placeholder="" runat="server" id="adres" required="">
                            </div>
                            <div class="w3_agileits_main_grid_left_r">
                                <div class="clear"></div>
                            </div>
                            <label>Doğum Tarihiniz:</label>
                            <div class="form_box">
                                <div class="select-block1 middle">
                                    <asp:TextBox ID="txtDogumTarihi" runat="server"></asp:TextBox>
                                    <asp:Calendar ID="clndrDogumTarihi" runat="server"></asp:Calendar>
                                   <%-- <select required="" id="gun" runat="server">
                                        <option value="">01</option>
                                        <option value="">02</option>
                                        <option value="">03</option>
                                        <option value="">04</option>
                                        <option value="">05</option>
                                        <option value="">06</option>
                                        <option value="">07</option>
                                        <option value="">08</option>
                                        <option value="">09</option>
                                        <option value="">10</option>
                                        <option value="">11</option>
                                        <option value="">12</option>
                                        <option value="">13</option>
                                        <option value="">14</option>
                                        <option value="">15</option>
                                        <option value="">16</option>
                                        <option value="">17</option>
                                        <option value="">18</option>
                                        <option value="">19</option>
                                        <option value="">20</option>
                                        <option value="">21</option>
                                        <option value="">22</option>
                                        <option value="">23</option>
                                        <option value="">24</option>
                                        <option value="">25</option>
                                        <option value="">26</option>
                                        <option value="">27</option>
                                        <option value="">28</option>
                                        <option value="">29</option>
                                        <option value="">30</option>
                                        <option value="">31</option>
                                    </select>--%>
                                </div>
                                <div class="form_box">
                                    <div class="select-block1">
                                        <%--<select required="" id="ay" runat="server">
                                            <option value="">Ocak</option>
                                            <option value="">Şubat</option>
                                            <option value="">Mart</option>
                                            <option value="">Nisan</option>
                                            <option value="">Mayıs</option>
                                            <option value="">Haziran</option>
                                            <option value="">Temmuz</option>
                                            <option value="">Ağustos</option>
                                            <option value="">Eylül</option>
                                            <option value="">Ekim</option>
                                            <option value="">Kasım</option>
                                            <option value="">Aralık</option>
                                        </select>--%>
                                    </div>
                                </div>
                            </div>
                            <div class="form_box1">
                                <div class="select-block1 last">
                                    <%--<select required="" id="yil" runat="server">
                                        <option value="">1982</option>
                                        <option value="">1983</option>
                                        <option value="">1984</option>
                                        <option value="">1985</option>
                                        <option value="">1986</option>
                                        <option value="">1987</option>
                                        <option value="">1988</option>
                                        <option value="">1989</option>
                                        <option value="">1990</option>
                                        <option value="">1991</option>
                                        <option value="">1992</option>
                                        <option value="">1993</option>
                                        <option value="">1994</option>
                                        <option value="">1995</option>
                                        <option value="">1996</option>
                                        <option value="">1997</option>
                                        <option value="">1998</option>
                                        <option value="">1999</option>
                                        <option value="">2000</option>
                                        <option value="">2001</option>
                                        <option value="">2002</option>
                                        <option value="">2003</option>
                                        <option value="">2004</option>
                                        <option value="">2005</option>
                                        <option value="">2006</option>
                                        <option value="">2007</option>
                                        <option value="">2008</option>
                                        <option value="">2009</option>
                                        <option value="">2010</option>
                                        <option value="">2011</option>
                                        <option value="">2012</option>
                                        <option value="">2013</option>
                                        <option value="">2014</option>
                                        <option value="">2015</option>
                                        <option value="">2016</option>
                                        <option value="">2017</option>
                                    </select>--%>
                                </div>
                            </div>
                            <div class="clear"></div>
                        </div>
                        <div class="agileinfo">
                            <asp:FileUpload runat="server" ID="fluDosya" multiple="multiple" />
                            <%--<input type="file" id="fileselect" name="fileselect[]" multiple="multiple" />--%>
                            <div id="ehliyetfoto" runat="server">
                                <h4>Lütfen Ehliyetinizin Fotoğrafını Ekleyiniz</h4>
                            </div>
                        </div>
                        <div class="wthree-text">
                            <div class="wthreesubmitaits">
                                <%--<input type="submit" name="submit" value="Onaylıyorum"style="margin-left:130px;">--%>
                                <%--<asp:Button ID="btnMusteri" runat="server" Text="Onaylıyorum"  OnClick="btnMusteri_Click" style="margin-left:130px;" />--%>

                                <asp:Button ID="btnMusteri" runat="server" CssClass="buttonCSS" Text="Onaylıyorum" OnClick="btnMusteri_Click1" />
                            </div>
                            <div class="clear"></div>
                        </div>
                        <%--</form>	--%>
                    </div>
                    <div class="clear"></div>
                </div>
            </div>
            <div class="footer">
                <p>© 2017 QUEBEC Rent A Car. All Rights Reserved | Design by XYz</p>
            </div>
            <!-- js files -->
            <script src="MusteriBilgileriAssets/js/filedrag.js"></script>
            <script type="MusteriBilgileriAssets/text/javascript" src="js/jquery.min.js"></script>
            <!-- //js files -->
        </div>
    </form>
</body>
</html>
