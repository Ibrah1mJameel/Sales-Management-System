using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccountingSystem.BessLayur
{
    class Class_Orders
    {
        public DataTable get_last_order_id()
        {
            DataAccLayur.DataAccessLayur DAL = new DataAccLayur.DataAccessLayur();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("get_last_order_id", null);
            DAL.close();
            return Dt;
        }
    }
}
