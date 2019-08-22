using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = Directory.GetCurrentDirectory();
            //Console.Write(path);
            //Console.ReadKey();
            DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory());

            foreach (DirectoryInfo directoryInfo in directory.GetDirectories())
            {
                string file = directoryInfo.Name;
                file += "/";
                Console.WriteLine(file);
                //Console.WriteLine(@"{0, -30}\ directory", d.Name);
            }

            foreach (FileInfo fileInfo in directory.GetFiles())
            {
                Console.WriteLine(fileInfo.Name);
            }

            Console.ReadKey();
        }
    }
}
