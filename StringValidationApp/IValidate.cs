using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidationApp
{

    public interface IValidate
    {
        bool IsValidString(string data);
    }
}