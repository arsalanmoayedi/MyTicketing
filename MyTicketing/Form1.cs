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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool ValidateInput()
        {
            if (txtusername.Text=="")
            {
                MessageBox.Show(" لطفا نام کاربری را وارد کنید ", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtpassword.Text == "")
            {
                MessageBox.Show(" لطفا رمز عبور را وارد کنید ", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text=="arsalanmoayedi" && txtpassword.Text=="amir1234" )
            {
                frmadmin frmadmin = new frmadmin();
                frmadmin.ShowDialog();
            }
            if (txtusername.Text == "arsalanmoayedi"&& txtpassword.Text != "amir1234")
            {
                MessageBox.Show(" رمز عبور اشتباه هست ", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(txtusername.Text != "arsalanmoayedi" )
            {
              if(ValidateInput())
                {
                    frmuser frmuser = new frmuser();
                    frmuser.ShowDialog();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
