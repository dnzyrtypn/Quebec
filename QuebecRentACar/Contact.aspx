<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="QuebecRentACar.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
		<h3 class="text-center" data-aos="zoom-in">Contact Us</h3>
        <!-- Page Heading/Breadcrumbs -->
        <div class="row">
            <div class="col-lg-12">
                <ol class="breadcrumb" data-aos="zoom-in">
                    <li><a href="Home.html">Anasayfa</a></li>
                    <li class="active">İletişim</li>
                </ol>
            </div>
        </div>
        <!-- /.row -->
	</div>
    <br />
    <br />
    <section class="contact-w3layouts">
	<!-- Page Content -->
    <div class="container">
        <!-- Map Column -->
        <div class="col-md-8" data-aos="flip-left">
            <!-- Embedded Google Map -->
			<div class="map-w3ls">
				<iframe class="googlemaps" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3012.140331391705!2d28.87119371497169!3d40.97840787930379!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cabca5103a62db%3A0x175d460154b542a7!2sZeytinlik+Mahallesi%2C+Fi%C5%9Fekhane+Cd.+No%3A14%2C+34140+Bak%C4%B1rk%C3%B6y%2FIstanbul!5e0!3m2!1str!2str!4v1505270446466" style="border:0" allowfullscreen></iframe>
			</div>
        </div>
        <!-- Contact Details Column -->
        <div class="col-md-4" data-aos="flip-right">
            <h3>Bize Ulaşın</h3>
            <p><i class="fa fa-map-marker"></i> Zeytinlik Mahallesi, Fişekhane Cd. No:14, 34140 Bakırköy/Istanbul</p>
            <p><i class="fa fa-phone"></i> (0212) 570 03 72</p>
            <p><i class="fa fa-envelope-o"></i> <a href="mailto:rentacar@quabec.com">rentacar@quabec.com</a></p>
			<ul class="social-icons2">
				<li><a href="#"><i class="fa fa-facebook" aria-hidden="true"></i></a></li>
				<li><a href="#"><i class="fa fa-google-plus" aria-hidden="true"></i></a></li>
				<li><a href="#"><i class="fa fa-twitter" aria-hidden="true"></i></a></li>
				<li><a href="#"><i class="fa fa-youtube" aria-hidden="true"></i></a></li>
			</ul>
        </div>
    </div>
</section>


    <section class="contact-w3ls">	
    <!-- Contact Form -->
	<div class="container">	
		<div class="col-md-12">
			<h3 class="text-center" data-aos="flip-up">Lütfen Yorumlarınızı Bizimle Paylaşın</h3>
			<form action="" method="post" name="sentMessage" id="contactForm" novalidate>
                <div class="control-group form-group" data-aos="flip-up">
                    <div class="controls">
                        <label>Adınız ve Soyadınız:</label>
                        <input type="text" class="form-control" id="name" required data-validation-required-message="Lütfen adınızı giriniz.">
                        <p class="help-block"></p>
                    </div>
                </div>
                <div class="control-group form-group" data-aos="flip-up">
                    <div class="controls">
                        <label>Telefon Numaranız:</label>
                        <input type="tel" class="form-control" id="phone" required data-validation-required-message="Lütfen telefon numaranızı giriniz.">
                    </div>
                </div>
                <div class="control-group form-group" data-aos="flip-up">
                    <div class="controls">
                        <label>E-mail Adresiniz:</label>
                        <input type="email" class="form-control" id="email" required data-validation-required-message="Lütfen E-mail adresinizi giriniz.">
                    </div>
                </div>
				<div class="control-group form-group" data-aos="flip-up">
                    <div class="controls">
						<label>Yorumlarınız:</label>
                        <textarea rows="10" cols="100" class="form-control" id="message" required data-validation-required-message="Lütfen yorumunuzu yazınız." maxlength="999" style="resize:none"></textarea>
                    </div>
                </div>
                <div id="success"></div>
                <!-- For success/fail messages -->
                <button type="submit" class="btn btn-primary" data-aos="flip-up">gönderiniz</button>
                <%--<asp:Button ID="btngönderin" runat="server" Text="Gönderiniz" OnClick="btngönderin_Click"/>--%>
            </form>
		</div>
	</div>
</section>	


</asp:Content>
