using System;
using System.Collections.Generic;
using System.Text;

namespace Forditoprog
{
    class InputDoesNotHaveHasmarkAtEndException:Exception
    {
        public InputDoesNotHaveHasmarkAtEndException():base(String.Format("Az input végén nincs #!"))
        {

        }
    }
}
