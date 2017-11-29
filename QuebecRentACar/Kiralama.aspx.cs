using RentACar.Business.Concrete;
using RentACar.Model.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuebecRentACar
{
    public partial class Kiralama : System.Web.UI.Page
    {
        ArabaManagement _arabaManagement = new ArabaManagement();
        KiralamaBilgileriManagement _kiralaManagement;
        Araba demet_BMW;

       


        public Kiralama()
        {
            //demet_BMW = _arabaManagement.GetByID(0);
            //_kiralaManagement = new KiralamaBilgileriManagement();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["fatura"] = "Fatura Bilgileri";


            if (!Page.IsPostBack)
            {
                drpIadeYeri.Items.Add("İstanbul Atatürk Havalimanı");
                drpIadeYeri.Items.Add("İstanbul Sabiha Gökçen Havalimanı");
                drpIadeYeri.Items.Add("İzmir Adnan Menderes Havalimanı");
                drpIadeYeri.Items.Add("Ankara Esenboğa Havalimanı");
                drpAlisYeri.Items.Add("İstanbul Atatürk Havalimanı");
                drpAlisYeri.Items.Add("İstanbul Sabiha Gökçen Havalimanı");
                drpAlisYeri.Items.Add("İzmir Adnan Menderes Havalimanı");
                drpAlisYeri.Items.Add("Ankara Esenboğa Havalimanı");
            }
        }

        protected void btnkirala_Click(object sender, EventArgs e)
        {
            Kiralama kirala = new Kiralama();
            kirala.txtalıştarihi.Text = this.alıştarihicalendar.SelectedDate.ToShortDateString();
            kirala.txtiadetarihi.Text = this.iadetarihicalendar.SelectedDate.ToShortDateString();
            kirala.drpAlisYeri.Text = drpAlisYeri.SelectedValue;
            kirala.drpIadeYeri.Text = drpIadeYeri.SelectedValue;
            Response.Redirect("MüşteriBilgileri.aspx");

            Session["toplamFiyat"] = toplamFiyat(demet_BMW, DateTime.Parse(txtiadetarihi.Text), DateTime.Parse(txtalıştarihi.Text));

            //decimal toplamfiyat = Convert.ToDecimal(Session["toplamFiyat"]); 
           
            Araba arabam=new Araba();

            arabam.ArabaModelID =Convert.ToInt32 (Session["secilenmodel"]);
            arabam.YakıtID = Convert.ToInt32(Session["secilenyakıt"]);
            arabam.VitesID = Convert.ToInt32(Session["secilenvites"]);
            arabam.SegmentID = Convert.ToInt32(Session["secilensegment"]);
        }

        public decimal toplamFiyat(Araba araba, DateTime _iadeTarihi, DateTime _alisTarihi)
        {
            TimeSpan span = _iadeTarihi - _alisTarihi;

            double günSayısı = span.TotalDays;

            int aySayisi = 0;
            int haftaSayisi = 0;
            int gunSayisi = 0;


            if (günSayısı >= 30)
            {
                aySayisi = Convert.ToInt32(günSayısı / 30);
                günSayısı = günSayısı % 30;
            }
            if (günSayısı >= 7)
            {
                haftaSayisi = Convert.ToInt32(günSayısı / 7);
                günSayısı = günSayısı % 7;
            }
            gunSayisi = Convert.ToInt32(günSayısı);


            int aylikUcret = aySayisi * Convert.ToInt32(araba.Ucret.AylikUcret);
            int haftalikUcret = haftaSayisi * Convert.ToInt32(araba.Ucret.HaftalikUcret);
            int gunlukUcret = gunSayisi * Convert.ToInt32(araba.Ucret.GunlukUcret);

            return gunlukUcret + haftalikUcret + aylikUcret;
           
        }
    }
}