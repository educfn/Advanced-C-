using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Generics.Modelo;

namespace _01_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro() { Marca = "FIAT", Modelo="UNO"};
            Casa casa = new Casa() { Cidade="Brasília", Endereco="QSQ 400"};
            Usuario usuario = new Usuario() { Nome="Maria", Email="maria@gmail.com", Senha="123456"};

            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            Carro carro2 = Serializador.Deserializar();
            Carro casa2 = Serializador.Deserializar();
            Carro usuario2 = Serializador.Deserializar();
        }
    }
}