using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AluguelCarros.Carros;

namespace AluguelCarros
{
    public partial class Form1 : Form
    {

        List<Carros> carros = ListaDeCarros.InicializarCarros();
        List<Clientes> clientes = ListaDeClientes.InicializarCliente();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Clientes cliente in clientes)
            {
                cbxListaDeClientes.Items.Add(cliente);
            }

            foreach (Carros item in carros)
            {
                cbxListaDeCarros.Items.Add(item);
            }
            // não mostra o erro até compilar, se liga
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Clientes cliente = clientes[cbxListaDeClientes.SelectedIndex];
            Carros carro = carros[cbxListaDeCarros.SelectedIndex];
            double valorPorDia = double.Parse(txtValor.Text);
            DateTime dataInicial = DateTime.Parse(txtDataInicial.Text);
            DateTime dataEntrega = DateTime.Parse(txtDataDeEntrega.Text);
            valorPorDia = valorPorDia + double.Parse(txtValor.Text);
            lstResultado.Items.Add(string.Format($"{cliente}, {carro} , Valor: {valorPorDia}"));
            MessageBox.Show("Cadastro Realizado com Sucesso");

        }

        private void lstResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
    }
}
