using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace Merchandising.Application.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<string> validationErrors { get; set; }
        public ValidationException(ValidationResult validationResult)
        {
            validationErrors = new List<string>();
            foreach (var validationError in validationResult.Errors)
            {
                validationErrors.Add(validationError.ErrorMessage);
            }
        }
    }
}
