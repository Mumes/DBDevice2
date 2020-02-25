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
        public event EventHandler FileAddEvent;
        public BinaryDataDirectoryModel bddm { get; set; }
        public ReadDirectory()
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
                    bddm.BinaryDataDirectory.Enqueue(
                        await (new ReadFile().ReadFileAsync(item.FullName))
                        );
                    FileAddEvent?.Invoke(this, EventArgs.Empty);
                }
            }
            return bddm;            
        }
    }
}
