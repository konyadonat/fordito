using System;
using System.Collections.Generic;
using System.Text;

namespace Forditoprog
{
    class InputEmptyException : Exception
    {
        public InputEmptyException():base(String.Format("Az input nem lehet üres!"))
        {
            
        }
    }
}
