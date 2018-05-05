using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleScreen
{
    public class InputReader
    {
        public Thread InputThread { get; set; }

        public delegate void KeyboardEventHandler(ConsoleKeyInfo CKI);
        public event KeyboardEventHandler KeyboardEvent;

    }
}
