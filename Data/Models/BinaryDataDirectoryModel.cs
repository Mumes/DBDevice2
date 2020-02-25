using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class BinaryDataDirectoryModel
    {
        public string FullPath { get; set; }
        public ConcurrentQueue<BinaryDataFileModel> BinaryDataDirectory { get; set; }

        public BinaryDataDirectoryModel()
        {
            BinaryDataDirectory = new ConcurrentQueue<BinaryDataFileModel>();
        }
    }
}
