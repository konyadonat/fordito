using System;
using System.Collections.Generic;
using System.Text;

namespace Forditoprog
{
    class InvalidTableSyntaxException:Exception
    {

        public InvalidTableSyntaxException():base(String.Format("Helytelen szintaxis tábla!"))
        {

        }
    }
}
