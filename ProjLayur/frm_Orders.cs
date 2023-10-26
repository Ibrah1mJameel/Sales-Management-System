using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingSystem.ProjLayur
{
    public partial class frm_Orders : Form
    {
        BessLayur.Class_Orders order = new BessLayur.Class_Orders();
        public frm_Orders()
        {
            InitializeComponent();
        }

        private void frm_Orders_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.txtOrderID.Text = order.get_last_order_id().Rows[0][0].ToString();
            btnNew.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
