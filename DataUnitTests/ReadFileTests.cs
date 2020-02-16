using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.BinaryFiles;

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

        [TestMethod]
        public void TestReadDirectory()
        {

            string path = @"H:\testBinaryFiles";

            var readDirectory = new ReadDirectory();
            var result = readDirectory.ReadFullDirectory(path).Result;
        }

    }
}
