using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccountingSystem.BessLayur
{
    class ClassAddProduct
    {
        public DataTable get_all_categories()
        {
            DataAccLayur.DataAccessLayur DAL = new DataAccLayur.DataAccessLayur();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("get_all_categories", null);
            DAL.close();
            return Dt;
        }
        public void add_product(int ID_Cat, string Label_Product, string Product_ID
            ,int Quantity, string Price,byte[] img)
        {
            DataAccLayur.DataAccessLayur DAL = new DataAccLayur.DataAccessLayur();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_Cat", SqlDbType.Int);
            param[0].Value = ID_Cat;

            param[1] = new SqlParameter("@Product_ID", SqlDbType.NVarChar,50);
            param[1].Value = Product_ID;


            param[2] = new SqlParameter("@Label", SqlDbType.NVarChar,50);
            param[2].Value = Label_Product;


            param[3] = new SqlParameter("@Qte", SqlDbType.Int);
            param[3].Value = Quantity;


            param[4] = new SqlParameter("@Price", SqlDbType.NVarChar,50);
            param[4].Value = Price;


            param[5] = new SqlParameter("@Image", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("add_product", param);
            DAL.close();

        }
        public DataTable Verify_ProductID(string ID)
        {
            DataAccLayur.DataAccessLayur DAL = new DataAccLayur.DataAccessLayur();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            Dt = DAL.SelectData("Verify_ProductID", param);
            DAL.close();
            return Dt;
        }

        public DataTable get_all_products()
        {
            DataAccLayur.DataAccessLayur DAL = new DataAccLayur.DataAccessLayur();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("get_all_products", null);
            DAL.close();
            return Dt;
        }


        public DataTable SearchProtuct(string ID)
        {
            DataAccLayur.DataAccessLayur DAL = new DataAccLayur.DataAccessLayur();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            Dt = DAL.SelectData("SearchProtuct", param);
            DAL.close();
            return Dt;
        }


        public void delete_Procedure(string ID)
        {
            DataAccLayur.DataAccessLayur DAL = new DataAccLayur.DataAccessLayur();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar,50);
            param[0].Value = ID;

            DAL.ExecuteCommand("delete_Procedure", param);
            DAL.close();

        }


        public DataTable get_img_product(string ID)
        {
            DataAccLayur.DataAccessLayur DAL = new DataAccLayur.DataAccessLayur();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            Dt = DAL.SelectData("get_img_product", param);
            DAL.close();
            return Dt;
        }


        public void update_Product(int ID_Cat, string Label_Product, string Product_ID
    , int Quantity, string Price, byte[] img)
        {
            DataAccLayur.DataAccessLayur DAL = new DataAccLayur.DataAccessLayur();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_Cat", SqlDbType.Int);
            param[0].Value = ID_Cat;

            param[1] = new SqlParameter("@Product_ID", SqlDbType.NVarChar, 50);
            param[1].Value = Product_ID;


            param[2] = new SqlParameter("@Label", SqlDbType.NVarChar, 50);
            param[2].Value = Label_Product;


            param[3] = new SqlParameter("@Qte", SqlDbType.Int);
            param[3].Value = Quantity;


            param[4] = new SqlParameter("@Price", SqlDbType.NVarChar, 50);
            param[4].Value = Price;


            param[5] = new SqlParameter("@Image", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("update_Product", param);
            DAL.close();

        }


    }
}
