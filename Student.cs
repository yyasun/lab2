using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab2
{
    public class Student: IComparable
    {
        public string Name { get; set; }
        public IEnumerable<int> Grades { get; set; }
        public double AvgGrade { get; set; }
        public bool IsContractor { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Student cmp = (Student)obj;
            return this.AvgGrade.CompareTo(cmp.AvgGrade);
        }
    }
}
