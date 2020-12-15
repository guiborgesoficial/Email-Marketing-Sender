namespace EmailMKT2
{
    partial class frm_sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sistema));
            this.groupBox_Configurações = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.textBox_SMTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_porta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.textBox_escreverEmail = new System.Windows.Forms.TextBox();
            this.textBox_assunto = new System.Windows.Forms.TextBox();
            this.textBox_para = new System.Windows.Forms.TextBox();
            this.lbl_escreverEmail = new System.Windows.Forms.Label();
            this.lbl_assunto = new System.Windows.Forms.Label();
            this.lbl_para = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_anexoBuscar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_anexo = new System.Windows.Forms.TextBox();
            this.btn_lista = new System.Windows.Forms.Button();
            this.groupBox_Configurações.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Configurações
            // 
            this.groupBox_Configurações.Controls.Add(this.pictureBox1);
            this.groupBox_Configurações.Controls.Add(this.btn_enviar);
            this.groupBox_Configurações.Controls.Add(this.textBox_SMTP);
            this.groupBox_Configurações.Controls.Add(this.label2);
            this.groupBox_Configurações.Controls.Add(this.textBox_porta);
            this.groupBox_Configurações.Controls.Add(this.label1);
            this.groupBox_Configurações.Controls.Add(this.textBox_senha);
            this.groupBox_Configurações.Controls.Add(this.textBox_email);
            this.groupBox_Configurações.Controls.Add(this.lbl_Email);
            this.groupBox_Configurações.Controls.Add(this.lbl_senha);
            this.groupBox_Configurações.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Configurações.Location = new System.Drawing.Point(146, 272);
            this.groupBox_Configurações.Name = "groupBox_Configurações";
            this.groupBox_Configurações.Size = new System.Drawing.Size(408, 148);
            this.groupBox_Configurações.TabIndex = 11;
            this.groupBox_Configurações.TabStop = false;
            this.groupBox_Configurações.Text = "Configurações e Conta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // btn_enviar
            // 
            this.btn_enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enviar.Location = new System.Drawing.Point(56, 109);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(233, 23);
            this.btn_enviar.TabIndex = 5;
            this.btn_enviar.Text = "ENVIAR";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // textBox_SMTP
            // 
            this.textBox_SMTP.Location = new System.Drawing.Point(181, 71);
            this.textBox_SMTP.Name = "textBox_SMTP";
            this.textBox_SMTP.Size = new System.Drawing.Size(132, 20);
            this.textBox_SMTP.TabIndex = 4;
            this.textBox_SMTP.Text = "smtp.office365.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "SMTP:";
            // 
            // textBox_porta
            // 
            this.textBox_porta.Location = new System.Drawing.Point(56, 71);
            this.textBox_porta.Name = "textBox_porta";
            this.textBox_porta.Size = new System.Drawing.Size(66, 20);
            this.textBox_porta.TabIndex = 3;
            this.textBox_porta.Text = "587";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Porta:";
            // 
            // textBox_senha
            // 
            this.textBox_senha.Location = new System.Drawing.Point(56, 45);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.Size = new System.Drawing.Size(191, 20);
            this.textBox_senha.TabIndex = 2;
            this.textBox_senha.UseSystemPasswordChar = true;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(56, 19);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(191, 20);
            this.textBox_email.TabIndex = 0;
            this.textBox_email.Text = "DIGITE O SEU EMAIL";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(4, 16);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(58, 21);
            this.lbl_Email.TabIndex = 10;
            this.lbl_Email.Text = "E-mail:";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(4, 42);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(58, 21);
            this.lbl_senha.TabIndex = 11;
            this.lbl_senha.Text = "Senha:";
            // 
            // textBox_escreverEmail
            // 
            this.textBox_escreverEmail.Location = new System.Drawing.Point(146, 99);
            this.textBox_escreverEmail.Multiline = true;
            this.textBox_escreverEmail.Name = "textBox_escreverEmail";
            this.textBox_escreverEmail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_escreverEmail.Size = new System.Drawing.Size(408, 122);
            this.textBox_escreverEmail.TabIndex = 9;
            // 
            // textBox_assunto
            // 
            this.textBox_assunto.Location = new System.Drawing.Point(146, 73);
            this.textBox_assunto.Name = "textBox_assunto";
            this.textBox_assunto.Size = new System.Drawing.Size(408, 20);
            this.textBox_assunto.TabIndex = 7;
            // 
            // textBox_para
            // 
            this.textBox_para.Location = new System.Drawing.Point(146, 7);
            this.textBox_para.MaxLength = 1000000000;
            this.textBox_para.Multiline = true;
            this.textBox_para.Name = "textBox_para";
            this.textBox_para.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_para.Size = new System.Drawing.Size(313, 60);
            this.textBox_para.TabIndex = 5;
            // 
            // lbl_escreverEmail
            // 
            this.lbl_escreverEmail.AutoSize = true;
            this.lbl_escreverEmail.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_escreverEmail.Location = new System.Drawing.Point(16, 96);
            this.lbl_escreverEmail.Name = "lbl_escreverEmail";
            this.lbl_escreverEmail.Size = new System.Drawing.Size(124, 21);
            this.lbl_escreverEmail.TabIndex = 10;
            this.lbl_escreverEmail.Text = "Escrever e-mail:";
            // 
            // lbl_assunto
            // 
            this.lbl_assunto.AutoSize = true;
            this.lbl_assunto.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_assunto.Location = new System.Drawing.Point(67, 70);
            this.lbl_assunto.Name = "lbl_assunto";
            this.lbl_assunto.Size = new System.Drawing.Size(73, 21);
            this.lbl_assunto.TabIndex = 8;
            this.lbl_assunto.Text = "Assunto:";
            // 
            // lbl_para
            // 
            this.lbl_para.AutoSize = true;
            this.lbl_para.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_para.Location = new System.Drawing.Point(95, 9);
            this.lbl_para.Name = "lbl_para";
            this.lbl_para.Size = new System.Drawing.Size(45, 21);
            this.lbl_para.TabIndex = 6;
            this.lbl_para.Text = "Para:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Anexo:";
            // 
            // btn_anexoBuscar
            // 
            this.btn_anexoBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_anexoBuscar.Location = new System.Drawing.Point(465, 227);
            this.btn_anexoBuscar.Name = "btn_anexoBuscar";
            this.btn_anexoBuscar.Size = new System.Drawing.Size(89, 23);
            this.btn_anexoBuscar.TabIndex = 17;
            this.btn_anexoBuscar.Text = "BUSCAR";
            this.btn_anexoBuscar.UseVisualStyleBackColor = true;
            this.btn_anexoBuscar.Click += new System.EventHandler(this.btn_anexoBuscar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox_anexo
            // 
            this.textBox_anexo.Location = new System.Drawing.Point(337, 230);
            this.textBox_anexo.Name = "textBox_anexo";
            this.textBox_anexo.Size = new System.Drawing.Size(122, 20);
            this.textBox_anexo.TabIndex = 18;
            // 
            // btn_lista
            // 
            this.btn_lista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lista.Location = new System.Drawing.Point(465, 7);
            this.btn_lista.Name = "btn_lista";
            this.btn_lista.Size = new System.Drawing.Size(89, 60);
            this.btn_lista.TabIndex = 23;
            this.btn_lista.Text = "LISTA";
            this.btn_lista.UseVisualStyleBackColor = true;
            this.btn_lista.Click += new System.EventHandler(this.btn_lista_Click);
            // 
            // frm_sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.btn_lista);
            this.Controls.Add(this.textBox_anexo);
            this.Controls.Add(this.btn_anexoBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox_Configurações);
            this.Controls.Add(this.textBox_escreverEmail);
            this.Controls.Add(this.textBox_assunto);
            this.Controls.Add(this.textBox_para);
            this.Controls.Add(this.lbl_escreverEmail);
            this.Controls.Add(this.lbl_assunto);
            this.Controls.Add(this.lbl_para);
            this.Name = "frm_sistema";
            this.groupBox_Configurações.ResumeLayout(false);
            this.groupBox_Configurações.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Configurações;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.TextBox textBox_SMTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_porta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox textBox_escreverEmail;
        private System.Windows.Forms.TextBox textBox_assunto;
        private System.Windows.Forms.TextBox textBox_para;
        private System.Windows.Forms.Label lbl_escreverEmail;
        private System.Windows.Forms.Label lbl_assunto;
        private System.Windows.Forms.Label lbl_para;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_anexoBuscar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox_anexo;
        private System.Windows.Forms.Button btn_lista;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

