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
    public partial class frmuser : Form
    {
        ITicketingRepository Repository;
        public frmuser()
        {
            InitializeComponent();
            Repository = new TicketingRepository();
        }
        public void BindeGrid()
        {
            dguser.AutoGenerateColumns = false;
            dguser.DataSource = Repository.SelectAll();
        }
        private void frmuser_Load(object sender, EventArgs e)
        {
            this.Text = "خوش اومدی ";
            BindeGrid();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            BindeGrid();
        }

        private void btnaddticket_Click(object sender, EventArgs e)
        {
            frmaddticket frmaddticket = new frmaddticket();
            frmaddticket.ShowDialog();
            if (frmaddticket.DialogResult==DialogResult.OK)
            {
                BindeGrid();
            }
        }

        private void btndeleteticket_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show(" آیا از حذف تیکت  مطمئن هستید", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
            {
                int delet =Convert.ToInt32( dguser.CurrentRow.Cells[0].Value.ToString());
                Repository.Delete(delet);
            }
            else
            {
                
            }
        }
    }
}
