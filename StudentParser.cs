using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Lab2
{
    public class StudentParser
    {
        public static List<Student> ParseDirectory(string directoryName)
        {
            if (!Directory.Exists(directoryName))
                throw new ArgumentException("dir doesn't exist");            
            var lst = new List<Student>();
            foreach (var fName in Directory.GetFiles(directoryName, "*.csv"))
            {                
                foreach (var line in File.ReadAllLines(fName).Skip(1))
                {
                    lst.Add(ParseLine(line));
                }
            }

            return lst;
        }
        private static Student ParseLine(string line)
        {
            var lst=line.Split(',');
            var grades = lst.Skip(1)
                .SkipLast(1)
                .Select(x => int.Parse(x));
            return new Student()
            {
                IsContractor = Convert.ToBoolean(lst[lst.Length - 1]),
                Name = lst[0],
                Grades = grades,
                AvgGrade = grades.Average()
            };           
        }
        public static List<string> ConvertToAvgGradeCSV(List<Student> students)
        {
            var lst = students.Select(x => $"{x.Name},{x.AvgGrade}").ToList();
            lst.Prepend(lst.Count.ToString());
            return lst;
        }
    }
}
