using Data.Models;
using Data.Regimes;
using Data.Regimes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.RawConstants
{
    public class ReadRawConstantsFromList:IReadRawConstants
    {      
        public RawDataConstantsModel RawDataConstants { get ; set ; }
        public ReadRawConstantsFromList(IEnumerable<RegBase> list, string name)
        {
            RawDataConstants = new RawDataConstantsModel();
            RawDataConstants.Name = name;          
        }

        private double[] GetAvg()
        { 
            
        }

        private double[] GetAccum()
        { 
        
        }
    }
}
