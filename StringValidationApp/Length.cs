using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidationApp
{
    public class Length : IValidate
    {
        public bool IsValidString(string data)
        {
            if (data.Length > 8)
            {
                return false;
            }
            return true;
        }
    }
}