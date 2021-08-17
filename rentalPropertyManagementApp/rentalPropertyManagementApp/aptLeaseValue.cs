using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentalPropertyManagementApp
{
   public class aptLeaseValue
    {
        private int leaseNumber;
        private int aptNumber;
        private string aptName;
        private decimal monthlyRent;
        private int months;
        private string tenantId;


        public int LeaseNumber { get => leaseNumber; set => leaseNumber = value; }
        public int AptNumber { get => aptNumber; set => aptNumber = value; }
        public string AptName { get => aptName; set => aptName = value; }
        public decimal MonthlyRent { get => monthlyRent; set => monthlyRent = value; }
        public int Months { get => months; set => months = value; }
        public string TenantId { get => tenantId; set => tenantId = value; }

        public decimal getTotalCost()
        {
            return monthlyRent * months;
            
        }
        

    }
}
