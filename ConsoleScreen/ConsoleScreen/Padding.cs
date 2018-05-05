using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScreen
{
    public class Padding
    {
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
        public int Left { get; set; }

        public Padding(int Padding)
        {
            Top = Right = Bottom = Left = Padding;
        }

        public Padding(int PaddingTB, int PaddingRL)
        {
            Top = Bottom = PaddingTB;
            Right = Left = PaddingRL;
        }

        public Padding(int PaddingT, int PaddingRL, int PaddingB)
        {
            Top = PaddingT;
            Right = Left = PaddingRL;
            Bottom = PaddingB;
        }

        public Padding(int PaddingT, int PaddingR, int PaddingB, int PaddingL)
        {
            Top = PaddingT;
            Right = PaddingR;
            Bottom = PaddingB;
            Left = PaddingL;
        }
    }
}
