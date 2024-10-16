using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LINQ_JOIN
{
    class Program
    {
        static void Main(string[] args)
        {
            var autor1 = new Autor() { Id = 1, Nome = "Leonardo" };
            var autor2 = new Autor() { Id = 2, Nome = "Maria Maria" };
            var autor3 = new Autor() { Id = 3, Nome = "Joseph" };

            var livro1 = new Livro() {Id = 1, AutorId = 2, Titulo = "Amor amado" };
            var livro2 = new Livro() {Id = 2, AutorId = 2, Titulo = "Bem amado" };
            var livro3 = new Livro() {Id = 3, AutorId = 3, Titulo = "Um espião em Washigton" };
            var livro4 = new Livro() {Id = 4, AutorId = 1, Titulo = "A Vida na terra" };
        }
    }
}