using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class InputConverter
    {
        public double ConvertInputToNumber(string argTextInput)
        {
            double convertedNumber;

            if (!double.TryParse(argTextInput, out convertedNumber))
            {
                throw new ArgumentException("Expected a numeric value.");
            }
            else
            {
                return convertedNumber;
            }
        }
    }
}
