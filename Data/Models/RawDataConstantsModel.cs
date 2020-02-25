using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class RawDataConstantsModel
    {
        public string Name { get; set; }
        public List<double[]> AvgRotation { get; set; }
        public List<double[]> AccumRotation { get; set; }
        public List<double[]> AvgPodst { get; set; }
    }
}
