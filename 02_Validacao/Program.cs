using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Threading;

namespace _02_Validacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "José", Email = "jose", Senha = "1234"};
            ValidationContext contexto = new ValidationContext(usuario);
            List<ValidationResult> resultados = new List<ValidationResult>();

            if (Validator.TryValidateObject(usuario, contexto, resultados, true) == false)
            {
                //Mensagens
                foreach (var erro in resultados)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }
            }
            Console.ReadKey();
        }
    }
}