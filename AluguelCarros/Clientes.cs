using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarros
{
    public class Clientes
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; }
        public long CPF { get; }
        public char Genero { get; private set; }

        public Clientes(string nome, DateTime dataNascimento, long cpf, char genero)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            CPF = cpf;
            Genero = genero;
            
        }

        public override string ToString()
        {
            return Nome + " - " + DataNascimento.ToString("dd/MM/yyyy") + " - CPF: " + CPF;
        }

    }
    public class ListaDeClientes
    {
        public static List<Clientes> InicializarCliente()
        {
            List<Clientes> clientes = new List<Clientes>();

            clientes.Add(new Clientes("Wesley", DateTime.Parse("16/06/1996"), 44444444444, 'M'));
            clientes.Add(new Clientes("Beatriz", DateTime.Parse("07/08/1965"), 33333333333, 'F'));
            clientes.Add(new Clientes("Gael", DateTime.Parse("01/06/2020"), 55555555555, 'M'));
            clientes.Add(new Clientes("Duda", DateTime.Parse("02/12/1995"), 99999999999, 'M'));
            clientes.Add(new Clientes("Rogerin", DateTime.Parse("22/05/1988"), 88888888888, 'M'));
            return clientes;
        }
    }
}

