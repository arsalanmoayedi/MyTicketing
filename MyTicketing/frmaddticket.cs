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
        private void btnsubmitticket_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                bool issucces = Repository.Insert(txtname.Text, txtfamily.Text, txtphonenumber.Text, txtemail.Text, txttitle.Text, txtdescription.Text);
                if (issucces==true)
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

        private void frmaddticket_Load(object sender, EventArgs e)
        {
            if (contactid==0)
            {
                this.Text = "اضافه تیکت";
            }
        }
    }
}
