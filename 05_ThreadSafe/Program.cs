using System;
using System.Threading;

namespace _04_ThreadBackground
{
    class Program
    {
        static int Rede = 0;
        static object variavelDeControle = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("DataIni: " + DateTime.Now);

            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.IsBackground = true;
                t1.Start();
            }
            Console.ReadKey();
        }
        //IO - Tela(Monitor), Rede e Armazenamento.
        static void ThreadRepeticao()
        {
            //FIFO - First In e First Out
            for (int i = 0; i < 1000; i++)
            {
                lock (variavelDeControle)
                {
                    Console.WriteLine("Num: " + i);
                    Rede++;
                }
            }
            Console.WriteLine("DateTime: " + DateTime.Now);
        }
    }
}