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
    public partial class newLeaseForm : Form
    {
        public newLeaseForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int lno = 0;
            int aptno = 0;
            int mo = 0;
            decimal mornt = 0;

            try
            {
                lno = int.Parse(leaseNumberTextBox.Text);
                aptno = int.Parse(aptNumberTextBox.Text);
                mo = int.Parse(monthsTextBox.Text);
                mornt = decimal.Parse(monthlyRentTextBox.Text);

            }
            catch
            {

            }
            aptLeaseValue aL = new aptLeaseValue
            {
                LeaseNumber = lno,
                AptNumber = aptno,
                Months = mo,
                MonthlyRent = mornt,
                AptName = aptNameTextBox.Text,
                TenantId = tenantIdTextBox.Text
            };
            try
            {
                aptLeaseDB.AddApartmentLease(aL);
            }
            catch
            { 
                MessageBox.Show("Lease Amount" + " " + aL.getTotalCost());
            }
        }
    }
}