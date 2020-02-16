using Data.Regimes.Actions;
using Data.Regimes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Regimes.ConcreteRegimes
{
    class Reg10 : RegBase, IGyro, ISync
    {
        public double[] Gyro { get; set; }
        public int CurrentN { get; set; }
        public int MaxN { get; }
        public bool IsSync { get; }

        private IGyroAction getGyros;
        private ISyncAction checkSync;
        public Reg10(byte[] regData, Reg10 prev = null)
        {
            base.BinaryData = regData;
            base.RegSize = 42;
            MaxN = 64;
            getGyros = new GyroActionImpulses();
            checkSync = new SyncAction();

            IsSync = checkSync.IsSync(this, prev);
            Gyro = getGyros.DoWork(regData, 16);
        }

        public override bool Parse(byte[] regData)
        {
            if (regData[0] == 0xff)
            {
                return true;
            }

            return false;
        }

        public override byte[] Serialize()
        {
            return new byte[4];
        }
    }
}
