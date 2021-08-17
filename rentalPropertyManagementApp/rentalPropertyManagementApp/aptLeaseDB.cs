using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentalPropertyManagementApp
{
    public static class aptLeaseDB
    {
        public static void AddApartmentLease(aptLeaseValue aL)
        {
            cis3325_studentsEntities container = new cis3325_studentsEntities();

            ApartmentLease apartmentLease = new ApartmentLease
            {
                LeaseNumber = aL.LeaseNumber,
                ApartmentNumber = aL.AptNumber,
                ApartmentName = aL.AptName,
                MonthlyRent = aL.MonthlyRent,
                Months = aL.Months,
                TenantId = aL.TenantId
            };

            try
            {
                container.ApartmentLeases.Add(apartmentLease);
                container.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<aptLeaseValue> GetAllApartmentLeases()
        {
            List<aptLeaseValue> list = new List<aptLeaseValue>();
            cis3325_studentsEntities container = new cis3325_studentsEntities();
            var aptLease = from aL in container.ApartmentLeases select aL;

            foreach (ApartmentLease aL in aptLease)
            {
                aptLeaseValue value = new aptLeaseValue
                {
                    LeaseNumber = (int)aL.LeaseNumber,
                    AptNumber = (int)aL.ApartmentNumber,
                    Months = (int)aL.Months,
                    TenantId = aL.TenantId,
                    AptName = aL.ApartmentName,
                    MonthlyRent = (decimal)aL.MonthlyRent
                };
                list.Add(value);
            }
            return list;
        }
  
        public static aptLeaseValue GetApartmentLease(string tenantId)
        {
            aptLeaseValue a = null;

            cis3325_studentsEntities container = new cis3325_studentsEntities();

            var apartmentLeases = (from aL in container.ApartmentLeases
                                   where aL.TenantId == tenantId
                                   select aL).SingleOrDefault();

            a = new aptLeaseValue
            {
                LeaseNumber = (int)apartmentLeases.LeaseNumber,
                AptNumber = (int)apartmentLeases.ApartmentNumber,
                Months = (int)apartmentLeases.Months,
                TenantId = apartmentLeases.TenantId,
                AptName = apartmentLeases.ApartmentName,
                MonthlyRent = (decimal)apartmentLeases.MonthlyRent
            };
            return a;
        }
        public static List<aptLeaseValue> GetApartmentLeasesByTenantId(string TenantId)
        {
            List<aptLeaseValue> list = new List<aptLeaseValue>();
            cis3325_studentsEntities container = new cis3325_studentsEntities();
            var aptLease = from aL in container.ApartmentLeases
                           where aL.TenantId.ToString() == TenantId
                           select aL;

            foreach (ApartmentLease aL in aptLease)
            {
                string tid = "";

                if (aL.TenantId != null) { tid = aL.TenantId.ToString(); }

                aptLeaseValue value = new aptLeaseValue
                {
                    LeaseNumber = (int)aL.LeaseNumber,
                    AptNumber = (int)aL.ApartmentNumber,
                    Months = (int)aL.Months,
                    TenantId = aL.TenantId,
                    AptName = aL.ApartmentName,
                    MonthlyRent = (decimal)aL.MonthlyRent

                };
                list.Add(value);

            }
            return list;
        }
    }
}
   
