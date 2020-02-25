using Data.Regimes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Regimes.Actions
{
    public class ParamsActionReg10 : IParamsAction, IParams
    {
        public int Moda { get ; set; }
        public int Mm { get ; set ; }
        public int CurrentN { get; set ; }
        public int Rs { get ; set ; }
        public int Asrp { get ; set ; }


        public IParams DoWork(byte[] reg, int start)
        {
            CurrentN= (reg[start]) & 0x3F;
            CurrentN = (reg[start]) & 0x3F;
            Rs = (reg[start] >> 6) & 0x1;
            Moda = (reg[start] >> 7)&0x1;
            Mm = (reg[start+1]) & 0x1;
            Asrp = (reg[start + 1]>>1) & 0x1;
            return this;
        }
    }
}
