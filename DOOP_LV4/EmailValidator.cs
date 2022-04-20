using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_LV4
{
    class EmailValidator : IEmailValidatorService
    {
        public bool IsValidAddress(String candidate)
        {
            return 
                candidate.Contains("@") && 
                (candidate.EndsWith(".com") || candidate.EndsWith(".hr"));
        }
    }
}
