using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AccountingSystem.ProjLayur
{

    public partial class frm_Coustomers : Form
    {
        BessLayur.cls_Coustomers CUST = new BessLayur.cls_Coustomers();

        public frm_Coustomers()
        {
            InitializeComponent();

            this.dataGridView2.DataSource = CUST.get_all_customers();
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[5].Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] Customer_Photo;
                if (PicBox.Image == null)
                {
                    Customer_Photo = new byte[0];
                    CUST.add_Customer(txt_name.Text, txt_lastName.Text, txt_mobile.Text, txt_email.Text, Customer_Photo, "Without_image");
                    MessageBox.Show("تمت الإضافة بنجـــاح", "عملية الإضـــــافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView2.DataSource = CUST.get_all_customers();

                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    PicBox.Image.Save(ms, PicBox.Image.RawFormat);
                    Customer_Photo = ms.ToArray();
                    CUST.add_Customer(txt_name.Text, txt_lastName.Text, txt_mobile.Text, txt_email.Text, Customer_Photo, "With_image");
                    MessageBox.Show("تمت الإضافة بنجـــاح", "عملية الإضـــــافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView2.DataSource = CUST.get_all_customers();

                }

            }
            catch
            {
                return;
            }
        }

        private void PicBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = " ملفات الصور | *.jpg; *.jpeg; *.png; *.bmp ";
            if (op.ShowDialog() == DialogResult.OK)
            {
                PicBox.Image = Image.FromFile(op.FileName);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {

        }

        private void btn_previus_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {

        }

        private void btn_last_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_lastName.Clear();
            txt_mobile.Clear();
            txt_email.Clear();
            PicBox.Image = null;
            txt_name.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_lastName.Focus();
            }
        }

        private void txt_lastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_mobile.Focus();
            }

        }

        private void txt_mobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_email.Focus();
            }

        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.Focus();
            }

        }
    }
}
