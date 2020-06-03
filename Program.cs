using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Program
    {
        static string ReadInput()
        {
            Console.WriteLine("Enter directory path:");
            var directoryName = Console.ReadLine();
            while (!Directory.Exists(directoryName))
            {
                Console.WriteLine("dir doesn't exist. Enter directory path:");
                directoryName = Console.ReadLine();
            }
            return directoryName;
        }       
        static void Main(string[] args)
        {
            var lst = StudentParser.ParseDirectory(ReadInput());
            lst.Sort();
            var onbudget =lst.Where(x => !x.IsContractor)
                .ToList();
            onbudget.Sort();
            int i;
            Console.OutputEncoding = Encoding.Unicode;
            for (i = lst.Count-1;i>lst.Count*0.4;i--)
            {
                Console.WriteLine($"{lst[i].Name},{lst[i].AvgGrade}");
            }
            Console.WriteLine();
            Console.WriteLine($"Minimal grade to recieve scholarship: {lst[i+1].AvgGrade}");


            File.WriteAllLines("allstuds.csv", StudentParser.ConvertToAvgGradeCSV(lst));
        }
        //static void
    }
}
