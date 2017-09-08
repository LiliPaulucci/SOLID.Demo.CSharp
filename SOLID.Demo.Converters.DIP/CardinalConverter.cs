using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Demo.Converters.DIP
{
    public abstract class CardinalConverter
    {
        public virtual String Convert(int number)
        {
            return String.Empty;
        }
        public virtual String Convert(string number)
        {
            return String.Empty;
        }

        //protected abstract String Convert<T>(T number);

        protected virtual string GetCardinalTens(int position)
        {
            return new string[] { "Zero", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" }[position];
        }

        protected virtual string GetCardinalUnits(int position)
        {
            return new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eightteen", "Nineteen" }[position];
        }
    }
}
