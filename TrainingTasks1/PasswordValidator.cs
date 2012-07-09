using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingTasks1
{
    class PasswordValidators : IPasswordValidation
    {
  
        public PasswordValidationResult Validate(string password)
        {
            PasswordValidationResult result = new PasswordValidationResult();

            result.IsValid = true;

            if (password.Length < 1)
            {
                result.IsValid = false;
                result.Message = "Password cannot be blank";
            }

            return result;

        }
    }
}
