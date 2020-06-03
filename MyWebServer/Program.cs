using System;

using MyWebServer.BasicWebServer;

namespace MyWebServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server local = new Server();
            local.Start();
            Console.ReadLine();
        }
    }
}
