using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScreen
{
    public class TextObject : DisplayObject
    {
        public string Text { get; set; }
        public List<ColorSum> Colors { get; set; }

        public TextObject(string Text, ConsoleColor Color)
        {
            this.Text = Text;
            Colors = new List<ColorSum>() { new ColorSum(Color, 0, Text.Length - 1) };
        }

        public TextObject(string Text, List<ColorSum> Colors) 
        {

            this.Text = Text;
            this.Colors = Colors;
        }


    }
}
