using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuplicateFileFinder;

namespace Duplicate_File_Finder_Remover
{
    class Program
    {
        static void Main(string[] args)
        {
            var finder = new FinderRemover();
            var matches = finder.Finder("1.JPG",@"D:\Media\MUSICCCCCCCCCCCCCCCCCCCCC");
            //foreach (var item in matches)
            //{
                //Console.WriteLine(item);
            //}
            Console.ReadKey();
        }
    }
}
