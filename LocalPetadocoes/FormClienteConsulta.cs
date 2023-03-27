using LocalPet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
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
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "Editar")
            {
                txtId.ReadOnly = false;
                txtId.Focus();
                btnEditar.Text = "Gravar";
               
            }
            else
            {
                Clientes clientes = new Clientes(txtNome.Text, txtCpf.Text, DateTime.Parse(dtNascCliente.Text), txtEmail.Text);
                clientes.Editar(clientes);
                txtId.ReadOnly = true;
                txtNome.Focus();
                btnEditar.Text = "Editar";
                MessageBox.Show("Cliente atualizado com sucesso!");

            }
           
        }

        private void dtgListClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var lista = Clientes.Listar();
            int linha = 0;
            foreach (var item in lista)
            {
                dtgListClientes.Rows.Add();
                dtgListClientes.Rows[linha].Cells[0].Value = item.Id;
                dtgListClientes.Rows[linha].Cells[1].Value = item.Nome;
                dtgListClientes.Rows[linha].Cells[2].Value = item.Cpf;
                dtgListClientes.Rows[linha].Cells[3].Value = item.Data_nasc;
                dtgListClientes.Rows[linha].Cells[4].Value = item.Email;
                linha++;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                Clientes clientes = Clientes.ObterPorId(int.Parse(txtId.Text));
                if (clientes.Excluir(clientes.Id))
                {
                    MessageBox.Show("Cliente " + clientes.Nome + " excluido com sucesso!");
                }
            }
        }

        private void btnArquivar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
