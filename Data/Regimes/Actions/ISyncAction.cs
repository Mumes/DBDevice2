using Data.Regimes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Regimes.Actions
{
    interface ISyncAction
    {
        bool IsSync(ISync current, ISync prev);
    }
}
