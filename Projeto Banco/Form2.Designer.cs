namespace Projeto_Banco
{
    partial class Frm_Investimentos
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
            this.Lbl_Saldo = new System.Windows.Forms.Label();
            this.Lbl_ValorInvestimento = new System.Windows.Forms.Label();
            this.Lbl_NumeroMeses = new System.Windows.Forms.Label();
            this.Num_Meses = new System.Windows.Forms.NumericUpDown();
            this.Txt_Investimento = new System.Windows.Forms.TextBox();
            this.Txt_Saldo = new System.Windows.Forms.TextBox();
            this.Lbl_Mes = new System.Windows.Forms.Label();
            this.Lbl_Investimento = new System.Windows.Forms.Label();
            this.List_Meses = new System.Windows.Forms.ListBox();
            this.Lbl_Rendimento = new System.Windows.Forms.Label();
            this.List_Rendimento = new System.Windows.Forms.ListBox();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Meses)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Saldo
            // 
            this.Lbl_Saldo.AutoSize = true;
            this.Lbl_Saldo.Location = new System.Drawing.Point(66, 99);
            this.Lbl_Saldo.Name = "Lbl_Saldo";
            this.Lbl_Saldo.Size = new System.Drawing.Size(88, 13);
            this.Lbl_Saldo.TabIndex = 0;
            this.Lbl_Saldo.Text = "Saldo Disponível";
            // 
            // Lbl_ValorInvestimento
            // 
            this.Lbl_ValorInvestimento.AutoSize = true;
            this.Lbl_ValorInvestimento.Location = new System.Drawing.Point(66, 192);
            this.Lbl_ValorInvestimento.Name = "Lbl_ValorInvestimento";
            this.Lbl_ValorInvestimento.Size = new System.Drawing.Size(109, 13);
            this.Lbl_ValorInvestimento.TabIndex = 1;
            this.Lbl_ValorInvestimento.Text = "Valor do Investimento";
            // 
            // Lbl_NumeroMeses
            // 
            this.Lbl_NumeroMeses.AutoSize = true;
            this.Lbl_NumeroMeses.Location = new System.Drawing.Point(66, 285);
            this.Lbl_NumeroMeses.Name = "Lbl_NumeroMeses";
            this.Lbl_NumeroMeses.Size = new System.Drawing.Size(93, 13);
            this.Lbl_NumeroMeses.TabIndex = 2;
            this.Lbl_NumeroMeses.Text = "Número de Meses";
            // 
            // Num_Meses
            // 
            this.Num_Meses.Enabled = false;
            this.Num_Meses.Location = new System.Drawing.Point(80, 301);
            this.Num_Meses.Name = "Num_Meses";
            this.Num_Meses.Size = new System.Drawing.Size(58, 20);
            this.Num_Meses.TabIndex = 3;
            this.Num_Meses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_Investimento
            // 
            this.Txt_Investimento.Location = new System.Drawing.Point(66, 209);
            this.Txt_Investimento.Name = "Txt_Investimento";
            this.Txt_Investimento.Size = new System.Drawing.Size(100, 20);
            this.Txt_Investimento.TabIndex = 4;
            this.Txt_Investimento.TextChanged += new System.EventHandler(this.Txt_Investimento_TextChanged);
            // 
            // Txt_Saldo
            // 
            this.Txt_Saldo.Enabled = false;
            this.Txt_Saldo.Location = new System.Drawing.Point(66, 116);
            this.Txt_Saldo.Name = "Txt_Saldo";
            this.Txt_Saldo.Size = new System.Drawing.Size(100, 20);
            this.Txt_Saldo.TabIndex = 5;
            // 
            // Lbl_Mes
            // 
            this.Lbl_Mes.AutoSize = true;
            this.Lbl_Mes.Location = new System.Drawing.Point(270, 50);
            this.Lbl_Mes.Name = "Lbl_Mes";
            this.Lbl_Mes.Size = new System.Drawing.Size(27, 13);
            this.Lbl_Mes.TabIndex = 6;
            this.Lbl_Mes.Text = "Mês";
            // 
            // Lbl_Investimento
            // 
            this.Lbl_Investimento.AutoSize = true;
            this.Lbl_Investimento.Location = new System.Drawing.Point(273, 13);
            this.Lbl_Investimento.Name = "Lbl_Investimento";
            this.Lbl_Investimento.Size = new System.Drawing.Size(67, 13);
            this.Lbl_Investimento.TabIndex = 7;
            this.Lbl_Investimento.Text = "Investimento";
            // 
            // List_Meses
            // 
            this.List_Meses.FormattingEnabled = true;
            this.List_Meses.Location = new System.Drawing.Point(273, 67);
            this.List_Meses.Name = "List_Meses";
            this.List_Meses.Size = new System.Drawing.Size(124, 303);
            this.List_Meses.TabIndex = 8;
            // 
            // Lbl_Rendimento
            // 
            this.Lbl_Rendimento.AutoSize = true;
            this.Lbl_Rendimento.Location = new System.Drawing.Point(487, 50);
            this.Lbl_Rendimento.Name = "Lbl_Rendimento";
            this.Lbl_Rendimento.Size = new System.Drawing.Size(64, 13);
            this.Lbl_Rendimento.TabIndex = 9;
            this.Lbl_Rendimento.Text = "Rendimento";
            // 
            // List_Rendimento
            // 
            this.List_Rendimento.FormattingEnabled = true;
            this.List_Rendimento.Location = new System.Drawing.Point(490, 67);
            this.List_Rendimento.Name = "List_Rendimento";
            this.List_Rendimento.Size = new System.Drawing.Size(117, 303);
            this.List_Rendimento.TabIndex = 10;
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Location = new System.Drawing.Point(664, 83);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Voltar.TabIndex = 11;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Frm_Investimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.List_Rendimento);
            this.Controls.Add(this.Lbl_Rendimento);
            this.Controls.Add(this.List_Meses);
            this.Controls.Add(this.Lbl_Investimento);
            this.Controls.Add(this.Lbl_Mes);
            this.Controls.Add(this.Txt_Saldo);
            this.Controls.Add(this.Txt_Investimento);
            this.Controls.Add(this.Num_Meses);
            this.Controls.Add(this.Lbl_NumeroMeses);
            this.Controls.Add(this.Lbl_ValorInvestimento);
            this.Controls.Add(this.Lbl_Saldo);
            this.Name = "Frm_Investimentos";
            this.Text = "Investimentos";
            ((System.ComponentModel.ISupportInitialize)(this.Num_Meses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Saldo;
        private System.Windows.Forms.Label Lbl_ValorInvestimento;
        private System.Windows.Forms.Label Lbl_NumeroMeses;
        private System.Windows.Forms.NumericUpDown Num_Meses;
        private System.Windows.Forms.TextBox Txt_Investimento;
        private System.Windows.Forms.Label Lbl_Mes;
        private System.Windows.Forms.Label Lbl_Investimento;
        private System.Windows.Forms.ListBox List_Meses;
        private System.Windows.Forms.Label Lbl_Rendimento;
        private System.Windows.Forms.ListBox List_Rendimento;
        private System.Windows.Forms.Button Btn_Voltar;
        public System.Windows.Forms.TextBox Txt_Saldo;
    }
}