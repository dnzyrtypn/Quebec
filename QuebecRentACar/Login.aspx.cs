using RentACar.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuebecRentACar
{
    public partial class Login : System.Web.UI.Page
    {
        UserManagement _userManagement; 
        public Login()
        {
           _userManagement = new UserManagement();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)//sign up
        {
            RentACar.Model.Entities.Sales.User user = new RentACar.Model.Entities.Sales.User();
            user.Sifre = passwordKO.Value;
            user.Mail = emailKO.Value;
            user.CreatedOn = DateTime.Now.Date;


            _userManagement.Add(user);
            Response.Redirect("Araclar.aspx");
           

        }

        protected void Unnamed_Click(object sender, EventArgs e) //sign in
        {
            //string password= passwordOA.Value;
            //string mail = mailOA.Value;
            //_userManagement.GetUserByPasswordandMail(password, mail);
            //Response.Redirect("MüşteriBilgileri.aspx");
            

        }

        
    }
}