using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CDS2FuncApp.Models;

namespace CDS2FuncApp.Services
{
    public class GETService
    {
        public async Task<List<Customer>> GetCustomers()
        {
            var result = CreateTempCustomers();
            return await Task.FromResult(result);
        }

        public List<Customer> CreateTempCustomers()
        {
            List<Customer> myList = new List<Customer>();

            myList.Add(new Customer { CustomerID = new Guid(), FamilyName = "Burns", GivenName = "Montgomery", DateofBirth = Convert.ToDateTime("01/04/1940") });
            myList.Add(new Customer { CustomerID = new Guid(), FamilyName = "Man", GivenName = "Spider", DateofBirth = Convert.ToDateTime("01/04/1920") });
            myList.Add(new Customer { CustomerID = new Guid(), FamilyName = "America", GivenName = "Captain", DateofBirth = Convert.ToDateTime("01/04/1930") });

            return myList;
        }

        public async Task<bool> UpdateValues()
        {
            return await Task.FromResult(true);
        }
    }
}
