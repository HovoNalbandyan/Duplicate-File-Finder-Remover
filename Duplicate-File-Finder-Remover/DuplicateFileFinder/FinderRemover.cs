﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DuplicateFileFinder
{
    public class FinderRemover
    {
        public int Finder(string fileName,string path)
        {
            var matches = new List<string>();
            foreach (var item in Directory.GetFiles(path))
            {
                if (fileName == Path.GetFileName(item)) matches.Add(item);
            }
            return matches.Count;
        }
    }
}
