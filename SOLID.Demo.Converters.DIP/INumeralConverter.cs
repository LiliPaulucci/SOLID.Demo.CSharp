using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Demo.Converters.DIP
{
    public interface INumeralConverter
    {
        string Convert(string numeral);
    }

    public class ArabicToCardinalConverter : INumeralConverter
    {
        private readonly ITranslator _translator;

        public ArabicToCardinalConverter(ITranslator translator)
        {
            _translator = translator;
        }

        public string Convert(string numeral)
        {
            int number = System.Convert.ToInt32(numeral);

            if (number < 0 || number > 99)
                throw new NotSupportedException("Numbers should be Integers between 0 and 99.");

            String OutcomeNumber;

            if (MathUtils.IsATen(number))
                OutcomeNumber = _translator.GetTens(MathUtils.GetQuotientOfDivisionBy10(number));
            else if (number < 20)
                OutcomeNumber = _translator.GetUnits(number);
            else
            {
                Int32 Ten = MathUtils.GetQuotientOfDivisionBy10(number);
                Int32 Remainder = MathUtils.GetRemainderOfDivisionBy10(number);

                OutcomeNumber = _translator.GetTens(Ten) + " " + _translator.GetUnits(Remainder);
            }

            return OutcomeNumber;
        }
    }

    public class RomanToCardinalConverter : INumeralConverter
    {
        private readonly ITranslator _translator;

        public RomanToCardinalConverter(ITranslator translator)
        {
            _translator = translator;
        }
        public string Convert(string numeral)
        {
            throw new NotSupportedException("Roman numerals are not supported yet.");
        }
    }
}
