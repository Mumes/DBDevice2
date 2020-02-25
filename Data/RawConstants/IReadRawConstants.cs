using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.RawConstants
{
    interface IReadRawConstants
    {
        RawDataConstantsModel RawDataConstants { get; set; }
    }
}
