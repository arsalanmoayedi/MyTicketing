using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTicketing
{
    public partial class frmaddticket : Form
    {
        ITicketingRepository Repository;
        public int contactid = 0;
        public frmaddticket()
        {
            InitializeComponent();
            Repository = new TicketingRepository();
        }

        private bool ValidateInput()
        {
            if (txtname.Text=="")
            {
                MessageBox.Show(" لطفا نام را وارد کنید ", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtfamily.Text == "")
            {
                MessageBox.Show(" لطفا فامیلی را وارد کنید ", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtphonenumber.Text == "")
            {
                MessageBox.Show(" لطفا تلفن را وارد کنید ", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtemail.Text == "")
            {
                MessageBox.Show(" لطفا ایمیل را وارد کنید ", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txttitle.Text == "")
            {
                MessageBox.Show(" لطفا عنوان را وارد کنید ", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtdescription.Text == "")
            {
                MessageBox.Show(" لطفا توضیحات را وارد کنید ", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void frmaddticket_Load(object sender, EventArgs e)
        {
            if (contactid == 0)
            {
                this.Text = "اضافه تیکت";
            }
            else
            {
                this.Text = "نمابش دیدن جواب";
                DataTable dg = Repository.SelectRow(contactid);
                txtname.Text = dg.Rows[0][1].ToString();
                txtfamily.Text = dg.Rows[0][2].ToString();
                txtphonenumber.Text = dg.Rows[0][3].ToString();
                txtemail.Text = dg.Rows[0][4].ToString();
                txttitle.Text = dg.Rows[0][5].ToString();
                txtdescription.Text = dg.Rows[0][6].ToString();
                btnsubmitticket.Text = "دیدن جواب";
            }
        }
        private void btnsubmitticket_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                bool inssucces;
                if (contactid==0)
                {
                    Repository.Insert(txtname.Text, txtfamily.Text, txtphonenumber.Text, txtemail.Text, txttitle.Text, txtdescription.Text);
                    inssucces = true;
                }
                else
                {
                    MessageBox.Show("برگرد عقب داش");
                    inssucces = true;
                }
               
                if (inssucces==true)
                {
                    MessageBox.Show(" عملیات با موفقیت انجام شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(" عملیات با موفقیت انجام نشد", "ناموفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                
            }
        }

    }
}
