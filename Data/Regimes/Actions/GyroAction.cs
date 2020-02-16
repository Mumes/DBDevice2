using Data.Regimes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Regimes.Actions
{
    class GyroActionImpulses : IGyroAction
    {
        public double[] DoWork(byte[] reg, int start)
        {
            double[] gyro = new double[3];
            gyro[0] = BitConverter.ToInt16(reg, start);
            gyro[1] = BitConverter.ToInt16(reg, start + 8);
            gyro[2] = BitConverter.ToInt16(reg, start + 16);
            return gyro;
        }
    }

    class GyroActionRadians : IGyroAction
    {

        public double[] DoWork(byte[] reg, int start)
        {
            double[] gyro = new double[3];
            gyro[0] = BitConverter.ToDouble(reg, start);
            gyro[1] = BitConverter.ToDouble(reg, start + 8);
            gyro[2] = BitConverter.ToDouble(reg, start + 16);
            return gyro;
        }
    }

    class GyroActionRadiansSinglePrecision : IGyroAction
    {

        public double[] DoWork(byte[] reg, int start)
        {
            double[] gyro = new double[3];
            gyro[0] = BitConverter.ToSingle(reg, start);
            gyro[1] = BitConverter.ToSingle(reg, start + 4);
            gyro[2] = BitConverter.ToSingle(reg, start + 8);
            return gyro;
        }
    }

}
