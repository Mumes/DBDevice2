using Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Data.BinaryFiles
{
    public class ReadDirectory
    {
        private static readonly BinaryDataDirectoryModel bddm;
        static ReadDirectory()
        {
            bddm = new BinaryDataDirectoryModel();
        }
        public async Task<BinaryDataDirectoryModel> ReadFullDirectory(string path)
        {
            bddm.FullPath = path;
            var directoryInfo = new DirectoryInfo(path);

            foreach (var dir in directoryInfo.GetDirectories())
            {
                foreach (var item in dir.GetFiles())
                {
                    bddm.BinaryDataDirectory.Add(
                        await (new ReadFile().ReadFileAsync(item.FullName))
                        );
                }
            }
            return bddm;            
        }
    }
}
