using System;

namespace StringValidationApp
{
    public class EntryPoint
    {
        static void Main(string[] args)
        {


            NullOrEmpty nullOremptystring = new NullOrEmpty();
            ValidateString validate = new ValidateString(nullOremptystring);
            validate.ValidString(null);

            ValidateString validateLength = new ValidateString(new Length());
            validateLength.ValidString("string");

            ValidateString validateStartsWith = new ValidateString(new StartsWithEx());
            validateStartsWith.ValidString("excel");

        }

    }
}