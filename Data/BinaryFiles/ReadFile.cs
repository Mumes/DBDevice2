using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Data.Regimes;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using Data.Models;

namespace Data.BinaryFiles
{
    public class ReadFile
    {
        public List<ConcurrentQueue<byte>> BinaryDataFiles;

        public static bool VerifyPath(String path)
        {
            if (string.IsNullOrEmpty(path))
                return false;
            var directoryName = new FileInfo(path).DirectoryName;
         return directoryName != null && new DirectoryInfo(directoryName).Exists;
        }

        public Task<BinaryDataFileModel> ReadFileAsync(string path)
        {
            return Task.Run(() =>
            {
                var bdfm = new BinaryDataFileModel
                {
                    FullPath = path,
                    Directory = new FileInfo(path).Directory.Name
                };

                byte[] queue;
                using (var fs = new FileStream(path, FileMode.Open))
                {
                    queue = new byte[fs.Length];
                    var result = fs.Read(queue, 0, (int)fs.Length);
                }
                bdfm.BinaryData = new ConcurrentQueue<byte>(queue);
                return bdfm;
            }
             );
        }
    }
}
