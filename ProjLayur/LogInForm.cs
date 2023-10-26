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
    public partial class LogInForm : Form
    {
        BessLayur.CLS_LOGIN log = new BessLayur.CLS_LOGIN();
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.LOGIN(txtID.Text, txtPass.Text);
            if (Dt.Rows.Count > 0)
            {
                MainForm.getMainForm.المنتجاتToolStripMenuItem.Enabled = true;
                MainForm.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                MainForm.getMainForm.المستخدمونToolStripMenuItem.Enabled = true;
                MainForm.getMainForm.إنشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                MainForm.getMainForm.إستعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show(" فشل تسجيل الدخول !");
            }
        }
    }
}
