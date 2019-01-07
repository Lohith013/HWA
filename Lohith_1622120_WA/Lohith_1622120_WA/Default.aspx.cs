using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lohith_1622120_WA
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Context.User.IsInRole("Guest"))
            {
                LoggedInUser.Text = "WELCOME " + Context.User.Identity.Name;
            }
           
        }
    }
}