using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSandboxExample
{
    internal class Program
    {
        static void PrintHello_x5()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i}. Hello");
                Thread.Sleep(100);
            }
        }

        static void PrintWorld_x10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}. World");
                Thread.Sleep(100);
            }
        }

        static void PrintHelloWorld_x7()
        {
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine($"{i}. Hello World");
                Thread.Sleep(100);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start");
            Console.ReadKey(true);

            // 1. создать объекты потока
            Thread helloThread = new Thread(PrintHello_x5);
            Thread worldThread = new Thread(PrintWorld_x10);
            Thread helloWorldThread = new Thread(PrintHelloWorld_x7);

            // 2. запустить объекты потока
            helloThread.Start();
            worldThread.Start();
            helloWorldThread.Start();

            // дождаться щавершения потоков
            helloThread.Join(); // Текущий поток остановится до тех пор, пока helloThread не завершит работу
            worldThread.Join();
            helloWorldThread.Join();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
        }
    }
}
