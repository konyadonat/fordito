using System;
using System.Collections.Generic;
using System.Text;

namespace Forditoprog
{
    class PathInvalidException:Exception
    {
        public PathInvalidException():base(String.Format("Az elérési út nem megfelelő!"))
        {

        }
    }
}
