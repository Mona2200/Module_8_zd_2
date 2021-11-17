using System;
using System.IO;

namespace ZD2
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine(DirectorySize(@"C:\Users\Алёна\Documents"));
      }

      static long DirectorySize(string Path)
      {
         if (Directory.Exists(Path))
         {

            try
            {

               long size = 0;

               string[] files = Directory.GetFiles(Path);

               foreach (var f in files)
               {
                  size += f.Length;
               }

               string[] dirs = Directory.GetDirectories(Path);

               foreach (string d in dirs)
               {
                  DirectoryInfo NowDir = new DirectoryInfo(d);

                  size += DirectorySize(d);

               }
               return size;
               
            }

            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }

         }
         return 0;
      }
   }
}
