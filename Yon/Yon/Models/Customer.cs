using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yon.Models;
using System.ComponentModel.DataAnnotations;

namespace Yon.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter your name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MemberShipType MemberShipType { get; set; }

        [Display(Name ="Membership Type")]
        public byte MemberShipTypeId { get; set; }

        [Display(Name="Date Of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthday { get; set; }
        
        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
        
    }
}