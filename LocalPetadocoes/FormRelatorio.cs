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
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void FormRelatorio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClienteConsulta formCliente = new FormClienteConsulta();
            formCliente.MdiParent = this;
            formCliente.Show();
        }
        private void consultaOngs_Click(object sender, EventArgs e)
        {
            FormOngsConsulta formOngs = new FormOngsConsulta();
            formOngs.MdiParent = this;
            formOngs.Show();
        }

        private void consultaAnimais_Click(object sender, EventArgs e)
        {
            FormAnimaisConsulta formAnimais = new FormAnimaisConsulta();
            formAnimais.MdiParent = this;
            formAnimais.Show();
        }

        private void listarClientes_Click(object sender, EventArgs e)
        {
            FormListClientes formListClientes = new FormListClientes();
            formListClientes.MdiParent = this;
            formListClientes.Show();
        }

        private void listarOngs_Click(object sender, EventArgs e)
        {
            FormListOngs formListOngs = new FormListOngs();
            formListOngs.MdiParent = this;
            formListOngs.Show();
        }

        private void listarAnimais_Click(object sender, EventArgs e)
        {
            FormListAnimais formListAnimais = new FormListAnimais();
            formListAnimais.MdiParent = this;
            formListAnimais.Show();
        }

        private void GerenciarGatos_Click(object sender, EventArgs e)
        {

        }
    }
}
