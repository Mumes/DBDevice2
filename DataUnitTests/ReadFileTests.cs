using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.BinaryFiles;
using System.Collections.Concurrent;
using Data.Models;
using System.Collections.Generic;
using Data.Regimes;
using System;

namespace DataUnitTests
{
    [TestClass]
    public class ReadFileTests
    {
      
        [TestMethod]
        public void TestMethod2()
        {
            string xx = @"H:\X.mki";
            var readFile = new ReadFile();

            var result =readFile.ReadFileAsync(xx).Result;
           
        }

        List<IEnumerable<RegBase>> list;
        BinaryDataFileModel q;
        ReadDirectory readDirectory;
        void FileAddedEvent(object s,EventArgs e)
        {
            readDirectory.bddm.BinaryDataDirectory.TryDequeue(out q);
            RegFileFactory factory = new RegFileFactory(q.BinaryData);
            list.Add(factory.Create());
        }

        [TestMethod]
        public void TestReadDirectory()
        {
           
            list = new List<IEnumerable<RegBase>>();
            string path = @"H:\testBinaryFiles";

            readDirectory = new ReadDirectory();
            var r = readDirectory.ReadFullDirectory(path);
            
            readDirectory.FileAddEvent += FileAddedEvent;

           var ff= r.Result;
            
        }

    }
}
