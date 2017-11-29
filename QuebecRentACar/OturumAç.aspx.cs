using RentACar.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuebecRentACar
{
    public partial class OturumAç : System.Web.UI.Page
    {
        UserManagement _userManagement;
        public OturumAç()
        {
            _userManagement = new UserManagement();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void btnsignin_Click(object sender, EventArgs e)
        {
            
            string password = passwordOA.Value;
            string mail = mailOA.Value;
            if (_userManagement.GetUserByPasswordandMail(password, mail) == null)
            {
                lblerror.Visible = true;
                lblerror.Text = "E-Mail adresinizi veya Şifrenizi kontrol ediniz.";
            }
            else
            {
                Session["SignInMail"] = mailOA.Value.ToString();
                Session["SignInPassword"] = passwordOA.Value.ToString();
                Response.Redirect("MüşteriBilgileri.aspx");
            }

        }

        protected void btnkayıt_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("Login.aspx");
        }
    }
}