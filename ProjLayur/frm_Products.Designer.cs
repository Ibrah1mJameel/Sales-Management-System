namespace AccountingSystem.ProjLayur
{
    partial class frm_Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_SaveOut = new System.Windows.Forms.Button();
            this.btn_printAll = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_img = new System.Windows.Forms.Button();
            this.btn_Ipdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "أدخـــل نص البحــــــث:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(250, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(228, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 226);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لائحة المنتجات";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(659, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btn_Exit);
            this.groupBox2.Controls.Add(this.btn_SaveOut);
            this.groupBox2.Controls.Add(this.btn_printAll);
            this.groupBox2.Controls.Add(this.btn_Print);
            this.groupBox2.Controls.Add(this.btn_img);
            this.groupBox2.Controls.Add(this.btn_Ipdate);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 95);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليـــــــات المتـــــــاحة";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(56, 63);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "خـــــــروج";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // btn_SaveOut
            // 
            this.btn_SaveOut.Location = new System.Drawing.Point(320, 63);
            this.btn_SaveOut.Name = "btn_SaveOut";
            this.btn_SaveOut.Size = new System.Drawing.Size(152, 23);
            this.btn_SaveOut.TabIndex = 6;
            this.btn_SaveOut.Text = "حفظ اللائحة في ملف خارجي";
            this.btn_SaveOut.UseVisualStyleBackColor = true;
            this.btn_SaveOut.Click += new System.EventHandler(this.btn_SaveOut_Click);
            // 
            // btn_printAll
            // 
            this.btn_printAll.Location = new System.Drawing.Point(6, 18);
            this.btn_printAll.Name = "btn_printAll";
            this.btn_printAll.Size = new System.Drawing.Size(114, 23);
            this.btn_printAll.TabIndex = 5;
            this.btn_printAll.Text = "طبــــاعة كل المنتجات";
            this.btn_printAll.UseVisualStyleBackColor = true;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(126, 19);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(80, 23);
            this.btn_Print.TabIndex = 4;
            this.btn_Print.Text = "طبـــــاعة";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // btn_img
            // 
            this.btn_img.Location = new System.Drawing.Point(212, 19);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(102, 23);
            this.btn_img.TabIndex = 3;
            this.btn_img.Text = "صورة المنتج";
            this.btn_img.UseVisualStyleBackColor = true;
            this.btn_img.Click += new System.EventHandler(this.btn_img_Click);
            // 
            // btn_Ipdate
            // 
            this.btn_Ipdate.Location = new System.Drawing.Point(320, 19);
            this.btn_Ipdate.Name = "btn_Ipdate";
            this.btn_Ipdate.Size = new System.Drawing.Size(117, 23);
            this.btn_Ipdate.TabIndex = 2;
            this.btn_Ipdate.Text = "تعــــــديل البيــــــانات";
            this.btn_Ipdate.UseVisualStyleBackColor = true;
            this.btn_Ipdate.Click += new System.EventHandler(this.btn_Ipdate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(443, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "حـــــــــذف";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "إضـــــافة منتج جديد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(695, 371);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "frm_Products";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة المنتجات";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_img;
        private System.Windows.Forms.Button btn_Ipdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_printAll;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_SaveOut;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}