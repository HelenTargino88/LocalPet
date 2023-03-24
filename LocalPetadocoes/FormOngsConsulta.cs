using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocalPet;

namespace LocalPetadocoes
{
    public partial class FormOngsConsulta : Form
    {
        public FormOngsConsulta()
        {
            InitializeComponent();
        }

        private void btnAdiconar_Click(object sender, EventArgs e)
        {
            Ongs ongs = new Ongs(txtNome.Text, txtCnpj.Text, txtCpf.Text, txtEmail.Text, txtDescricao.Text);
            ongs.Inserir();
            txtId.Text = ongs.Id.ToString();

            //EnderecoOng = new EnderecoOng(txtCep.Text, txtLogradouro.Text, 
            //    txtNumeroEnd.Text, txtComplemento.Text,txtBairro.Text, 
            //    txtCidade.Text, cmbUf.Text, cmbEstado.Text, cbTipoEndereco.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Ongs ongs = new Ongs(int.Parse(txtId.Text), txtNome.Text, txtCnpj.Text, txtCpf.Text, txtEmail.Text, txtDescricao.Text);
            //ongs.Editar();
            //MessageBox.Show("Ong atualizada com sucesso!");
        }
    }
}
