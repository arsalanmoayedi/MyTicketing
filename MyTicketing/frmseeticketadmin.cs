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
    public partial class frmseeticketadmin : Form
    {
        ITicketingRepository Repository;
        public int contactid = 0;
        public frmseeticketadmin()
        {
            InitializeComponent();
            Repository = new TicketingRepository();
        }

        private void frmseeticketadmin_Load(object sender, EventArgs e)
        {
            if (contactid != 0)
            {

                DataTable dg = Repository.SelectRow(contactid);
                txtname.Text = dg.Rows[0][1].ToString();
                txtfamily.Text = dg.Rows[0][2].ToString();
                txtphonenumber.Text = dg.Rows[0][3].ToString();
                txtemail.Text = dg.Rows[0][4].ToString();
                txttitle.Text = dg.Rows[0][5].ToString();
                txtdescription.Text = dg.Rows[0][6].ToString();
                txtanswer.Text = dg.Rows[0][7].ToString();

            }
        }

        private void btnSubmitTicket_Click(object sender, EventArgs e)
        {
            bool issucces = Repository.Insertanswer(contactid, txtanswer.Text);
            if (issucces == true)
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
