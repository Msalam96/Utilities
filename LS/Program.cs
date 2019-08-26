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
            bool list = false;
            const string date = "MMM dd HH:mm";

            if(args[0] == "-l")
            {
                list = true;
                Console.WriteLine("Size \t Created \t Modified"); 
            }

            DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            var itemsList = new List<string>();

            foreach (DirectoryInfo directoryInfo in directory.GetDirectories())
            {
                string file = directoryInfo.Name;
                file += "/";
                DateTime creation = directoryInfo.CreationTime;
                DateTime modified = directoryInfo.LastWriteTime;
                string createdDate = creation.ToString(date);
                string modifiedDate = modified.ToString(date);
                if (list)
                {
                    file = "\t" + createdDate + "\t" + modifiedDate + "\t" + file;
                }
                itemsList.Add(file);
                //Console.WriteLine(file);
            }

            foreach (FileInfo fileInfo in directory.GetFiles())
            {
                string file = fileInfo.Name;

                string fileSize = fileInfo.Length.ToString();
                DateTime creation = fileInfo.CreationTime;
                DateTime modified = fileInfo.LastWriteTime;
                string createdDate = creation.ToString(date);
                string modifiedDate = modified.ToString(date);

                if (list)
                {
                    file = fileSize + "\t" + createdDate + "\t" + modifiedDate + "\t" + file; 
                }
                itemsList.Add(file);
                //Console.WriteLine(fileInfo.Name);
            }

            itemsList.Sort();
            foreach (var item in itemsList)
            {
                Console.WriteLine(item);
            }
            
            

            Console.ReadKey();
        }
    }
}
