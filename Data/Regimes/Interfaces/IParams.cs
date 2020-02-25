using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Regimes.Interfaces
{
    public interface IParams
    {
        int Moda { get; set; }

        int Mm { get; set; }

        int CurrentN { get; set; }
        int Rs { get; set; }

        int Asrp { get; set; }
    }
}
