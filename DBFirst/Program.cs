using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using DBFirst;

namespace DBFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Entities();
            var address = new Address()
            {
                // Although I have added a value for "AddressId", the value in my DB is updated
                // with the next number to come.
                AddressId = 9,
                Street = "Gjurcin Kokale",
                Number = "20",
                PostalCode = "1060",
                City = "Skopje",
                State = "Gjorce Petrov",
                Province = "Hrom",
                Country = "Macedonia",
                IsActive = 1,
                IsDeleted = 0
            };
            context.Addresses.Add(address);
            context.SaveChanges();
        }
    }
}
