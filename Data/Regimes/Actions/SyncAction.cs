using Data.Regimes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Regimes.Actions
{
    class SyncAction : ISyncAction
    {
        public bool IsSync(ISync current, ISync prev)
        {
            if(current==null)
            {
                return false;
            }
            if(prev == null)
            {
                return true;
            }
         
            if (prev.MaxN == prev.CurrentN)
            {
                return (current.CurrentN == 0) ? true : false;
            }
            else if (prev.CurrentN==current.CurrentN-1 )
            {
                return true;
            }
            return false;
        }
    }
}
