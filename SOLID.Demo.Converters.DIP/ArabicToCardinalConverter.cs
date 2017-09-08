using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Demo.Converters.DIP
{
    // NOT FINISHED

    /*
     * DIP - Dependency Inversion Principle
     * 
     * Entities must depend on abstractions not on concretions. It states that the high level module must not depend on the low level module, but they should depend on abstractions.
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

        public override string Convert(string number)
        {
            throw new NotImplementedException();
        }

    }
}
