using MaterialSkin;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
           
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            FormRelatorio frmRelatorio = new FormRelatorio();
            frmRelatorio.Show();
            this.Hide();
        }
      
        public void efetuarLogin(string nome, string senha)
        {
            try
            {
                string sql = "select * from usuarios where nome = @nome and senha = @senha";



            }
            catch (Exception erro)
            {
               MessageBox.Show("Erro: " + erro);

            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
