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
    public partial class DetaylıAra : System.Web.UI.Page
    {
        MarkaManagement _markaManagement = new MarkaManagement();
        ArabaModelManagement _arabaModelManagement = new ArabaModelManagement();
        YakıtTipiManagement _yakıtTipiManagement = new YakıtTipiManagement();
        VitesManagement _vitesManagement = new VitesManagement();
        ArabaSegmentiManagement _arabaSegmentiManagement = new ArabaSegmentiManagement();
        BagajTipiManagement _bagajTipiManagement = new BagajTipiManagement();
        ArabaManagement _arabaManagement = new ArabaManagement();



        int arabaMarkaID = 0;
        int arabaModelID = 0;
        int yakıtID = 0;
        int vitesID = 0;
        int segmentID = 0; 

       


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Marka.DataSource = _markaManagement.GetAll();
                Marka.DataTextField = "MarkaAdi";
                Marka.DataValueField = "MarkaID";
                Marka.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            arabaMarkaID = Convert.ToInt32(Marka.SelectedValue);
            ArabaModel.DataSource = _arabaModelManagement.GetByMarka(arabaMarkaID);
            ArabaModel.DataTextField = "ModelAdı";
            ArabaModel.DataValueField = "ArabaModelID";
            ArabaModel.DataBind();
            ArabaModel.Items.Insert(0, new ListItem("..:: Lütfen Seçiniz ::..", string.Empty));
        }

        protected void Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ArabaModel.SelectedValue))
            {
                Yakıt.DataSource = null;
                Yakıt.DataBind();
            }
            else
            {
                arabaModelID = Convert.ToInt32(ArabaModel.SelectedValue);
                Yakıt.DataSource = _yakıtTipiManagement.GetByArabaModel(arabaModelID);
                Yakıt.DataTextField = "YakıtTipiAdi";
                Yakıt.DataValueField = "YakıtID";
                Yakıt.DataBind();
                Yakıt.Items.Insert(0, new ListItem("..:: Lütfen Seçiniz ::..", string.Empty));
            }
            Session["secilenmodel"] = arabaModelID;

        }

        protected void Yakıt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Yakıt.SelectedValue))
            {

            }
            else
            {
                yakıtID = Convert.ToInt32(Yakıt.SelectedValue);
                Vites.DataSource = _vitesManagement.GetByYakıtTipi(yakıtID);
                Vites.DataTextField = "VitesTipi";
                Vites.DataValueField = "VitesID";
                Vites.DataBind();
                Vites.Items.Insert(0, new ListItem("Lütfen Seçiniz", string.Empty));
            }

            Session["secilenyakıt"] = yakıtID;

        }

        protected void Vites_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Yakıt.SelectedValue))
            {

            }
            else
            {
                vitesID = Convert.ToInt32(Vites.SelectedValue);
                Segment.DataSource = _arabaSegmentiManagement.GetByVitesID(vitesID);
                Segment.DataTextField = "SegmentAdi";
                Segment.DataValueField = "SegmentID";
                Segment.DataBind();
                Segment.Items.Insert(0, new ListItem("Lütfen Seçiniz", string.Empty));
            }
            Session["secilenvites"] = vitesID;

        }

        protected void Segment_SelectedIndexChanged(object sender, EventArgs e)
        {
            segmentID = Convert.ToInt32(Segment.SelectedValue);
            KasaTipi.DataSource = _bagajTipiManagement.GetByArabaSegmenti(segmentID);
            KasaTipi.DataTextField = "BagajTipiAdi";
            KasaTipi.DataValueField = "BagajID";
            KasaTipi.DataBind();
            Session["secilensegment"] = segmentID;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("Kiralama.aspx");
            
        }




    }
}