using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Lab2
{
    public class StudentParser
    {
        public static List<Student> ParseDirectory(string directoryName)
        {
            if (!Directory.Exists(directoryName))
                throw new ArgumentException("dir doesn't exist");

            foreach (var fName in Directory.GetFiles(directoryName, "*.csv"))
            {

            }


            return lst;
        }
        private static Student ParseLine(string line)
        {
            var lst=line.Split(',');
            return new Student()
            {
                IsContractor = Convert.ToBoolean(lst[lst.Length - 1]),
                Name = lst[0],
                Grades = lst.Skip(1)
                .SkipLast(1)
                .Select(x => int.Parse(x))
            };           
        }
    }
}
