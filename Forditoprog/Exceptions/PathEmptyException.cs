using System;
using System.Collections.Generic;
using System.Text;

namespace Forditoprog
{
    class PathEmptyException:Exception
    {
        public PathEmptyException():base(String.Format("Az elérési út nem lehet üres!"))
        {

        }
    }
}
