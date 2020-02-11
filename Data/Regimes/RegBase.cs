using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Regimes
{
    public abstract class RegBase
    {
        public byte[] BinaryData {get; protected set;}
        public bool IsValid { get; protected set; }
        protected readonly int  regSize;
        abstract public bool Parse(byte[] regData);
        abstract public byte[] Serialize();
    }
}
