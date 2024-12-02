using OWPFilmoviProjekat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OWPFilmoviProjekat.ViewModels
{
    public class newCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}