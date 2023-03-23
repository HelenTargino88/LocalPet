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
using LocalPet;

namespace LocalPetadocoes
{
    public partial class FormOngs : Form
    {
        public FormOngs()
        {
            InitializeComponent();
        }

        private void FormOngs_Load(object sender, EventArgs e)
        {

        }

        private void btnAdiconar_Click(object sender, EventArgs e)
        {
            Ongs ongs = new Ongs(txtNome.Text, txtCnpj.Text, txtCpf.Text); ;

        }
    }
}
