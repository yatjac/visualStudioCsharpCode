using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rentalPropertyManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<aptLeaseValue> list = aptLeaseDB.GetAllApartmentLeases();

            dgvAptLeases.DataSource = list;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            newLeaseForm form = new newLeaseForm();
            DialogResult r = form.ShowDialog();
            if (r == DialogResult.OK)
            {
                List<aptLeaseValue> listAptLease = aptLeaseDB.GetAllApartmentLeases();

                dgvAptLeases.DataSource = listAptLease;
            }
        }

        private void cbxTenantId_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<aptLeaseValue> list = aptLeaseDB.GetApartmentLeasesByTenantId(cbxTenantId.Text);
            dgvAptLeases.DataSource = list;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            List<aptLeaseValue> list = aptLeaseDB.GetAllApartmentLeases();
            dgvAptLeases.DataSource = list;
        }
    }
}
