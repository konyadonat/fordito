using System;
using System.Collections.Generic;
using System.Text;

namespace Forditoprog
{
    class PathTooShortException:Exception
    {
        public PathTooShortException():base(String.Format("Az elérési út hossza túl rövid!"))
        {

        }
    }
}
