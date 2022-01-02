using System;
using System.Collections.Generic;
using System.Text;

namespace Forditoprog
{
    class ModifiedInputInvalidException:Exception
    {
        public ModifiedInputInvalidException():base(String.Format("A kiszámított input végén nincs #!"))
        {

        }
    }
}
