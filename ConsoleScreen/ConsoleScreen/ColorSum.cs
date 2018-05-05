using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScreen
{
    public class ColorSum
    {
        public ConsoleColor Color { get; set; }
        public int ColorBegin { get; set; }
        public int ColorEnd { get; set; }

        public ColorSum(ConsoleColor Color, int Begin, int End)
        {
            this.Color = Color;
            ColorBegin = Begin;
            ColorEnd = End;
        }
    }
}
