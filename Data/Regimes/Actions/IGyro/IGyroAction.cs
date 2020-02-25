using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Regimes.Actions
{
    interface IGyroAction
    {
       double[] DoWork(byte[] reg, int start);
    }
}
