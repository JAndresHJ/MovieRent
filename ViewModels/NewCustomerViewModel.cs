using MovieRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRent.ViewModels
{
    public class NewCustomerViewModel
    {
        // IEnumerable because all we need is a way to iterate over the membership types
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}