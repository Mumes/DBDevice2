using Data.Regimes.ConcreteRegimes;
using Data.Regimes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Regimes.Actions
{
    interface IParamsAction
    {
        // public Reg10 MyProperty { get; set; }
        IParams DoWork(byte[] reg, int start);
        //{
        //    MyProperty= new Reg10();
        //    return MyProperty;
        //}
    }
}
