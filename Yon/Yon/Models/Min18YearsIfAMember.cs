using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Yon.Models;

namespace Yon.Models
{
    public class Min18YearsIfAMember:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MemberShipTypeId==Customer.Unknown || customer.MemberShipTypeId == Customer.PayAsYouGo)
                return ValidationResult.Success;
            if (customer.Birthday == null)
                return new ValidationResult("BirthDate is required");
            var age = DateTime.Now.Year - customer.Birthday.Value.Year;
            return (age >= 18) ?
                ValidationResult.Success :
                new ValidationResult("A memeber should be at least 18 years old");

        }
    }
}