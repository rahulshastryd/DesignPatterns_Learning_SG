﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.SRP
{
    public class Journal
    {
        public readonly List<string> entries = new List<string>();
        public static int count = 0;
        public int AddEntry(string text)
        {
            entries.Add($"{++count}:{text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }
    public class Persistance
    {
        public void SaveToFile(Journal j,string filename,bool overwrite=false)
        {
            if (overwrite || !File.Exists(filename))
            {
                File.WriteAllText(filename,j.ToString());
            }
        }
    }
}
