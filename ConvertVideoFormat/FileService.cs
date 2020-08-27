using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConvertVideoFormat
{
    public class FileService
    {
        public List<Files> GetFiles(List<string> fileNames)
        {
            List<Files> files = new List<Files>();
            foreach (var item in fileNames)
            {
                if (File.Exists(item))
                {
                    FileInfo objFile = new FileInfo(item);
                    files.Add(new Files() { FileName = objFile.FullName, CreateDate = objFile.CreationTime, FileFormat = objFile.Extension, FileSize = objFile.Length * 1024 });

                }
            }
            return files;
        }
            
    }
        
}
    

