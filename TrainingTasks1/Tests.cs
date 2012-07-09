using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TrainingTasks1
{
    [TestFixture]
    public class PasswordValidatorTests
    {
        // 1. Should implement 3 rules (must have a number, must have an uppercase letter, must be min of 10 in length). More may be needed later.
        // 2. A Blank password is not valid (First test stub below)
        // 3. If a password is invalid the reason it is invalid should be in the ValidationResult 
        //
        // Notes: Tests should cover all functionality
        //        C# conventions should be followed

        [Test]
        public void A_Blank_Password_Is_Not_Valid()
        {
            IPasswordValidation validation = new PasswordValidators();
            var result = validation.Validate("");

            Assert.False(result.IsValid);
            Assert.AreEqual(result.Message, "Password cannot be blank");
        }


        [Test]
        public void A_Password_Must_Have_A_Number()
        {
            IPasswordValidation validation = new PasswordValidators();
            var result = validation.Validate("aaaaaa");

            Assert.False(result.IsValid);
            Assert.AreEqual(result.Message, "Password must have a number");
        }

    }
}
