namespace LocalPetadocoes
{
    partial class FormRelatorio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.ongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarOngs = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaOngs = new System.Windows.Forms.ToolStripMenuItem();
            this.animaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaAnimais = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAnimais = new System.Windows.Forms.ToolStripMenuItem();
            this.operaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GerenciarGatos = new System.Windows.Forms.ToolStripMenuItem();
            this.listarGatos = new System.Windows.Forms.ToolStripMenuItem();
            this.cachorroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCachorros = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCachorros = new System.Windows.Forms.ToolStripMenuItem();
            this.mOvimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gatoStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cachorrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.operaçãoToolStripMenuItem,
            this.mOvimentoToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.ongsToolStripMenuItem,
            this.animaisToolStripMenuItem});
            resources.ApplyResources(this.cadastroToolStripMenuItem, "cadastroToolStripMenuItem");
            this.cadastroToolStripMenuItem.Image = global::LocalPetadocoes.Properties.Resources.icons8_relatório_de_sistema_64;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaClientes,
            this.listarClientes});
            this.clientesToolStripMenuItem.Image = global::LocalPetadocoes.Properties.Resources.icons8_usuário_64;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            resources.ApplyResources(this.clientesToolStripMenuItem, "clientesToolStripMenuItem");
            // 
            // consultaClientes
            // 
            this.consultaClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.consultaClientes.Image = global::LocalPetadocoes.Properties.Resources.icons8_mais_zoom_64;
            this.consultaClientes.Name = "consultaClientes";
            resources.ApplyResources(this.consultaClientes, "consultaClientes");
            this.consultaClientes.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // listarClientes
            // 
            this.listarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.listarClientes.Image = global::LocalPetadocoes.Properties.Resources.icons8_animal_folder_100;
            this.listarClientes.Name = "listarClientes";
            resources.ApplyResources(this.listarClientes, "listarClientes");
            this.listarClientes.Click += new System.EventHandler(this.listarClientes_Click);
            // 
            // ongsToolStripMenuItem
            // 
            this.ongsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.ongsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarOngs,
            this.consultaOngs});
            this.ongsToolStripMenuItem.Image = global::LocalPetadocoes.Properties.Resources.icons8_copas_64;
            this.ongsToolStripMenuItem.Name = "ongsToolStripMenuItem";
            resources.ApplyResources(this.ongsToolStripMenuItem, "ongsToolStripMenuItem");
            // 
            // listarOngs
            // 
            this.listarOngs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.listarOngs.Image = global::LocalPetadocoes.Properties.Resources.icons8_animal_folder_100;
            this.listarOngs.Name = "listarOngs";
            resources.ApplyResources(this.listarOngs, "listarOngs");
            this.listarOngs.Click += new System.EventHandler(this.listarOngs_Click);
            // 
            // consultaOngs
            // 
            this.consultaOngs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            resources.ApplyResources(this.consultaOngs, "consultaOngs");
            this.consultaOngs.Image = global::LocalPetadocoes.Properties.Resources.icons8_gerenciador_de_dispositivos_64;
            this.consultaOngs.Name = "consultaOngs";
            this.consultaOngs.Click += new System.EventHandler(this.consultaOngs_Click);
            // 
            // animaisToolStripMenuItem
            // 
            this.animaisToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.animaisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaAnimais,
            this.listarAnimais});
            this.animaisToolStripMenuItem.Image = global::LocalPetadocoes.Properties.Resources.icons8_paw_prints_64;
            this.animaisToolStripMenuItem.Name = "animaisToolStripMenuItem";
            resources.ApplyResources(this.animaisToolStripMenuItem, "animaisToolStripMenuItem");
            // 
            // consultaAnimais
            // 
            this.consultaAnimais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.consultaAnimais.Image = global::LocalPetadocoes.Properties.Resources.icons8_mais_zoom_64;
            this.consultaAnimais.Name = "consultaAnimais";
            resources.ApplyResources(this.consultaAnimais, "consultaAnimais");
            this.consultaAnimais.Click += new System.EventHandler(this.consultaAnimais_Click);
            // 
            // listarAnimais
            // 
            this.listarAnimais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.listarAnimais.Image = global::LocalPetadocoes.Properties.Resources.icons8_animal_folder_100;
            this.listarAnimais.Name = "listarAnimais";
            resources.ApplyResources(this.listarAnimais, "listarAnimais");
            this.listarAnimais.Click += new System.EventHandler(this.listarAnimais_Click);
            // 
            // operaçãoToolStripMenuItem
            // 
            this.operaçãoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.operaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gatoToolStripMenuItem,
            this.cachorroToolStripMenuItem});
            resources.ApplyResources(this.operaçãoToolStripMenuItem, "operaçãoToolStripMenuItem");
            this.operaçãoToolStripMenuItem.Image = global::LocalPetadocoes.Properties.Resources.icons8_animal_shelter_64;
            this.operaçãoToolStripMenuItem.Name = "operaçãoToolStripMenuItem";
            // 
            // gatoToolStripMenuItem
            // 
            this.gatoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.gatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GerenciarGatos,
            this.listarGatos});
            this.gatoToolStripMenuItem.Image = global::LocalPetadocoes.Properties.Resources.icons8_kitty_64;
            this.gatoToolStripMenuItem.Name = "gatoToolStripMenuItem";
            resources.ApplyResources(this.gatoToolStripMenuItem, "gatoToolStripMenuItem");
            // 
            // GerenciarGatos
            // 
            this.GerenciarGatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.GerenciarGatos.Image = global::LocalPetadocoes.Properties.Resources.icons8_gerenciador_de_dispositivos_641;
            this.GerenciarGatos.Name = "GerenciarGatos";
            resources.ApplyResources(this.GerenciarGatos, "GerenciarGatos");
            this.GerenciarGatos.Click += new System.EventHandler(this.GerenciarGatos_Click);
            // 
            // listarGatos
            // 
            this.listarGatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.listarGatos.Image = global::LocalPetadocoes.Properties.Resources.icons8_animal_folder_100;
            this.listarGatos.Name = "listarGatos";
            resources.ApplyResources(this.listarGatos, "listarGatos");
            // 
            // cachorroToolStripMenuItem
            // 
            this.cachorroToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.cachorroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCachorros,
            this.listarCachorros});
            this.cachorroToolStripMenuItem.Image = global::LocalPetadocoes.Properties.Resources.icons8_cachorro_64;
            this.cachorroToolStripMenuItem.Name = "cachorroToolStripMenuItem";
            resources.ApplyResources(this.cachorroToolStripMenuItem, "cachorroToolStripMenuItem");
            // 
            // consultarCachorros
            // 
            this.consultarCachorros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.consultarCachorros.Image = global::LocalPetadocoes.Properties.Resources.icons8_gerenciador_de_dispositivos_64;
            this.consultarCachorros.Name = "consultarCachorros";
            resources.ApplyResources(this.consultarCachorros, "consultarCachorros");
            // 
            // listarCachorros
            // 
            this.listarCachorros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.listarCachorros.Image = global::LocalPetadocoes.Properties.Resources.icons8_animal_folder_100;
            this.listarCachorros.Name = "listarCachorros";
            resources.ApplyResources(this.listarCachorros, "listarCachorros");
            // 
            // mOvimentoToolStripMenuItem
            // 
            this.mOvimentoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.mOvimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gatoStripMenuItem2,
            this.cachorrosToolStripMenuItem});
            resources.ApplyResources(this.mOvimentoToolStripMenuItem, "mOvimentoToolStripMenuItem");
            this.mOvimentoToolStripMenuItem.Image = global::LocalPetadocoes.Properties.Resources.icons8_pets_64;
            this.mOvimentoToolStripMenuItem.Name = "mOvimentoToolStripMenuItem";
            // 
            // gatoStripMenuItem2
            // 
            this.gatoStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.gatoStripMenuItem2.Image = global::LocalPetadocoes.Properties.Resources.icons8_kitty_64;
            this.gatoStripMenuItem2.Name = "gatoStripMenuItem2";
            resources.ApplyResources(this.gatoStripMenuItem2, "gatoStripMenuItem2");
            // 
            // cachorrosToolStripMenuItem
            // 
            this.cachorrosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
            this.cachorrosToolStripMenuItem.Image = global::LocalPetadocoes.Properties.Resources.icons8_cachorro_64;
            this.cachorrosToolStripMenuItem.Name = "cachorrosToolStripMenuItem";
            resources.ApplyResources(this.cachorrosToolStripMenuItem, "cachorrosToolStripMenuItem");
            // 
            // FormRelatorio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FormRelatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRelatorio_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaClientes;
        private System.Windows.Forms.ToolStripMenuItem listarClientes;
        private System.Windows.Forms.ToolStripMenuItem ongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarOngs;
        private System.Windows.Forms.ToolStripMenuItem consultaOngs;
        private System.Windows.Forms.ToolStripMenuItem animaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaAnimais;
        private System.Windows.Forms.ToolStripMenuItem listarAnimais;
        private System.Windows.Forms.ToolStripMenuItem operaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GerenciarGatos;
        private System.Windows.Forms.ToolStripMenuItem listarGatos;
        private System.Windows.Forms.ToolStripMenuItem cachorroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCachorros;
        private System.Windows.Forms.ToolStripMenuItem listarCachorros;
        private System.Windows.Forms.ToolStripMenuItem mOvimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gatoStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cachorrosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

