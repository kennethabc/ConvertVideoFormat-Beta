using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConvertVideoFormat
{
    public class FFMpegHelper
    {

        public void Convert(string inputFile, string outputFile)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "FFMpeg\\bin\\ffmpeg.exe");
            Console.WriteLine(path);
            Console.WriteLine(outputFile);
            Process p = new Process();
            p.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
            p.StartInfo = new ProcessStartInfo(path);
            p.StartInfo.Arguments = string.Format("-i \"{0}\" \"{1}\"", inputFile, outputFile);
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
            p.WaitForExit();
            p.Close();

        }
    }
}
