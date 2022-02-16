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
            [-1] = new string[,] { { dot, dot, dot }, { dot, dot, dot }, { dot, dot, dot } },
            [0] = new string[,] { { dot, dash, dot }, { border, dot, border }, { border, dash, border } },
            [1] = new string[,] { { dot, dot, dot }, { dot, dot, border }, { dot, dot, border } },
            [2] = new string[,] { { dot, dash, dot }, { dot, dash, border }, { border, dash, dot } },
            [3] = new string[,] { { dot, dash, dot }, { dot, dash, border }, { dot, dash, border } },
            [4] = new string[,] { { dot, dot, dot }, { border, dash, border }, { dot, dot, border } },
            [5] = new string[,] { { dot, dash, dot }, { border, dash, dot }, { dot, dash, border } },
            [6] = new string[,] { { dot, dash, dot }, { border, dash, dot }, { border, dash, border } },
            [7] = new string[,] { { dot, dash, dot }, { dot, dot, border }, { dot, dot, border } },
            [8] = new string[,] { { dot, dash, dot }, { border, dash, border }, { border, dash, border } },
            [9] = new string[,] { { dot, dash, dot }, { border, dash, border }, { dot, dot, border } },
        };

        public static string[,] getTemplate (int digit)
        {
            return _digitTemplates[digit];
        }
    }
}
