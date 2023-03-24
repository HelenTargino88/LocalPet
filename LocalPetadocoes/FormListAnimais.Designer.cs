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
            this.dtgAnimais = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPorte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEnfermidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMedicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnVacinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnComportamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAnimais
            // 
            this.dtgAnimais.AllowUserToAddRows = false;
            this.dtgAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAnimais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnRaca,
            this.clnEspecie,
            this.clnSexo,
            this.clnPorte,
            this.clnDescricao,
            this.clnEnfermidades,
            this.clnMedicamentos,
            this.clnVacinas,
            this.clnComportamento,
            this.clnIdade,
            this.clnAtivo});
            this.dtgAnimais.Location = new System.Drawing.Point(23, 77);
            this.dtgAnimais.Name = "dtgAnimais";
            this.dtgAnimais.ReadOnly = true;
            this.dtgAnimais.Size = new System.Drawing.Size(1304, 355);
            this.dtgAnimais.TabIndex = 26;
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
            this.clnRaca.HeaderText = "RAÇA";
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
            this.clnComportamento.Width = 110;
            // 
            // clnIdade
            // 
            this.clnIdade.HeaderText = "IDADE";
            this.clnIdade.Name = "clnIdade";
            this.clnIdade.ReadOnly = true;
            this.clnIdade.Width = 80;
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
            this.ClientSize = new System.Drawing.Size(1349, 657);
            this.Controls.Add(this.dtgAnimais);
            this.Name = "FormListAnimais";
            this.Text = "FormListAnimais";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAnimais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAnimais;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPorte;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEnfermidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnVacinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnComportamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnAtivo;
    }
}