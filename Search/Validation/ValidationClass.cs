/*using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pagination.Validation
{
    public class ValidationClass : ValidationAttribute
    {
        //private new readonly string ErrorMessage;
        //public ValidationClass(string ErrorMessage)
        //{
        //    this.ErrorMessage = ErrorMessage;
        //}
        //public override bool IsValid(object value)
        //{

        //    return base.IsValid(value);
        //}

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                string Name = value.ToString();
                {
                    if(Name.Contains("MVC"))
                    {
                        return ValidationResult.Success;
                    }
                }
            }
            return new ValidationResult("Value is empty");
            //return base.IsValid(value, validationContext);
        }
    }
}
*/