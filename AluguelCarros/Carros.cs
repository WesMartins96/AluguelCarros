using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarros
{
    class Carros
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public Carros(string marca, string modelo, int ano, string cor, string placa)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Cor = cor;
            Placa = placa;
        }
        public override string ToString()
        {
            return Marca + " - " + Modelo + " - Ano: " + Ano + " Cor: " + Cor + " Placa: "+ Placa;
        }
        public class ListaDeCarros
        {
            public static List<Carros> InicializarCarros()
            {
                List<Carros> carros = new List<Carros>();
                carros.Add(new Carros("Ford", "Mustang", 1987, "Preto", "UUUUUUU"));
                carros.Add(new Carros("Dodge", "Cobra", 1977, "Azul", "KKKKKKK"));
                carros.Add(new Carros("Ford", "Focus", 2022, "Preto", "GGGGGGG"));
                carros.Add(new Carros("Fiat", "Uno", 1996, "Vermelho", "UUUUUUU"));
                carros.Add(new Carros("Chevrolet", "Camaro SS", 1999, "Amarelo", "HHHHHHH"));

                return carros;
            }
        }

    }
}