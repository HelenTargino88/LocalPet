namespace LocalPetadocoes
{
    partial class FormListClientes
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
            this.dtgListClientes = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnData_nasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListClientes
            // 
            this.dtgListClientes.AllowUserToAddRows = false;
            this.dtgListClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.dtgListClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnCpf,
            this.clnData_nasc,
            this.clnEmail});
            this.dtgListClientes.Location = new System.Drawing.Point(0, 0);
            this.dtgListClientes.Name = "dtgListClientes";
            this.dtgListClientes.ReadOnly = true;
            this.dtgListClientes.Size = new System.Drawing.Size(634, 314);
            this.dtgListClientes.TabIndex = 0;
            this.dtgListClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.clnNome.HeaderText = "NOME COMPLETO";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnNome.Width = 170;
            // 
            // clnCpf
            // 
            this.clnCpf.HeaderText = "CPF";
            this.clnCpf.Name = "clnCpf";
            this.clnCpf.ReadOnly = true;
            this.clnCpf.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnData_nasc
            // 
            this.clnData_nasc.HeaderText = "DATA DE NASCIMENTO";
            this.clnData_nasc.Name = "clnData_nasc";
            this.clnData_nasc.ReadOnly = true;
            this.clnData_nasc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnEmail
            // 
            this.clnEmail.HeaderText = "EMAIL";
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnEmail.Width = 170;
            // 
            // FormListClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(629, 310);
            this.Controls.Add(this.dtgListClientes);
            this.Name = "FormListClientes";
            this.Text = "FormListClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgListClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnData_nasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
    }
}