using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningAsync
{
    class Program
    {
        public static String s = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Downloading File");
            Download();
            s = Console.ReadLine();
            Thread.Sleep(3000);
        }

        static void Download()
        {
            Task.Run(() => {
                Thread.Sleep(3000);
                Console.WriteLine("Download Complete");
                Console.WriteLine(s);
            });
        }
    }
}
