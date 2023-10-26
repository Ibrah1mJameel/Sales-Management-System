using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AccountingSystem.ProjLayur
{
    public partial class frm_Products : Form
    {
        private static frm_Products frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frm_Products getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new frm_Products();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        BessLayur.ClassAddProduct prd = new BessLayur.ClassAddProduct();
        public frm_Products()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = prd.get_all_products();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = prd.SearchProtuct(txtSearch.Text);
            this.dataGridView1.DataSource = Dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_add_product frm = new frm_add_product();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل تريد فعلاً حذف المنتج المحدد ؟","عملية الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                prd.delete_Procedure(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Ipdate_Click(object sender, EventArgs e)
        {
            frm_add_product frm = new frm_add_product();
            frm.txtRef.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtDes.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtQte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cmbCategories.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = " تحديث المنتج :" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btn_add.Text = " تحديث ";
            frm.state = "update";
            frm.txtRef.ReadOnly = true;
            byte[] image = (byte[])prd.get_img_product(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ims = new MemoryStream(image);
            frm.PicB.Image = Image.FromStream(ims);
            frm.ShowDialog();
        }

        private void btn_img_Click(object sender, EventArgs e)
        {
            frm_Preview frm = new frm_Preview();
            byte[] image = (byte[])prd.get_img_product(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ims = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ims);
            frm.ShowDialog();

        }

        private void btn_SaveOut_Click(object sender, EventArgs e)
        {

        }
    }
}
