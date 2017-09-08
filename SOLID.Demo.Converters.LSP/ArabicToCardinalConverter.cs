using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Demo.Converters.LSP
{

    /*
     * LSP - Liskov Substitution Principle
     * 
     * Let q(x) be a property provable about objects of x of type T. Then q(y) should be provable for objects y of type S where S is a subtype of T.
     * */

    public class ArabicToCardinalConverter : CardinalConverter
    {
        public override String Convert(int number)
        {
            if (number < 0 || number > 99)
                throw new NotSupportedException("Numbers should be Integers between 0 and 99.");

            String OutcomeNumber;

            if (MathUtils.IsATen(number))
                OutcomeNumber = GetCardinalTens(MathUtils.GetQuotientOfDivisionBy10(number));
            else if (number < 20)
                OutcomeNumber = GetCardinalUnits(number);
            else
            {
                Int32 Ten = MathUtils.GetQuotientOfDivisionBy10(number);
                Int32 Remainder = MathUtils.GetRemainderOfDivisionBy10(number);

                OutcomeNumber = GetCardinalTens(Ten) + " " + GetCardinalUnits(Remainder);
            }

            return OutcomeNumber;
        }
    }
}
