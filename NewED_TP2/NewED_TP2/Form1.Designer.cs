namespace NewED_TP2
{
    partial class Form1
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
            this.lvlNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lbContato = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lvlNome
            // 
            this.lvlNome.AutoSize = true;
            this.lvlNome.Location = new System.Drawing.Point(12, 16);
            this.lvlNome.Name = "lvlNome";
            this.lvlNome.Size = new System.Drawing.Size(38, 13);
            this.lvlNome.TabIndex = 0;
            this.lvlNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 43);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(12, 80);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Telefone:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 112);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(119, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 40);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(119, 73);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 6;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(119, 110);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(21, 20);
            this.txtDia.TabIndex = 7;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(147, 110);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(22, 20);
            this.txtMes.TabIndex = 8;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(176, 109);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(43, 20);
            this.txtAno.TabIndex = 9;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 140);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(12, 170);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(103, 140);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 12;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(103, 169);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 13;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(54, 205);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 14;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lbContato
            // 
            this.lbContato.FormattingEnabled = true;
            this.lbContato.Location = new System.Drawing.Point(235, 12);
            this.lbContato.Name = "lbContato";
            this.lbContato.Size = new System.Drawing.Size(389, 212);
            this.lbContato.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 240);
            this.Controls.Add(this.lbContato);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lvlNome);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lvlNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lbContato;
    }
}

