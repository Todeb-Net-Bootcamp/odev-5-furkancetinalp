﻿using FluentValidation;
using System.Linq;

namespace Bussines.Configuration.Extensions
{
    //This method will occur if validation fails in order to show error details. 
    public static class ValidatorExtension
    {
        public static void ThrowIfException(this FluentValidation.Results.ValidationResult validationResult)
        {
            if (validationResult.IsValid)
                return;

            var message = string.Join(',', validationResult.Errors.Select(x => x.ErrorMessage));
            throw new ValidationException(message);
        }
    }
}
