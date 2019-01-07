using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace Lohith_1622120_WA
{
    public partial class ManageProduct : System.Web.UI.Page
    {
        ClassDAL classDAL = new ClassDAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void UpdateButton_Click(object sender, EventArgs e)
        {
          
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            int ProdID = Convert.ToInt32(DeleteItemTB.Text);
            classDAL.DeleteProd(ProdID);
        }
    }
}