namespace LocalPetadocoes
{
    partial class FormListAnimais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgListAnimais = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPorte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEnfermidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMedicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnVacinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnComportamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListAnimais
            // 
            this.dtgListAnimais.AllowUserToAddRows = false;
            this.dtgListAnimais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.dtgListAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListAnimais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnRaca,
            this.clnEspecie,
            this.clnSexo,
            this.clnPorte,
            this.clnIdade,
            this.clnDescricao,
            this.clnEnfermidades,
            this.clnMedicamentos,
            this.clnVacinas,
            this.clnComportamento,
            this.clnAtivo});
            this.dtgListAnimais.Location = new System.Drawing.Point(-1, -3);
            this.dtgListAnimais.Name = "dtgListAnimais";
            this.dtgListAnimais.ReadOnly = true;
            this.dtgListAnimais.Size = new System.Drawing.Size(1263, 355);
            this.dtgListAnimais.TabIndex = 0;
            this.dtgListAnimais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clnId
            // 
            this.clnId.HeaderText = "ID";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnId.Width = 50;
            // 
            // clnNome
            // 
            this.clnNome.HeaderText = "NOME";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnNome.Width = 120;
            // 
            // clnRaca
            // 
            this.clnRaca.HeaderText = "Raça";
            this.clnRaca.Name = "clnRaca";
            this.clnRaca.ReadOnly = true;
            this.clnRaca.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnEspecie
            // 
            this.clnEspecie.HeaderText = "ESPÉCIE";
            this.clnEspecie.Name = "clnEspecie";
            this.clnEspecie.ReadOnly = true;
            // 
            // clnSexo
            // 
            this.clnSexo.HeaderText = "SEXO";
            this.clnSexo.Name = "clnSexo";
            this.clnSexo.ReadOnly = true;
            this.clnSexo.Width = 80;
            // 
            // clnPorte
            // 
            this.clnPorte.HeaderText = "PORTE";
            this.clnPorte.Name = "clnPorte";
            this.clnPorte.ReadOnly = true;
            // 
            // clnIdade
            // 
            this.clnIdade.HeaderText = "IDADE";
            this.clnIdade.Name = "clnIdade";
            this.clnIdade.ReadOnly = true;
            this.clnIdade.Width = 80;
            // 
            // clnDescricao
            // 
            this.clnDescricao.HeaderText = "DESCRIÇÃO";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 170;
            // 
            // clnEnfermidades
            // 
            this.clnEnfermidades.HeaderText = "ENFERMIDADES";
            this.clnEnfermidades.Name = "clnEnfermidades";
            this.clnEnfermidades.ReadOnly = true;
            // 
            // clnMedicamentos
            // 
            this.clnMedicamentos.HeaderText = "MEDICAMENTOS";
            this.clnMedicamentos.Name = "clnMedicamentos";
            this.clnMedicamentos.ReadOnly = true;
            // 
            // clnVacinas
            // 
            this.clnVacinas.HeaderText = "VACINAS";
            this.clnVacinas.Name = "clnVacinas";
            this.clnVacinas.ReadOnly = true;
            // 
            // clnComportamento
            // 
            this.clnComportamento.HeaderText = "COMPORTAMENTO";
            this.clnComportamento.Name = "clnComportamento";
            this.clnComportamento.ReadOnly = true;
            this.clnComportamento.Width = 70;
            // 
            // clnAtivo
            // 
            this.clnAtivo.HeaderText = "ATIVO";
            this.clnAtivo.Name = "clnAtivo";
            this.clnAtivo.ReadOnly = true;
            this.clnAtivo.Width = 50;
            // 
            // FormListAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1261, 347);
            this.Controls.Add(this.dtgListAnimais);
            this.Name = "FormListAnimais";
            this.Text = "FormListAnimais";
            ((System.ComponentModel.ISupportInitialize)(this.dtgListAnimais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListAnimais;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPorte;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEnfermidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnVacinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnComportamento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnAtivo;
    }
}