using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Demo.Converters
{
    public class ArabicToCardinalConverter
    {
        public String Convert (int IncomeNumber)
        {
            if (IncomeNumber < 0 || IncomeNumber > 99)
                throw new NotSupportedException("Numbers should be Integers between 0 and 99.");

            string[] CardinalUnits = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eightteen", "Nineteen" };
            string[] CardinalTens = new string[] { "Zero", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            String OutcomeNumber;

            if (IsATen(IncomeNumber))
                OutcomeNumber = CardinalTens[GetQuotientOfDivisionBy10(IncomeNumber)];
            else if (IncomeNumber < 20)
                OutcomeNumber = CardinalUnits[IncomeNumber];
            else
            {
                Int32 Ten = GetQuotientOfDivisionBy10(IncomeNumber);
                Int32 Remainder = GetRemainderOfDivisionBy10(IncomeNumber);

                OutcomeNumber = CardinalTens[Ten] + CardinalUnits[Remainder];
            }

            return OutcomeNumber;
        }

        private bool IsATen(int IncomeNumber)
        {
            return IncomeNumber % 10 == 0;
        }

        private Int32 GetRemainderOfDivisionBy10(int IncomeNumber)
        {
            return IncomeNumber % 10;
        }

        private Int32 GetQuotientOfDivisionBy10(int IncomeNumber)
        {
            return IncomeNumber / 10;
        }
    }
}
