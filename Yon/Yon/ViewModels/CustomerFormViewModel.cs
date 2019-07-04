using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yon.Models;

namespace Yon.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MemberShipType> MemberShipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}