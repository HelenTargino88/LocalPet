using LocalPet;
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
    public partial class FormListClientes : Form
    {
        public FormListClientes()
        {
            InitializeComponent();
        }

        private void dtgListClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var lista = Clientes.Listar();
            int linha = 0;
            foreach (var item in lista)
            {
                dtgListClientes.Rows.Add();
                dtgListClientes.Rows[linha].Cells[0].Value = item.Id;
                dtgListClientes.Rows[linha].Cells[1].Value = item.Nome;
                dtgListClientes.Rows[linha].Cells[2].Value = item.Cpf;
                dtgListClientes.Rows[linha].Cells[3].Value = item.Data_nasc;
                dtgListClientes.Rows[linha].Cells[4].Value = item.Email;
                linha++;
            }
        }
    }
}
