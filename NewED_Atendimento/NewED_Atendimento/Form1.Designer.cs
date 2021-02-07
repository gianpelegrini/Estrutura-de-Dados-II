namespace NewED_Atendimento
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
            this.rtx1 = new System.Windows.Forms.RichTextBox();
            this.rtx2 = new System.Windows.Forms.RichTextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnChamar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnListarS = new System.Windows.Forms.Button();
            this.btnListarA = new System.Windows.Forms.Button();
            this.lblGuiche3 = new System.Windows.Forms.Label();
            this.txbGuiche = new System.Windows.Forms.TextBox();
            this.lblGuiches2 = new System.Windows.Forms.Label();
            this.lblGuiches = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtx1
            // 
            this.rtx1.Location = new System.Drawing.Point(12, 75);
            this.rtx1.Name = "rtx1";
            this.rtx1.Size = new System.Drawing.Size(132, 96);
            this.rtx1.TabIndex = 0;
            this.rtx1.Text = "";
            // 
            // rtx2
            // 
            this.rtx2.Location = new System.Drawing.Point(293, 75);
            this.rtx2.Name = "rtx2";
            this.rtx2.Size = new System.Drawing.Size(229, 96);
            this.rtx2.TabIndex = 1;
            this.rtx2.Text = "";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(44, 35);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnChamar
            // 
            this.btnChamar.Location = new System.Drawing.Point(447, 36);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.Size = new System.Drawing.Size(75, 23);
            this.btnChamar.TabIndex = 3;
            this.btnChamar.Text = "Chamar";
            this.btnChamar.UseVisualStyleBackColor = true;
            this.btnChamar.Click += new System.EventHandler(this.btnChamar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(175, 148);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnListarS
            // 
            this.btnListarS.Location = new System.Drawing.Point(29, 197);
            this.btnListarS.Name = "btnListarS";
            this.btnListarS.Size = new System.Drawing.Size(100, 23);
            this.btnListarS.TabIndex = 5;
            this.btnListarS.Text = "Listar Senhas";
            this.btnListarS.UseVisualStyleBackColor = true;
            this.btnListarS.Click += new System.EventHandler(this.btnListarS_Click);
            // 
            // btnListarA
            // 
            this.btnListarA.Location = new System.Drawing.Point(341, 188);
            this.btnListarA.Name = "btnListarA";
            this.btnListarA.Size = new System.Drawing.Size(127, 23);
            this.btnListarA.TabIndex = 6;
            this.btnListarA.Text = "Listar Atendimentos";
            this.btnListarA.UseVisualStyleBackColor = true;
            this.btnListarA.Click += new System.EventHandler(this.btnListarA_Click);
            // 
            // lblGuiche3
            // 
            this.lblGuiche3.AutoSize = true;
            this.lblGuiche3.Location = new System.Drawing.Point(300, 41);
            this.lblGuiche3.Name = "lblGuiche3";
            this.lblGuiche3.Size = new System.Drawing.Size(41, 13);
            this.lblGuiche3.TabIndex = 7;
            this.lblGuiche3.Text = "Guiche";
            // 
            // txbGuiche
            // 
            this.txbGuiche.Location = new System.Drawing.Point(341, 38);
            this.txbGuiche.Name = "txbGuiche";
            this.txbGuiche.Size = new System.Drawing.Size(100, 20);
            this.txbGuiche.TabIndex = 8;
            // 
            // lblGuiches2
            // 
            this.lblGuiches2.AutoSize = true;
            this.lblGuiches2.Location = new System.Drawing.Point(188, 95);
            this.lblGuiches2.Name = "lblGuiches2";
            this.lblGuiches2.Size = new System.Drawing.Size(49, 13);
            this.lblGuiches2.TabIndex = 9;
            this.lblGuiches2.Text = "Guichês:";
            // 
            // lblGuiches
            // 
            this.lblGuiches.AutoSize = true;
            this.lblGuiches.Location = new System.Drawing.Point(205, 117);
            this.lblGuiches.Name = "lblGuiches";
            this.lblGuiches.Size = new System.Drawing.Size(13, 13);
            this.lblGuiches.TabIndex = 10;
            this.lblGuiches.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 232);
            this.Controls.Add(this.lblGuiches);
            this.Controls.Add(this.lblGuiches2);
            this.Controls.Add(this.txbGuiche);
            this.Controls.Add(this.lblGuiche3);
            this.Controls.Add(this.btnListarA);
            this.Controls.Add(this.btnListarS);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.rtx2);
            this.Controls.Add(this.rtx1);
            this.Name = "Form1";
            this.Text = "Atendimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtx1;
        private System.Windows.Forms.RichTextBox rtx2;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnChamar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnListarS;
        private System.Windows.Forms.Button btnListarA;
        private System.Windows.Forms.Label lblGuiche3;
        private System.Windows.Forms.TextBox txbGuiche;
        private System.Windows.Forms.Label lblGuiches2;
        private System.Windows.Forms.Label lblGuiches;
    }
}

