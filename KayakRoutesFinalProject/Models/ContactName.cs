using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace KayakRoutesFinalProject.Models
{
    public class contactname : ValidationAttribute, IClientModelValidator
    {
        public contactname()
        {

        }

        public void AddValidation(ClientModelValidationContext context)
        {
            if (!context.Attributes.ContainsKey("data-val"))
                context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-contactname-name", "Alex");
            context.Attributes.Add("data-val-contactname", GetErrorMessage());
        }

        public string GetErrorMessage()
        {
            return "Custom Validation: Do not use your first name";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return value != null && value.ToString() != "AlexWaters" ? ValidationResult.Success : new ValidationResult(GetErrorMessage());
        }
    }
}
