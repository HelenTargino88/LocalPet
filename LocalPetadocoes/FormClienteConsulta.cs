﻿using LocalPet;
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
    public partial class FormClienteConsulta : Form
    {
        public FormClienteConsulta()
        {
            InitializeComponent();
        }

        private void btnAdiconar_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes(txtNome.Text, txtCpf.Text,DateTime.Parse(dtNascCliente.Text), txtEmail.Text);
            clientes.Inserir();
            txtId.Text = clientes.Id.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes(int.Parse(txtId.Text), txtNome.Text, txtCpf.Text, DateTime.Parse(dtNascCliente.Text), txtEmail.Text);
            clientes.Editar();

            EnderecoCli enderecoCli = new EnderecoCli(txtCEP.Text, txtLogradouro.Text,
                txtNumero.Text, txtComplemento.Text, txtBairro.Text,
                txtCidade.Text, cmbUF.Text, cmbEstado.Text, cmbTipo.Text);
            enderecoCli.Editar();

            TelefoneCli telefoneCli = new TelefoneCli(txtTelefone.Text, cmbTipoTelefone.Text);
            telefoneCli.Editar();

            MessageBox.Show("Cliente atualizado com sucesso!");
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
