using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace Lohith_1622120_WA
{
    public partial class ViewProd : System.Web.UI.Page
    {
        ClassDAL classDAL = new ClassDAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ViewButton_Click(object sender, EventArgs e)
        {
            GridView gridView = new GridView();
            string ProdName = ProdNameTB.Text;
            string ProdCat = ProdCatTB.Text;
            gridView.DataSource= classDAL.ViewProd(ProdName, ProdCat);
            gridView.DataBind();

            PlaceHolder1.Controls.Add(gridView);
            
        }
    }
}