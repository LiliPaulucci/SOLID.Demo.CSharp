using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Demo.Converters.DIP
{
    public interface ITranslator
    {
        string GetTens(int position);
        string GetUnits(int position);
    }

    public class CardinalTranslator : ITranslator
    {
        public string GetTens(int position)
        {
            return new string[] { "Zero", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" }[position];
        }

        public string GetUnits(int position)
        {
            return new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eightteen", "Nineteen" }[position];
        }
    }
}
