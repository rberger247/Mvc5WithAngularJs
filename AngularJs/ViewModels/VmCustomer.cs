using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AngularJs.Models;

namespace AngularJs.ViewModels
{
    public class VmCustomer
    {
        public IEnumerable<MemershipType> MembershipTypes{ get; set; }
        public Customer Customer { get; set; }
        public List<Customer> ListOfCustomers { get; set; }
    }
}