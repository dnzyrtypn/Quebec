using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuebecRentACar
{
    public partial class Drivers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnarteon_Click(object sender, EventArgs e)
        {
            OturumAç oturum = (OturumAç)Session["SignInMail"];
            OturumAç oturum1 = (OturumAç)Session["SignInPassword"];

            if (Session["SignInMail"] == null && Session["SignInPassword"] == null)
            {
                Response.Redirect("OturumAç.aspx");
            }
            else
            Response.Redirect("MüşteriBilgileri.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OturumAç oturum = (OturumAç)Session["SignInMail"];
            OturumAç oturum1 = (OturumAç)Session["SignInPassword"];
            if (Session["SignInMail"] == null && Session["SignInPassword"] == null)
            {
                Response.Redirect("OturumAç.aspx");
            }
            else
            Response.Redirect("MüşteriBilgileri.aspx");
        }

        protected void btnbmw_Click(object sender, EventArgs e)
        {
            OturumAç oturum = (OturumAç)Session["SignInMail"];
            OturumAç oturum1 = (OturumAç)Session["SignInPassword"];
            if (Session["SignInMail"] == null && Session["SignInPassword"] == null)
            {
                Response.Redirect("OturumAç.aspx");
            }
            else
            Response.Redirect("MüşteriBilgileri.aspx");
        }

        protected void btnaudi_Click(object sender, EventArgs e)
        {
            OturumAç oturum = (OturumAç)Session["SignInMail"];
            OturumAç oturum1 = (OturumAç)Session["SignInPassword"];
            if (Session["SignInMail"] == null && Session["SignInPassword"] == null)
            {
                Response.Redirect("OturumAç.aspx");
            }
            else
            Response.Redirect("MüşteriBilgileri.aspx");
        }

        protected void btnbmw540_Click(object sender, EventArgs e)
        {
            OturumAç oturum = (OturumAç)Session["SignInMail"];
            OturumAç oturum1 = (OturumAç)Session["SignInPassword"];
            if (Session["SignInMail"] == null && Session["SignInPassword"] == null)
            {
                Response.Redirect("OturumAç.aspx");
            }
            else
            Response.Redirect("MüşteriBilgileri.aspx");
        }

        protected void btnmercedesE_Click(object sender, EventArgs e)
        {
            OturumAç oturum = (OturumAç)Session["SignInMail"];
            OturumAç oturum1 = (OturumAç)Session["SignInPassword"];
            if (Session["SignInMail"] == null && Session["SignInPassword"] == null)
            {
                Response.Redirect("OturumAç.aspx");
            }
            else
            Response.Redirect("MüşteriBilgileri.aspx");
        }

        protected void btnbentley_Click(object sender, EventArgs e)
        {
            OturumAç oturum = (OturumAç)Session["SignInMail"];
            OturumAç oturum1 = (OturumAç)Session["SignInPassword"];
            if (Session["SignInMail"] == null && Session["SignInPassword"] == null)
            {
                Response.Redirect("OturumAç.aspx");
            }
            else
            Response.Redirect("MüşteriBilgileri.aspx");
        }

        protected void btnrolls_Click(object sender, EventArgs e)
        {
            OturumAç oturum = (OturumAç)Session["SignInMail"];
            OturumAç oturum1 = (OturumAç)Session["SignInPassword"];
            if (Session["SignInMail"] == null && Session["SignInPassword"] == null)
            {
                Response.Redirect("OturumAç.aspx");
            }
            else
            Response.Redirect("MüşteriBilgileri.aspx");
        }

        protected void btnmustang_Click(object sender, EventArgs e)
        {
            OturumAç oturum = (OturumAç)Session["SignInMail"];
            OturumAç oturum1 = (OturumAç)Session["SignInPassword"];
            if (Session["SignInMail"] == null && Session["SignInPassword"] == null)
            {
                Response.Redirect("OturumAç.aspx");
            }
            else
            Response.Redirect("MüşteriBilgileri.aspx");
        }

        protected void btnpagani_Click(object sender, EventArgs e)
        {
            OturumAç oturum = (OturumAç)Session["SignInMail"];
            OturumAç oturum1 = (OturumAç)Session["SignInPassword"];
            if (Session["SignInMail"] == null && Session["SignInPassword"] == null)
            {
                Response.Redirect("OturumAç.aspx");
            }
            else
            Response.Redirect("MüşteriBilgileri.aspx");
        }

        protected void btnlamb_Click(object sender, EventArgs e)
        {
            OturumAç oturum = (OturumAç)Session["SignInMail"];
            OturumAç oturum1 = (OturumAç)Session["SignInPassword"];
            if (Session["SignInMail"] == null && Session["SignInPassword"] == null)
            {
                Response.Redirect("OturumAç.aspx");
            }
            else
            Response.Redirect("MüşteriBilgileri.aspx");
        }

        protected void btnmclarn_Click(object sender, EventArgs e)
        {
            OturumAç oturum = (OturumAç)Session["SignInMail"];
            OturumAç oturum1 = (OturumAç)Session["SignInPassword"];
            if (Session["SignInMail"] == null && Session["SignInPassword"] == null)
            {
                Response.Redirect("OturumAç.aspx");
            }
            else
            Response.Redirect("MüşteriBilgileri.aspx");
        }
    }
}