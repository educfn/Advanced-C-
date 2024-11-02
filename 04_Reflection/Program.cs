using _04_Reflection.Modelo;
using System;
using System.Net;
using System.Threading;

namespace _04_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "José",
                Email = "jose.costa@gmail.com",
                Senha = "123456ab"
            };
            Log.GravarUsuario(usuario);

            usuario.Nome = "José Costa";
            Log.GravarUsuario(usuario);

            Log.ApresentarLog();

            Console.WriteLine("Log gravado!");
            Console.ReadKey();
        }
    }
}