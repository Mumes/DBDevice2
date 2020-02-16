using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class BinaryDataFileModel
    {
        public string FullPath { get; set; }
        public string Directory { get; set; }

        public ConcurrentQueue<byte> BinaryData {get;set;}

        public BinaryDataFileModel()
        {
            BinaryData = new ConcurrentQueue<byte>();
        }
    }
}
