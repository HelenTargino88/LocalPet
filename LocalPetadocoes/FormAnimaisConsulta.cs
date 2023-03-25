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
    public partial class FormAnimaisConsulta : Form
    {
        public FormAnimaisConsulta()
        {
            InitializeComponent();
        }
        private void btnAdiconar_Click(object sender, EventArgs e)
        {
            //Animais animais = new Animais(txtNome.Text, /*txtRaca.Text*/, txtEspecie.Text, txtSexo.Text, txtPorte.Text, txtIdade.Text, txtDescricao.Text, txtEnfermidades.Text, txtMedicamentos.Text, txtVacinas.Text, txtComportamento.Text, txtImagem.Text, true);
            //animais.Inserir();
            //MessageBox.Show("Animal adicionado com sucesso!");
            //txtNome.Clear();
            //txtRaca.Clear();
            //txtEspecie.Clear();
            //txtSexo.Clear();
            //txtPorte.Clear();
            //txtIdade.Clear();
            //txtDescricao.Clear();
            //txtEnfermidades.Clear();
            //txtMedicamentos.Clear();
            //txtVacinas.Clear();
            //txtComportamento.Clear();
            //txtNome.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Animais animais = new Animais(int.Parse(txtId.Text), txtNome.Text,  /*txtRaca.Text*/, txtEspecie.Text, txtSexo.Text, txtPorte.Text, txtIdade.Text, txtDescricao.Text, txtEnfermidades.Text, txtMedicamentos.Text, txtVacinas.Text, txtComportamento.Text, txtImagem.Text, true);
            //animais.Editar();
            //MessageBox.Show("Animal atualizado com sucesso!");
            //txtNome.Clear();
            //txtRaca.Clear();
            //txtEspecie.Clear();
            //txtSexo.Clear();
            //txtPorte.Clear();
            //txtIdade.Clear();
            //txtDescricao.Clear();
            //txtEnfermidades.Clear();
            //txtMedicamentos.Clear();
            //txtVacinas.Clear();
            //txtComportamento.Clear();
            //txtNome.Focus();
        }

        private void btnArquivar_Click(object sender, EventArgs e)
        {

        }

        private void dtgListAnimais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var lista = Animais.Listar();
            int linha = 0;
            foreach (var item in lista)
            {
                dtgListAnimais.Rows.Add();
                dtgListAnimais.Rows[linha].Cells[0].Value = item.Id;
                dtgListAnimais.Rows[linha].Cells[1].Value = item.Nome;
                dtgListAnimais.Rows[linha].Cells[2].Value = item.Raca;
                dtgListAnimais.Rows[linha].Cells[3].Value = item.Especie;
                dtgListAnimais.Rows[linha].Cells[4].Value = item.Sexo;
                dtgListAnimais.Rows[linha].Cells[5].Value = item.Porte;
                dtgListAnimais.Rows[linha].Cells[6].Value = item.Descricao;
                dtgListAnimais.Rows[linha].Cells[7].Value = item.Enfermidades;
                dtgListAnimais.Rows[linha].Cells[8].Value = item.Medicamentos;
                dtgListAnimais.Rows[linha].Cells[9].Value = item.Vacinas;
                dtgListAnimais.Rows[linha].Cells[10].Value = item.Comportamento;
                dtgListAnimais.Rows[linha].Cells[11].Value = item.Idade;
                dtgListAnimais.Rows[linha].Cells[12].Value = item.Ativo;
                linha++;
            }
        }
    }
}
