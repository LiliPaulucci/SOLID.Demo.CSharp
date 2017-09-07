using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Demo.Converters.OCP
{

    /*
     * OCP - Open/Closed Principle
     * 
     * Objects or entities should be open for extension, but closed for modification.
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
