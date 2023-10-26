using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AccountingSystem.ProjLayur
{
    public partial class frm_Categories : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Server=.\SQLEXPRESS; Database = Accounting_SystemDB; Integrated Security = true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        public frm_Categories()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select ID_Cat as 'المــــعرف', Description_Cat as 'الصــــنف' from Categories", sqlcon);
            da.Fill(dt);
            DataGrView.DataSource = dt;
            txtID.DataBindings.Add("text", dt, "المــــعرف");
            txtDesc.DataBindings.Add("text", dt, "الصــــنف");
            bmb = this.BindingContext[dt];
            labelPosition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }
        private void btn_first_Click_1(object sender, EventArgs e)
        {
            bmb.Position = 0;
            labelPosition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تمت الإضافة بنجاح", "الإضـــــافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_add.Enabled = false;
            btn_new.Enabled = true;
            labelPosition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم الحذف بنجاح", "الحـــــذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            labelPosition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;

        }

        private void btn_edit_Click_1(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تمت عملية التعديل بنجاح", "التــــــعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            labelPosition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            labelPosition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void btn_next_Click_1(object sender, EventArgs e)
        {
            bmb.Position += 1;
            labelPosition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;

        }

        private void btn_previus_Click_1(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            labelPosition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;

        }

        private void btn_new_Click_1(object sender, EventArgs e)
        {
            bmb.AddNew();
            btn_new.Enabled = false;
            btn_add.Enabled = true;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            txtID.Text = id.ToString();
            txtDesc.Focus();

        }
    }
}
