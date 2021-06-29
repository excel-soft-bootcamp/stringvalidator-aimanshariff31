using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidationApp
{
    public class StartsWithEx : IValidate
    {
        public bool IsValidString(string data)
        {
            if (data.StartsWith("ex"))
            {
                return false;
            }
            return true;
        }
    }
}