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
    public partial class MainForm : Form
    {
        private static MainForm frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static MainForm getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new MainForm();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public MainForm()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.المنتجاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمونToolStripMenuItem.Enabled = false;
            this.إنشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.إستعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm frm = new LogInForm();
            frm.ShowDialog();
        }

        private void إضافةمنتججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_add_product frm = new frm_add_product();
            frm.ShowDialog();
        }

        private void إدارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Products frm = new frm_Products();
            frm.ShowDialog();
        }

        private void إدارةالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Categories frm = new frm_Categories();
            frm.ShowDialog();
        }

        private void إدارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Coustomers cust = new frm_Coustomers();
            cust.ShowDialog();
        }

        private void إدارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Orders odr = new frm_Orders();
            odr.ShowDialog();
        }

        private void إدارةالمستخدمونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Users usr = new frm_Users();
            usr.ShowDialog();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هــل تريد الإغلاق فعلاً ؟", "تحـــذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الإغلاق! ", "عملية الإغلاق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
