using System;
using System.IO;

namespace project_task
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo folder = new DirectoryInfo(@"D:\test");

            FileInfo fs = new FileInfo(@"D:\test");

            TimeSpan.FromMinutes(30);

            fs.LastAccessTime.AddMinutes(30);



            foreach (FileInfo file in folder.GetFiles())
            {

                if (true)
                {
                    fs.LastAccessTime.AddMinutes(30);

                    file.Delete();
                }



            }

            foreach (DirectoryInfo dir in folder.GetDirectories())
            {
                if (true)
                {
                    fs.LastAccessTime.AddMinutes(30);

                    dir.Delete();
                }



            }
        }
    }
}