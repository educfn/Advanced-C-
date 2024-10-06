using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace _04_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\MyCode\Udemy\AdvancedC#\Advanced C#\03_SerializarXML.xml");
            string linhasDoArquivo = stream.ReadToEnd();

            Usuario usuario = (Usuario) JsonConvert.DeserializeObject(linhasDoArquivo, typeof(Usuario));

            Console.WriteLine("Usuario(Nome): {0}, CPF: {1}, Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);
            Console.ReadKey();
        }
    }
}