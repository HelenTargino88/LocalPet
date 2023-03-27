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
            txtId.Text = dtgListClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgListClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCpf.Text = dtgListClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtNascCliente.Text = dtgListClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = dtgListClientes.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                Clientes clientes = Clientes.ObterPorId(int.Parse(txtId.Text));
                if (clientes.Excluir(clientes.Id))
                {
                    MessageBox.Show("Cliente " +    clientes.Nome + " excluido com sucesso!");
                }
            }
        }
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                Clientes clientes = Clientes.ObterPorId(int.Parse(txtId.Text));
                if (clientes.Id > 0)
                {
                    txtNome.Text = clientes.Nome;
                    txtCpf.Text = clientes.Cpf;
                    txtEmail.Text = clientes.Email;
                    dtNascCliente.MaxDate = clientes.Data_nasc;

                }
                else
                {
                }
                EnderecoCli enderecoCli = EnderecoCli.ObterPorId(int.Parse(txtId.Text));
                if (clientes.Id > 0)
                {
                    txtCep.Text = enderecoCli.CEP;
                    txtLogradouro.Text = enderecoCli.Logradouro;
                    txtNumero.Text = enderecoCli.Numero;
                    txtComplemento.Text = enderecoCli.Complemento;
                    txtBairro.Text = enderecoCli.Bairro;
                    txtCidade.Text = enderecoCli.Cidade;
                    cmbEstado.Text = enderecoCli.Estado;
                    cmbUf.Text = enderecoCli.UF;
                    cmbTipoEndereco.Text = enderecoCli.Tipo;


                }
                else
                {
                }
            }
            else 
            {
                txtNome.Clear();
                txtCpf.Clear();
                txtEmail.Clear();
                dtNascCliente.Enabled = false;
                txtCep.Clear();
                txtLogradouro.Clear();
                txtNumero.Clear();
                txtComplemento.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                cmbEstado.Enabled = false;
                cmbUf.Enabled = false;
                cmbTipoEndereco.Enabled = false;
                
            }
        }
        private void lbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
