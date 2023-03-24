namespace LocalPetadocoes
{
    partial class FormListOngs
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
            this.dtgListOng = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListOng)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListOng
            // 
            this.dtgListOng.AllowUserToAddRows = false;
            this.dtgListOng.AllowUserToDeleteRows = false;
            this.dtgListOng.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.dtgListOng.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgListOng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListOng.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnCnpj,
            this.clnCpf,
            this.clnDescricao});
            this.dtgListOng.Location = new System.Drawing.Point(-2, -2);
            this.dtgListOng.Name = "dtgListOng";
            this.dtgListOng.ReadOnly = true;
            this.dtgListOng.Size = new System.Drawing.Size(664, 345);
            this.dtgListOng.TabIndex = 0;
            this.dtgListOng.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListOng_CellContentClick);
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
            this.clnNome.Width = 170;
            // 
            // clnCnpj
            // 
            this.clnCnpj.HeaderText = "CNPJ";
            this.clnCnpj.Name = "clnCnpj";
            this.clnCnpj.ReadOnly = true;
            this.clnCnpj.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnCpf
            // 
            this.clnCpf.HeaderText = "CPF RESPONSÁVEL";
            this.clnCpf.Name = "clnCpf";
            this.clnCpf.ReadOnly = true;
            this.clnCpf.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnDescricao
            // 
            this.clnDescricao.HeaderText = "DESCRIÇÃO";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 200;
            // 
            // FormListOngs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(660, 341);
            this.Controls.Add(this.dtgListOng);
            this.Name = "FormListOngs";
            this.Text = "FormListOngs";
            ((System.ComponentModel.ISupportInitialize)(this.dtgListOng)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridView dtgListOng;
    }
}