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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void dtgTelefone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
            private void btnEditar_Click(object sender, EventArgs e)
            {
                Clientes clientes = new Clientes(
                    int.Parse(txtId.Text),
                        txtNomeCliente.Text, txtCpfCliente.Text, dtNascCliente.MaxDate, txtEmailCliente.Text
                        );
                clientes.Editar();
                MessageBox.Show("Cliente atualizado com sucesso!");         
    }

        private void cbAtivoCliente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes(
                txtNomeCliente.Text, txtCpfCliente.Text, dtNascCliente.MaxDate, txtEmailCliente.Text);
            clientes.Inserir();
            txtId.Text = clientes.Id.ToString();

        }

        private void dtgListaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtNascCliente_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
