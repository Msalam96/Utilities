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
            var itemsList = new List<string>();

            foreach (DirectoryInfo directoryInfo in directory.GetDirectories())
            {
                string file = directoryInfo.Name;
                file += "/";
                itemsList.Add(file);
                //Console.WriteLine(file);
            }

            foreach (FileInfo fileInfo in directory.GetFiles())
            {
                string file = fileInfo.Name;
                itemsList.Add(file);
                //Console.WriteLine(fileInfo.Name);
            }

            itemsList.Sort();
            foreach(var item in itemsList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
