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
            // Frm_ContaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 185);
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
    }
}

