namespace Projeto_Banco
{
    partial class Frm_ContaBancaria
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
            this.Lbl_Agencia = new System.Windows.Forms.Label();
            this.Lbl_NumeroConta = new System.Windows.Forms.Label();
            this.Lbl_TitularConta = new System.Windows.Forms.Label();
            this.Txt_Agencia = new System.Windows.Forms.TextBox();
            this.Txt_NumeroConta = new System.Windows.Forms.TextBox();
            this.Txt_TitularConta = new System.Windows.Forms.TextBox();
            this.Btn_Saque = new System.Windows.Forms.Button();
            this.Btn_Deposito = new System.Windows.Forms.Button();
            this.Txt_Saldo = new System.Windows.Forms.TextBox();
            this.Txt_Valor = new System.Windows.Forms.TextBox();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Lbl_Saldo = new System.Windows.Forms.Label();
            this.Lbl_Saque = new System.Windows.Forms.Label();
            this.Lbl_Deposito = new System.Windows.Forms.Label();
            this.Lbl_Idade = new System.Windows.Forms.Label();
            this.Txt_Idade = new System.Windows.Forms.TextBox();
            this.Lbl_MesNascimento = new System.Windows.Forms.Label();
            this.Txt_Mes = new System.Windows.Forms.TextBox();
            this.Btn_Investir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Agencia
            // 
            this.Lbl_Agencia.AutoSize = true;
            this.Lbl_Agencia.Location = new System.Drawing.Point(183, 49);
            this.Lbl_Agencia.Name = "Lbl_Agencia";
            this.Lbl_Agencia.Size = new System.Drawing.Size(46, 13);
            this.Lbl_Agencia.TabIndex = 0;
            this.Lbl_Agencia.Text = "Agência";
            // 
            // Lbl_NumeroConta
            // 
            this.Lbl_NumeroConta.AutoSize = true;
            this.Lbl_NumeroConta.Location = new System.Drawing.Point(297, 49);
            this.Lbl_NumeroConta.Name = "Lbl_NumeroConta";
            this.Lbl_NumeroConta.Size = new System.Drawing.Size(65, 13);
            this.Lbl_NumeroConta.TabIndex = 1;
            this.Lbl_NumeroConta.Text = "Nº da Conta";
            // 
            // Lbl_TitularConta
            // 
            this.Lbl_TitularConta.AutoSize = true;
            this.Lbl_TitularConta.Location = new System.Drawing.Point(403, 49);
            this.Lbl_TitularConta.Name = "Lbl_TitularConta";
            this.Lbl_TitularConta.Size = new System.Drawing.Size(82, 13);
            this.Lbl_TitularConta.TabIndex = 3;
            this.Lbl_TitularConta.Text = "Titular da Conta";
            // 
            // Txt_Agencia
            // 
            this.Txt_Agencia.Location = new System.Drawing.Point(183, 65);
            this.Txt_Agencia.MaxLength = 4;
            this.Txt_Agencia.Name = "Txt_Agencia";
            this.Txt_Agencia.Size = new System.Drawing.Size(100, 20);
            this.Txt_Agencia.TabIndex = 4;
            this.Txt_Agencia.TabStop = false;
            this.Txt_Agencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Agencia_KeyPress);
            // 
            // Txt_NumeroConta
            // 
            this.Txt_NumeroConta.Location = new System.Drawing.Point(297, 65);
            this.Txt_NumeroConta.MaxLength = 5;
            this.Txt_NumeroConta.Name = "Txt_NumeroConta";
            this.Txt_NumeroConta.Size = new System.Drawing.Size(100, 20);
            this.Txt_NumeroConta.TabIndex = 5;
            this.Txt_NumeroConta.TabStop = false;
            this.Txt_NumeroConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NumeroConta_KeyPress);
            // 
            // Txt_TitularConta
            // 
            this.Txt_TitularConta.Location = new System.Drawing.Point(403, 65);
            this.Txt_TitularConta.MaxLength = 30;
            this.Txt_TitularConta.Name = "Txt_TitularConta";
            this.Txt_TitularConta.Size = new System.Drawing.Size(215, 20);
            this.Txt_TitularConta.TabIndex = 6;
            this.Txt_TitularConta.TabStop = false;
            this.Txt_TitularConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_TitularConta_KeyPress);
            // 
            // Btn_Saque
            // 
            this.Btn_Saque.Location = new System.Drawing.Point(183, 114);
            this.Btn_Saque.Name = "Btn_Saque";
            this.Btn_Saque.Size = new System.Drawing.Size(75, 23);
            this.Btn_Saque.TabIndex = 8;
            this.Btn_Saque.Text = "Saque";
            this.Btn_Saque.UseVisualStyleBackColor = true;
            this.Btn_Saque.Click += new System.EventHandler(this.Btn_Saque_Click);
            // 
            // Btn_Deposito
            // 
            this.Btn_Deposito.Location = new System.Drawing.Point(297, 114);
            this.Btn_Deposito.Name = "Btn_Deposito";
            this.Btn_Deposito.Size = new System.Drawing.Size(75, 23);
            this.Btn_Deposito.TabIndex = 9;
            this.Btn_Deposito.Text = "Depósito";
            this.Btn_Deposito.UseVisualStyleBackColor = true;
            this.Btn_Deposito.Click += new System.EventHandler(this.Btn_Deposito_Click);
            // 
            // Txt_Saldo
            // 
            this.Txt_Saldo.Enabled = false;
            this.Txt_Saldo.Location = new System.Drawing.Point(518, 117);
            this.Txt_Saldo.Name = "Txt_Saldo";
            this.Txt_Saldo.Size = new System.Drawing.Size(100, 20);
            this.Txt_Saldo.TabIndex = 13;
            // 
            // Txt_Valor
            // 
            this.Txt_Valor.Location = new System.Drawing.Point(403, 117);
            this.Txt_Valor.Name = "Txt_Valor";
            this.Txt_Valor.Size = new System.Drawing.Size(100, 20);
            this.Txt_Valor.TabIndex = 12;
            this.Txt_Valor.TabStop = false;
            this.Txt_Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Valor_KeyPress);
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.Location = new System.Drawing.Point(403, 101);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(31, 13);
            this.Lbl_Valor.TabIndex = 11;
            this.Lbl_Valor.Text = "Valor";
            // 
            // Lbl_Saldo
            // 
            this.Lbl_Saldo.AutoSize = true;
            this.Lbl_Saldo.Location = new System.Drawing.Point(518, 101);
            this.Lbl_Saldo.Name = "Lbl_Saldo";
            this.Lbl_Saldo.Size = new System.Drawing.Size(88, 13);
            this.Lbl_Saldo.TabIndex = 10;
            this.Lbl_Saldo.Text = "Saldo Disponível";
            // 
            // Lbl_Saque
            // 
            this.Lbl_Saque.AutoSize = true;
            this.Lbl_Saque.Enabled = false;
            this.Lbl_Saque.Location = new System.Drawing.Point(203, 158);
            this.Lbl_Saque.Name = "Lbl_Saque";
            this.Lbl_Saque.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Saque.TabIndex = 14;
            // 
            // Lbl_Deposito
            // 
            this.Lbl_Deposito.AutoSize = true;
            this.Lbl_Deposito.Enabled = false;
            this.Lbl_Deposito.Location = new System.Drawing.Point(317, 158);
            this.Lbl_Deposito.Name = "Lbl_Deposito";
            this.Lbl_Deposito.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Deposito.TabIndex = 15;
            // 
            // Lbl_Idade
            // 
            this.Lbl_Idade.AutoSize = true;
            this.Lbl_Idade.Location = new System.Drawing.Point(632, 49);
            this.Lbl_Idade.Name = "Lbl_Idade";
            this.Lbl_Idade.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Idade.TabIndex = 16;
            this.Lbl_Idade.Text = "Idade";
            // 
            // Txt_Idade
            // 
            this.Txt_Idade.Location = new System.Drawing.Point(624, 65);
            this.Txt_Idade.MaxLength = 3;
            this.Txt_Idade.Name = "Txt_Idade";
            this.Txt_Idade.Size = new System.Drawing.Size(50, 20);
            this.Txt_Idade.TabIndex = 17;
            this.Txt_Idade.TabStop = false;
            this.Txt_Idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Idade_KeyPress);
            // 
            // Lbl_MesNascimento
            // 
            this.Lbl_MesNascimento.AutoSize = true;
            this.Lbl_MesNascimento.Location = new System.Drawing.Point(680, 49);
            this.Lbl_MesNascimento.Name = "Lbl_MesNascimento";
            this.Lbl_MesNascimento.Size = new System.Drawing.Size(86, 13);
            this.Lbl_MesNascimento.TabIndex = 18;
            this.Lbl_MesNascimento.Text = "Mês Nascimento";
            // 
            // Txt_Mes
            // 
            this.Txt_Mes.Location = new System.Drawing.Point(705, 65);
            this.Txt_Mes.MaxLength = 2;
            this.Txt_Mes.Name = "Txt_Mes";
            this.Txt_Mes.Size = new System.Drawing.Size(27, 20);
            this.Txt_Mes.TabIndex = 19;
            this.Txt_Mes.TabStop = false;
            this.Txt_Mes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Mes_KeyPress);
            // 
            // Btn_Investir
            // 
            this.Btn_Investir.Location = new System.Drawing.Point(635, 117);
            this.Btn_Investir.Name = "Btn_Investir";
            this.Btn_Investir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Investir.TabIndex = 20;
            this.Btn_Investir.Text = "Investir";
            this.Btn_Investir.UseVisualStyleBackColor = true;
            this.Btn_Investir.Click += new System.EventHandler(this.Btn_Investir_Click);
            // 
            // Frm_ContaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 185);
            this.Controls.Add(this.Btn_Investir);
            this.Controls.Add(this.Txt_Mes);
            this.Controls.Add(this.Lbl_MesNascimento);
            this.Controls.Add(this.Txt_Idade);
            this.Controls.Add(this.Lbl_Idade);
            this.Controls.Add(this.Lbl_Deposito);
            this.Controls.Add(this.Lbl_Saque);
            this.Controls.Add(this.Txt_Saldo);
            this.Controls.Add(this.Txt_Valor);
            this.Controls.Add(this.Lbl_Valor);
            this.Controls.Add(this.Lbl_Saldo);
            this.Controls.Add(this.Btn_Deposito);
            this.Controls.Add(this.Btn_Saque);
            this.Controls.Add(this.Txt_TitularConta);
            this.Controls.Add(this.Txt_NumeroConta);
            this.Controls.Add(this.Txt_Agencia);
            this.Controls.Add(this.Lbl_TitularConta);
            this.Controls.Add(this.Lbl_NumeroConta);
            this.Controls.Add(this.Lbl_Agencia);
            this.Name = "Frm_ContaBancaria";
            this.Text = "Conta Bancária";
            this.Load += new System.EventHandler(this.Frm_ContaBancaria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Agencia;
        private System.Windows.Forms.Label Lbl_NumeroConta;
        private System.Windows.Forms.Label Lbl_TitularConta;
        private System.Windows.Forms.TextBox Txt_Agencia;
        private System.Windows.Forms.TextBox Txt_NumeroConta;
        private System.Windows.Forms.TextBox Txt_TitularConta;
        private System.Windows.Forms.Button Btn_Saque;
        private System.Windows.Forms.Button Btn_Deposito;
        private System.Windows.Forms.TextBox Txt_Saldo;
        private System.Windows.Forms.TextBox Txt_Valor;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.Label Lbl_Saldo;
        private System.Windows.Forms.Label Lbl_Saque;
        private System.Windows.Forms.Label Lbl_Deposito;
        private System.Windows.Forms.Label Lbl_Idade;
        private System.Windows.Forms.TextBox Txt_Idade;
        private System.Windows.Forms.Label Lbl_MesNascimento;
        private System.Windows.Forms.TextBox Txt_Mes;
        public System.Windows.Forms.Button Btn_Investir;
    }
}

