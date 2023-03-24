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
            Ongs ongs = new Ongs(txtNome.Text, txtCpf.Text, txtCep.Text, txtDescricao.Text, /**/);
            ongs.Inserir();
            txtId.Text = ongs.Id.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Ongs ongs = new Ongs(int.Parse(txtId.Text), txtNome.Text, txtCpf.Text, txtCep.Text, txtDescricao.Text, /**/,/**/);
            ongs.Editar();
            MessageBox.Show("Ong atualizada com sucesso!");
        }
    }
}
