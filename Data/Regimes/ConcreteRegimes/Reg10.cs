using Data.Regimes.Actions;
using Data.Regimes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Regimes.ConcreteRegimes
{
    class Reg10 : RegBase, IGyro<int>
    {
        public int[] Gyro { get;  set; }
        
        public Reg10()
        {
            IBinaryAction<int[]> getGyros = new GyroActionImpulses();
        }

        public override bool Parse(byte[] regData)
        {
            return true;
        }

        public override byte[] Serialize()
        {
            return new byte[4];
        }
    }
}
