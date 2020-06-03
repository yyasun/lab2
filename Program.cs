using System;
using System.IO;

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
                        
        }
    }
}
