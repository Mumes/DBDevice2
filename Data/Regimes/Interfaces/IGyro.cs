using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Regimes.Interfaces
{
    interface IGyro<T> 
    {
        T[] Gyro { get;  set; }
        //void GetGyro(int start, );
    }
}
