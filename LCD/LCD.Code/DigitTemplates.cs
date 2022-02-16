using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCD.Code
{
    internal static class DigitTemplates
    {
        private static string dot = ".";
        private static string dash = "_";
        private static string border = "|";
        private static Dictionary<int, string[,]> _digitTemplates = new Dictionary<int, string[,]>
        {
            [0] = new string[,] { { dot, dot, dot }, { dot, dot, dot }, { dot, dot, dot } },
            [1] = new string[,] { { dot, dot, dot }, { dot, dot, dot }, { dot, dot, dot } },
            [2] = new string[,] { { dot, dot, dot }, { dot, dot, dot }, { dot, dot, dot } },
            [3] = new string[,] { { dot, dot, dot }, { dot, dot, dot }, { dot, dot, dot } },
            [4] = new string[,] { { dot, dot, dot }, { dot, dot, dot }, { dot, dot, dot } },
            [5] = new string[,] { { dot, dot, dot }, { dot, dot, dot }, { dot, dot, dot } },
            [6] = new string[,] { { dot, dot, dot }, { dot, dot, dot }, { dot, dot, dot } },
            [7] = new string[,] { { dot, dot, dot }, { dot, dot, dot }, { dot, dot, dot } },
            [8] = new string[,] { { dot, dot, dot }, { dot, dot, dot }, { dot, dot, dot } },
            [9] = new string[,] { { dot, dot, dot }, { dot, dot, dot }, { dot, dot, dot } },
        };
    }
}
