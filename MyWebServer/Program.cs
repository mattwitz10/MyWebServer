using System;

using MyWebServer.BasicWebServer;

namespace MyWebServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server.Start();
            Console.ReadLine();
        }
    }
}
