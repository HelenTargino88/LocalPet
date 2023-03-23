using LocalPet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LocalPetadocoes
{
    public partial class FormClienteConsulta : Form
    {
        public FormClienteConsulta()
        {
            InitializeComponent();
        }

        private void btnAdiconar_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes(txtNome.Text, txtCpf.Text,/**/, txtEmail.Text);
            clientes.Inserir();
            txtId.Text = clientes.Id.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes(int.Parse(txtId.Text), txtNome.Text, txtCpf.Text,/**/, txtEmail.Text);
            clientes.Editar();
            MessageBox.Show("Cliente atualizado com sucesso!");
        }
    }
}
