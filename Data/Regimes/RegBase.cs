using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Regimes
{
    public abstract class RegBase
    {
        public byte[] BinaryData {get; protected set;}
       
        public bool IsValid { get; protected set; }
        public  int  RegSize { get; set; }
        abstract public bool Parse(byte[] regData);
        abstract public byte[] Serialize();
    }
}
