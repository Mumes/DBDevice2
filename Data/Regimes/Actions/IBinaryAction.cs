using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Regimes.Actions
{
    interface IBinaryAction<T>
    {
       T DoWork(byte[] reg, int start);
    }
}
