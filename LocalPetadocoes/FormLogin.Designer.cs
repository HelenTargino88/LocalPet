namespace LocalPetadocoes
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(234, 247);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 18);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Bem - Vindo(a)";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "";
            this.txtUsuario.Location = new System.Drawing.Point(171, 293);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(212, 23);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Depth = 0;
            this.txtSenha.Hint = "";
            this.txtSenha.Location = new System.Drawing.Point(171, 353);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(212, 23);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.TabStop = false;
            this.txtSenha.Text = "Senha";
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Depth = 0;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(322, 395);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(61, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(160, 473);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(212, 0);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::LocalPetadocoes.Properties.Resources.localpeticon21;
            this.pictureBox1.Location = new System.Drawing.Point(221, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 166);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(560, 502);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}