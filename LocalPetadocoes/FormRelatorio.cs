using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace LocalPetadocoes
{
    public partial class FormRelatorio : MaterialForm
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void FormRelatorio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOngs formOngs = new FormOngs();
            formOngs.Show();
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            
        }
    }
}
