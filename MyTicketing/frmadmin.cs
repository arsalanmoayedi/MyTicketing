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
    public partial class frmadmin : Form
    {
        ITicketingRepository Repository;
        public frmadmin()
        {
            InitializeComponent();
            Repository = new TicketingRepository();
        }
        private void BindGrid()
        {
            dgadmin.AutoGenerateColumns = false;
            dgadmin.DataSource = Repository.SelectAll();
        }

        private void frmadmin_Load(object sender, EventArgs e)
        {
            BindGrid();
           
        }

        private void btnrefrshadmin_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnseeticketaddmin_Click(object sender, EventArgs e)
        {
            frmaddticket seefrm = new frmaddticket();
            seefrm.ShowDialog();
            if (DialogResult==DialogResult.OK)
            {
                BindGrid();
            }
        }
    }
}
