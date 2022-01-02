using System;
using System.Collections.Generic;
using System.Text;

namespace Forditoprog
{
    class ModifiedInputEmptyException:Exception
    {
        public ModifiedInputEmptyException():base(String.Format("A kiszámított input üres!"))
        {

        }
    }
}
