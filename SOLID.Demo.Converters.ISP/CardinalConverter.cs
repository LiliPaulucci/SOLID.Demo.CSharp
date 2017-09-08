using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Demo.Converters.ISP
{
    /*
     * ISP - Interface Segregation Principle
     * 
     * A client should never be forced to implement an interface that it doesn’t use or clients shouldn’t be forced to depend on methods they do not use.
     * */

    public interface IConvertInteger
    {
        String Convert(int number);
    }

    public interface IConvertString
    {
        String Convert(string number);
    }
    public interface IGetCardinals
    {
        string GetCardinalTens(int position);
        string GetCardinalUnits(int position);
    }
    public abstract class CardinalConverter : IGetCardinals
    {
        public virtual string GetCardinalTens(int position)
        {
            return new string[] { "Zero", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" }[position];
        }

        public virtual string GetCardinalUnits(int position)
        {
            return new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eightteen", "Nineteen" }[position];
        }
    }

    public class ArabicToCardinalConverter : CardinalConverter, IConvertInteger
    {
        public virtual String Convert(int number)
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

    public class RomanToCardinalConverter : CardinalConverter, IConvertString
    {
        public string Convert(string number)
        {
            throw new NotSupportedException("Roman numerals are not supported yet.");
        }
    }
}
