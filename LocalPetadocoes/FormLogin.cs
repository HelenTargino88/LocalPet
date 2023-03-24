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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
           
        }
        private void btnLogin_Click_2(object sender, EventArgs e)
        {
            if (txtUsuario.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                Usuarios user = Usuarios.Logar(txtUsuario.Text, txtSenha.Text);
                MessageBox.Show("Login efetuado com sucesso","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormRelatorio frmRelatorio = new FormRelatorio();
                frmRelatorio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário e senha invalidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }
        }
    }
}
