using Data.Regimes.Actions;
using Data.Regimes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Regimes.ConcreteRegimes
{
    class Reg10 : RegBase, IGyro, ISync,IParams
    {
        public double[] Gyro { get; set; }
        public int CurrentN { get; set; }
        public int MaxN { get; }
        public bool IsSync { get; }
        public int Moda { get; set ; }
        public int Mm { get ; set; }
        public int Rs { get ; set ; }
        public int Asrp { get ; set ; }

        private IGyroAction getGyros;
        private ISyncAction checkSync;
        private IParamsAction getParams;
        public Reg10()
        {
            base.RegSize = 42;
            MaxN = 64;
            getGyros = new GyroActionImpulses();
            checkSync = new SyncAction();
            getParams = new ParamsActionReg10();
            //IsSync = checkSync.IsSync(this, prev);            
        }

        public override bool Parse(byte[] regData)
        {
            if (regData[0] != 10)
            {
                return false;
            }
            BinaryData = regData;
            Gyro =getGyros.DoWork(BinaryData,8);
            IParams p = getParams.DoWork(BinaryData, 4);
            Mm = p.Mm;
            Moda = p.Moda;
            CurrentN = p.CurrentN;
            Rs = p.Rs;
            Asrp = p.Asrp;
            //(IParams)this = getParams.DoWork(BinaryData, 4);

            return true;
        }

        void stetup(IParams par)
        { 
        
        }
        public override byte[] Serialize()
        {
            return new byte[4];
        }
    }
}
