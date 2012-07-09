using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TrainingTasks1
{
    class PasswordValidators : IPasswordValidation
    {
  
        public PasswordValidationResult Validate(string password)
        {
            PasswordValidationResult result = new PasswordValidationResult();
            Regex regNumber = new Regex(@"[0-9]+");
            Regex regUpper = new Regex(@"[A-Z]+");
           
            result.IsValid = true;

            if (password.Length < 1)
            {
                result.IsValid = false;
                result.Message = "Password cannot be blank";
                return result;
            }

            if (!regNumber.IsMatch(password))
            {
                result.IsValid = false;
                result.Message = "Password must have a number";
                return result;
            }

            if (!regUpper.IsMatch(password))
            {
                result.IsValid = false;
                result.Message = "Password must have an uppercase";
                return result;
            }

            
            if (!(password.Length > 9))
            {
                result.IsValid = false;
                result.Message = "Password must have at least 10 characters";
                return result;
            }


            return result;

        }
    }
}
