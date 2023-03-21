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

        

        private void button3_Click(object sender, EventArgs e)
        {
            pnlEndereco.Visible=false;
        }

        private void materialLabel14_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField14_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            pnlEndereco.Visible = true;
        }
    }
}
