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
    public partial class frm_add_product : Form
    {
        public string state = "add";

        BessLayur.ClassAddProduct prd = new BessLayur.ClassAddProduct();
        public frm_add_product()
        {
            InitializeComponent();
            cmbCategories.DataSource = prd.get_all_categories();
            cmbCategories.DisplayMember = "Description_Cat";
            cmbCategories.ValueMember = "ID_Cat";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                MemoryStream ms = new MemoryStream();
                PicB.Image.Save(ms, PicB.Image.RawFormat);
                byte[] byteImage = ms.ToArray();
                prd.add_product(Convert.ToInt32(cmbCategories.SelectedValue), txtDes.Text, txtRef.Text
                    , Convert.ToInt32(txtQte.Text), txtPrice.Text, byteImage);

                MessageBox.Show("تمت الإضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                PicB.Image.Save(ms, PicB.Image.RawFormat);
                byte[] byteImage = ms.ToArray();
                prd.update_Product(Convert.ToInt32(cmbCategories.SelectedValue), txtDes.Text, txtRef.Text
                    , Convert.ToInt32(txtQte.Text), txtPrice.Text, byteImage);

                MessageBox.Show("تم التحديث بنجاح ", "عملية التحديث", MessageBoxButtons.OK
                                , MessageBoxIcon.Information);

            }

            frm_Products.getMainForm.dataGridView1.DataSource = prd.get_all_products();


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور | *.jpg; *.jpeg; *.png; *.bmp ";
            if(ofd.ShowDialog()== DialogResult.OK)
            {
                PicB.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void txtRef_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = prd.Verify_ProductID(txtRef.Text);
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show("يوجد صنف يحمل نفس الاسم ", "تنبيـــــه", MessageBoxButtons.OK
                                , MessageBoxIcon.Warning);
                    txtRef.Focus();
                    txtRef.SelectionStart = 0;
                    txtRef.SelectionLength = txtRef.TextLength;
                }
            }
        }
    }
}
