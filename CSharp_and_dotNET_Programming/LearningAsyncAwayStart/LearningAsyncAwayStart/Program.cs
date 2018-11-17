using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningAsyncAwayStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("downloading file");
            Download();       
            Console.ReadLine();

        }

        static async void Download()
        {
            HttpClient client = new HttpClient();

            var data = await client.GetStringAsync("http://rouxacademy.com");
            Console.WriteLine("Download Complete" + data);
        }
   }

    //// Imaginary external network library

    //class Network
    //{
    //    static public Task Download()
    //    {
    //        return Task.Run(() => Thread.Sleep(3000));
    //    }
    //}
}
