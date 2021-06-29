using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidationApp
{
    public class ValidateString
    {
        IValidate _verify;

        public ValidateString(IValidate verify)
        {
            this._verify = verify;
        }
        public bool ValidString(string data)
        {
            return _verify.IsValidString(data);
        }
    }
}