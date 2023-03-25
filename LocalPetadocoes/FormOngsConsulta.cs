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
            Ongs ongs = new Ongs(txtNome.Text, txtCnpj.Text, txtCpf.Text, txtDescricao.Text, ptbImagem.Text);
            ongs.Inserir();
            txtId.Text = ongs.Id.ToString();

            //EnderecoOng enderecoOng = new EnderecoOng(txtCep.Text, txtLogradouro.Text, 
            //    txtNumeroEnd.Text, txtComplemento.Text,txtBairro.Text, 
            //    txtCidade.Text, cmbUf.Text, cmbEstado.Text, cbTipoEndereco.Text);
            //txtId.Text = enderecoOng.Id.ToString();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Ongs ongs = new Ongs(int.Parse(txtId.Text), txtNome.Text, txtCnpj.Text, txtCpf.Text, txtDescricao.Text, ptbImagem.Text);
            //ongs.Editar();
            //MessageBox.Show("Ong atualizada com sucesso!");
        }
        private void dtgListOng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var lista = Ongs.Listar();
            int linha = 0;
            foreach (var item in lista)
            {
                dtgListOng.Rows.Add();
                dtgListOng.Rows[linha].Cells[0].Value = item.Id;
                dtgListOng.Rows[linha].Cells[1].Value = item.Nome;
                dtgListOng.Rows[linha].Cells[2].Value = item.Cnpj;
                dtgListOng.Rows[linha].Cells[3].Value = item.CpfResponsavel;
                dtgListOng.Rows[linha].Cells[4].Value = item.Descricao;
                linha++;
            }
        }
    }
}
