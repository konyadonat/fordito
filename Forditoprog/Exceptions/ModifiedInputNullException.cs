using System;
using System.Collections.Generic;
using System.Text;

namespace Forditoprog
{
    class ModifiedInputNullException : Exception

    {
        public ModifiedInputNullException() : base(String.Format("A kiszámított input null!"))
        {

        }
    }
}
