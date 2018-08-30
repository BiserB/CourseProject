using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vote.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DateAfterAttribute : ValidationAttribute
    {
        private readonly string nameOfDateField;

        public DateAfterAttribute(string nameOfDateField)
        {
            this.nameOfDateField = nameOfDateField;
        }

        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            if (value == null)
            {
                return new ValidationResult("Value can not be null!");
            }

            DateTime endDate = (DateTime)value;

            var propertyInfo = context.ObjectType.GetProperty(nameOfDateField);

            if (propertyInfo == null)
            {
                return new ValidationResult("Invalid start date property name!");
            }

            var startDate = (DateTime)propertyInfo.GetValue(context.ObjectInstance, null);

            if (startDate > endDate)
            {
                return new ValidationResult("'End date' date must be after 'Start date'!");
            }

            if (endDate < DateTime.Today)
            {
                return new ValidationResult("The 'End date' date must be after today's date!");
            }

            if (endDate > startDate.AddMonths(1))
            {
                return new ValidationResult("Difference between the dates can be maximum 1 month");
            }

            return ValidationResult.Success;
        }
    }
}
