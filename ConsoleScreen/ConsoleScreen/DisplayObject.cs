using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScreen
{
    public abstract class DisplayObject
    {
        public ScreenCoord Coordinates { get; set; }
        public Padding Padding { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        private const int STD_WIDTH = 80;
        private const int STD_HEIGHT = 50;

        public DisplayObject()
        {
            Width = STD_WIDTH;
            Height = STD_HEIGHT;
        }

    }
}
