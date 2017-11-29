using RentACar.Business.Concrete;
using RentACar.Model.Entities.Sales;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuebecRentACar
{
    public partial class MüşteriBilgileri : System.Web.UI.Page
    {

        MusteriManagement _musteriManagement;
        public MüşteriBilgileri()
        {
            _musteriManagement = new MusteriManagement();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["müşteri"] = "Müşteri Bilgileri";



        }

        protected void Button1_Click(object sender, EventArgs e)
        {


        }

        protected void btnMusteri_Click1(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.TC = tc.Value;
            musteri.Ad = ad.Value;
            musteri.Soyad = soyad.Value;
            musteri.TelefonNo = telno.Value;
            musteri.Adress = adres.Value;
            musteri.DogumTarihi =Convert.ToDateTime(this.clndrDogumTarihi.SelectedDate.ToShortDateString());
            //musteri.DogumTarihi = DateTime.Parse(Convert.ToInt32(yil.va) + "." + Convert.ToInt32(ay.Value) + "." + Convert.ToInt32(gun.Value));
            musteri.User.Mail = mail.Value;



            HttpPostedFile yuklenecekDosya = fluDosya.PostedFile;
            if (yuklenecekDosya != null)
            {
                FileInfo dosyaBilgisi = new FileInfo(yuklenecekDosya.FileName);
                string klasor = "EhliyetFotograflari";

                string dosyaAdi = dosyaBilgisi.Name.Substring(0, dosyaBilgisi.Name.Length - dosyaBilgisi.Extension.Length);
                dosyaAdi += "-" + Guid.NewGuid().ToString().Replace("-", "") + dosyaBilgisi.Extension;

                string yuklemeYeri = Server.MapPath("~/" + klasor + "/" + dosyaBilgisi.Name);
                fluDosya.SaveAs(yuklemeYeri);

                string kayitYeri = klasor + "/" + dosyaAdi;
                //musteri.EhliyetFotokopisi = yuklemeYeri;


            }
            //_musteriManagement.Add(musteri);
        }
    }
}