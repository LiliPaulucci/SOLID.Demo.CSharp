﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Demo.Converters.LSP
{
    public abstract class CardinalConverter
    {
        public abstract String Convert(int number);
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
