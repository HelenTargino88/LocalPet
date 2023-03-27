﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocalPet;
using static System.Windows.Forms.LinkLabel;

namespace LocalPetadocoes
{
    public partial class FormOngsConsulta : Form
    {
        public FormOngsConsulta()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Ongs ongs = new Ongs(txtNome.Text, txtCnpj.Text, txtCpf.Text, txtDescricao.Text, ptbImagem.Text);
            ongs.Inserir();
            txtId.Text = ongs.Id.ToString();

            EnderecoOng enderecoOng = new EnderecoOng(txtCep.Text, txtLogradouro.Text, 
                txtNumeroEnd.Text, txtComplemento.Text,txtBairro.Text, 
                txtCidade.Text, cmbUf.Text, cmbEstado.Text, cbTipoEndereco.Text);
            txtId.Text = enderecoOng.Id.ToString();

            TelefoneOng telefoneOng = new TelefoneOng(txtTelefone.Text, cmbTipoTelefone.Text);
            telefoneOng.Id.ToString();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Ongs ongs = new Ongs(int.Parse(txtId.Text), txtNome.Text, txtCnpj.Text, txtCpf.Text, txtDescricao.Text, ptbImagem.Text);
            ongs.Editar();            

            EnderecoOng enderecoOng = new EnderecoOng(txtCep.Text, txtLogradouro.Text,
                txtNumeroEnd.Text, txtComplemento.Text, txtBairro.Text,
                txtCidade.Text, cmbUf.Text, cmbEstado.Text, cbTipoEndereco.Text);
            enderecoOng.Editar();

            TelefoneOng telefoneOng = new TelefoneOng(txtTelefone.Text, cmbTipoTelefone.Text);
            telefoneOng.Editar();

            MessageBox.Show("Ong atualizada com sucesso!");
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
        private void dtgEnderecoOng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var listab = EnderecoOng.ListarPorOng();
            int linhab = 0;
            foreach (var item in listab)
            {
                dtgListOng.Rows.Add();
                dtgListOng.Rows[linhab].Cells[0].Value = item.Id;
                dtgListOng.Rows[linhab].Cells[1].Value = item.CEP;
                dtgListOng.Rows[linhab].Cells[2].Value = item.Logradouro;
                dtgListOng.Rows[linhab].Cells[3].Value = item.Numero;
                dtgListOng.Rows[linhab].Cells[4].Value = item.Complemento;
                dtgListOng.Rows[linhab].Cells[5].Value = item.Bairro;
                dtgListOng.Rows[linhab].Cells[6].Value = item.Cidade;
                dtgListOng.Rows[linhab].Cells[7].Value = item.Estado;
                dtgListOng.Rows[linhab].Cells[8].Value = item.UF;
                dtgListOng.Rows[linhab].Cells[9].Value = item.Tipo;
                linhab++;
            }
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormOngsConsulta_Load(object sender, EventArgs e)
        {

        }

        
    }
}
