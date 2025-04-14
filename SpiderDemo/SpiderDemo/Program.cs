using SpiderDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Spider busqeuda = new Spider();
            List<Car> car  = await busqueda.Start();
            
            Console.WriteLine();
        }
    }
}