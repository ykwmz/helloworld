using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace netCoreHello
{
    class Program
    {
        static void Main(string[] args)
        {
            var setting = new Dictionary<string,string>{
                {"1", "hello"},
                {"2", "world"}
            };

            var builder = new ConfigurationBuilder()
                .AddInMemoryCollection(setting)
                .AddCommandLine(args)
                .AddJsonFile("class.json");

            var configuration = builder.Build();

            Console.WriteLine($"1: {configuration["1"]}");
            Console.WriteLine($"2: {configuration["2"]}");
            Console.WriteLine($"Class No.: {configuration["ClassNo"]}");
            Console.WriteLine($"Students name: {configuration["Students:0:name"]}");
            Console.WriteLine($"Students age: {configuration["Students:0:age"]}");
            //Console.ReadLine();
        }
    }
}
