using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScreen
{
    public interface ICommunicate:ISynchronizeInvoke
    {
        void HandleKeyboardEvent(ConsoleKeyInfo CKI);
        
    }
}
