using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ClassDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        public DataTable ProductCategoryTab = new DataTable();
        public void GetConnection()
        {
            string constr = @"Data Source=DESKTOP-OCTR2UN\SQLEXPRESS;Initial Catalog=hyundai;Integrated Security=True";
            con = new SqlConnection(constr);
        }

        public DataTable ProdCat = new DataTable();
        private SqlConnection connection = new SqlConnection();
        SqlDataAdapter adapter;
        public DataTable GetSProdCat()
        {
            string ConnectionString = @"Data Source=DESKTOP-OCTR2UN\SQLEXPRESS;Initial Catalog=hyundai;Integrated Security=True";
            string sql = "select * from Product_Category_Master";
            adapter = new SqlDataAdapter(sql, ConnectionString);
            adapter.Fill(ProdCat);

            return ProdCat;
        }

        public void AddProduct(string ProductName, int ProdCat, decimal UnitPrice, int TotalAvail, DateTime MFGDate)
        {
            GetConnection();
            con.Open();
            cmd = new SqlCommand("USP_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.Parameters.AddWithValue("@ProductCategoryID", ProdCat);
            cmd.Parameters.AddWithValue("@UnitPrice", UnitPrice);
            cmd.Parameters.AddWithValue("@TotalNumberAvailable", TotalAvail);
            cmd.Parameters.AddWithValue("@MFGDate", MFGDate);

            cmd.ExecuteNonQuery();
            con.Close();

        }
        int ProductID;
        public int ProdID(string ProdName,int ProdCat)
        {
            GetConnection();
            con.Open();
            string sql = "select ProductId from Product where ProductName='"+ProdName+ "' and ProductCategoryID="+ ProdCat;
            SqlCommand sqlCommand = new SqlCommand(sql, con);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {

                    ProductID = Convert.ToInt32((reader["ProductId"].ToString()));
                   }
            }

            return ProductID;
           
        }

        public DataTable ViewProdTab = new DataTable();
        
        public DataTable ViewProd(string ProdName, string ProdCat)
        {
            string ConnectionString = @"Data Source=DESKTOP-OCTR2UN\SQLEXPRESS;Initial Catalog=hyundai;Integrated Security=True";
            string sql = "select* from Product_Category_Master pcm, Product p where pcm.ProductCategoryID = p.ProductCategoryID and p.ProductName = '"+ ProdName + "'and pcm.ProductCategoryName = '"+ ProdCat + "'";
            adapter = new SqlDataAdapter(sql, ConnectionString);
            adapter.Fill(ViewProdTab);

            return ViewProdTab;
        }
         
        public void DeleteProd(int ProdID)
        {
            string ConnectionString = @"Data Source=DESKTOP-OCTR2UN\SQLEXPRESS;Initial Catalog=hyundai;Integrated Security=True";
            string sql = "Delete from Product where ProductId ="+ProdID;
            adapter = new SqlDataAdapter(sql, ConnectionString);
        }

    }
}
