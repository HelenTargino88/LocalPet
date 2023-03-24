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
    public partial class FormListOngs : Form
    {
        public FormListOngs()
        {
            InitializeComponent();
        }

        private void dtgListOng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var lista = Ongs.Listar();
            int linha = 0;
            foreach (var item in lista)
            {
                dtgListOng.Rows.Add();
                dtgListOng.Rows[linha].Cells[0].Value = item.Id;
                dtgListOng.Rows[linha].Cells[1].Value = item.Nome;
                dtgListOng.Rows[linha].Cells[2].Value = item.Cnpj;
                dtgListOng.Rows[linha].Cells[3].Value = item.CpfResponsavel;
                dtgListOng.Rows[linha].Cells[4].Value = item.Descricao;
                linha++;
            }
        }
    }
}
