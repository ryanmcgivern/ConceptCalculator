using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept_Calculator
{
    public class Calculator
    {
        private decimal currentValue = 0;

        public bool isValueValid(string newValue)
        {
            decimal test;
            try
            {
                test = Decimal.Parse(newValue);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
