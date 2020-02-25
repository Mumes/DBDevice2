using Data.BinaryFiles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataUnitTests
{
    [TestClass]
    public class RegFileFactoryTests
    {
        [TestMethod]
        public void TestMethod2()
        {
            string xx = @"H:\X.mki";
            var readFile = new ReadFile();
          
            var result = readFile.ReadFileAsync(xx).Result;

            RegFileFactory regFileFactory = new RegFileFactory(result.BinaryData);

            var resultFactory = regFileFactory.Create();


        }
    }
}
