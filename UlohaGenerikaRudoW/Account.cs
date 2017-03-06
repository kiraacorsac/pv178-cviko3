using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlohaGenerikaRudoW
{
    public struct Account<TDate> /*implementuje IAccount*/
    {

        public override string ToString()
        {
            return string.Format("{0} Balance: {1}", /*created*/, /*balance*/);
        }
    }

    
}
