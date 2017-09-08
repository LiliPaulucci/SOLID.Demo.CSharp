using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Demo.Converters.DIP
{
    /*
     * DIP - Dependency Inversion Principle
     * 
     * Entities must depend on abstractions not on concretions. It states that the high level module must not depend on the low level module, but they should depend on abstractions.
     * */

    public class CardinalConverter
    {
        private readonly INumeralConverter _numeralConverter;

        public CardinalConverter(INumeralConverter numeralConverter)
        {
            _numeralConverter = numeralConverter;
        }

        public string Convert (string numeral)
        {
            return _numeralConverter.Convert(numeral);
        }
    }
}