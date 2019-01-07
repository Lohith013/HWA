using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace Lohith_1622120_WA
{
    public partial class AddProduct : System.Web.UI.Page
    {
        ClassDAL classDAL = new ClassDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            ProductCategoryDD.DataSource= classDAL.GetSProdCat();
            ProductCategoryDD.DataTextField = "ProductCategoryName";
            ProductCategoryDD.DataValueField = "ProductCategoryID";
            ProductCategoryDD.DataBind();

        }

    protected void AddButton_Click(object sender, EventArgs e)
        {
            string ProdName = ProdNameTB.Text;
            int ProdCat = Convert.ToInt32(ProductCategoryDD.SelectedValue);
            decimal UnitPrice = Convert.ToDecimal(UnitPriceTB.Text);
            int TotalAvail = Convert.ToInt32(TotalAvailTB.Text);
            DateTime MFGDate = Convert.ToDateTime(MFGDateTB.Text);
            classDAL.AddProduct(ProdName, ProdCat, UnitPrice, TotalAvail, MFGDate);

            SuccessMsgLabel.Text = "Product Inserted Successfully and ID : " + classDAL.ProdID(ProdName, ProdCat);

        }

        protected void ProductCategoryDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}