﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Demo.Converters.ISP
{
    public static class MathUtils
    {
        public static bool IsATen(int IncomeNumber)
        {
            return IncomeNumber % 10 == 0;
        }

        public static Int32 GetRemainderOfDivisionBy10(int IncomeNumber)
        {
            return IncomeNumber % 10;
        }

        public static Int32 GetQuotientOfDivisionBy10(int IncomeNumber)
        {
            return IncomeNumber / 10;
        }
    }
}
