using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidationApp
{
    public class NullOrEmpty : IValidate
    {
        public bool IsValidString(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return false;
            }
            return true;
        }
    }

}