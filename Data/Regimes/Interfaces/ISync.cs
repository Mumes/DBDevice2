using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Regimes.Interfaces
{
    interface ISync
    {
        int CurrentN { get; set; }
        int MaxN { get; }

        bool IsSync { get; }
    }
}
