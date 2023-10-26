using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccountingSystem.BessLayur
{
    class cls_Coustomers
    {
        public void add_Customer(string Customer_Name, string Customer_LastName, string Customer_Mobile
    , String @Customer_Address,  byte[] Customer_Photo , string Criterion)
        {
            DataAccLayur.DataAccessLayur DAL = new DataAccLayur.DataAccessLayur();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Customer_Name", SqlDbType.NVarChar,50);
            param[0].Value = Customer_Name;

            param[1] = new SqlParameter("@Customer_LastName", SqlDbType.NVarChar, 50);
            param[1].Value = Customer_LastName;


            param[2] = new SqlParameter("@Customer_Mobile", SqlDbType.NVarChar,50);
            param[2].Value = Customer_Mobile;


            param[3] = new SqlParameter("@Customer_Address", SqlDbType.NVarChar,50);
            param[3].Value = Customer_Address;


            param[4] = new SqlParameter("@Customer_Photo", SqlDbType.Image);
            param[4].Value = Customer_Photo;

            param[5] = new SqlParameter("@Criterios", SqlDbType.NVarChar,50);
            param[5].Value = Criterion;

            DAL.ExecuteCommand("add_Customer", param);
            DAL.close();

        }
        public DataTable get_all_customers()
        {
            DataAccLayur.DataAccessLayur DAL = new DataAccLayur.DataAccessLayur();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("get_all_customers", null);
            DAL.close();
            return Dt;
        }


    }
}
