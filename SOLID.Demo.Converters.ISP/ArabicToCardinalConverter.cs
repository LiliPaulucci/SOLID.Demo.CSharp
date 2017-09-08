using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Demo.Converters.ISP
{
    // NOT FINISHED

    /*
     * ISP - Interface Segregation Principle
     * 
     * A client should never be forced to implement an interface that it doesn’t use or clients shouldn’t be forced to depend on methods they do not use.
     * */

    public class ArabicToCardinalConverter : CardinalConverter
    {
        /*public override string Convert(string number)
        {
            throw new NotImplementedException();
        }*/

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

        public string Convert(string number)
        {
            return this.Convert(System.Convert.ToInt32(number));
        }

    }
}
