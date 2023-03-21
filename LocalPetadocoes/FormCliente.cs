using MaterialSkin.Controls;
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
    public partial class FormCliente : MaterialForm
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnAcrescentar_Click(object sender, EventArgs e)
        {
            pnlEndereco.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlEndereco.Visible=false;
        }
    }
}
