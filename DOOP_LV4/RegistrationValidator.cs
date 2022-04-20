using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_LV4
{
    class RegistrationValidator:IRegistrationValidator
    {
        private IPasswordValidatorService passwordValidator;
        private IEmailValidatorService emailValidator;
        
        public RegistrationValidator()
        {
            passwordValidator = new PasswordValidator(5);
            emailValidator = new EmailValidator();
        }
        public bool IsUserEntryValid(UserEntry entry)
        {
            return
                passwordValidator.IsValidPassword(entry.Password) &&
                emailValidator.IsValidAddress(entry.Email);
        }
    }
}
