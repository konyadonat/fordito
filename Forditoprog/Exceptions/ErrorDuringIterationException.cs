using System;
using System.Collections.Generic;
using System.Text;

namespace Forditoprog
{
    class ErrorDuringIterationException:Exception
    {
        public ErrorDuringIterationException():base(String.Format("Hiba az iterlálás közben!"))
        {

        }
    }
}
