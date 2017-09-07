using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Demo.Converters.SRP
{
    /*
     * SRP - Single Responsability Principle
     * 
     * A class should have one and only one reason to change, meaning that a class should only have one job.
     * */

    public class ArabicToCardinalConverter
    {
        public String Convert(int IncomeNumber)
        {
            if (IncomeNumber < 0 || IncomeNumber > 99)
                throw new NotSupportedException("Numbers should be Integers between 0 and 99.");

            string[] CardinalUnits = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eightteen", "Nineteen" };
            string[] CardinalTens = new string[] { "Zero", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            String OutcomeNumber;

            if (MathUtils.IsATen(IncomeNumber))
                OutcomeNumber = CardinalTens[MathUtils.GetQuotientOfDivisionBy10(IncomeNumber)];
            else if (IncomeNumber < 20)
                OutcomeNumber = CardinalUnits[IncomeNumber];
            else
            {
                Int32 Ten = MathUtils.GetQuotientOfDivisionBy10(IncomeNumber);
                Int32 Remainder = MathUtils.GetRemainderOfDivisionBy10(IncomeNumber);

                OutcomeNumber = CardinalTens[Ten] + CardinalUnits[Remainder];
            }

            return OutcomeNumber;

        }
    }
}
