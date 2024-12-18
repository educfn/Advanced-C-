﻿using System;
using System.Net;
using System.Threading;

namespace _03_TaskMult
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> lista = new List<Task>();
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));

            Task.WaitAll(lista.ToArray());

            string[] enderecos = new string[] { "http://www.google.com.br", "http://www.microsoft.com.br", "http://www.g1.com.br"};

            var listaEnd = from end in enderecos select DownloadPagina(end);

            Task.WaitAll(listaEnd.ToArray());

            Console.WriteLine("Programa finalizado!!!");
            Console.ReadKey();
        }

        static void Metodo01()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Valor: " + i + " TaskID: " + Task.CurrentId);
            }
        }

        public static async Task DownloadPagina(string end)
        {
            WebClient web = new WebClient();
            string html = await web.DownloadStringTaskAsync(end);
            Console.WriteLine("Download Realizado para a página: " + end);
        }
    }
}