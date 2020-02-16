using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class BinaryDataDirectoryModel
    {
        public string FullPath { get; set; }
        public List<BinaryDataFileModel> BinaryDataDirectory { get; set; }

        public BinaryDataDirectoryModel()
        {
            BinaryDataDirectory = new List<BinaryDataFileModel>();
        }
    }
}
