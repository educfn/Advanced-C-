﻿using System;
using System.Threading;

namespace _04_ThreadBackground
{
    class Program
    {
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
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Num: " + i);
            }
            Console.WriteLine("DateTime: " + DateTime.Now);
        }
    }
}