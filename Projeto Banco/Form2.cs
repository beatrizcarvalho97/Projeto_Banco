using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Banco
{
    public partial class Frm_Investimentos : Form
    {
        public Frm_Investimentos()
        {
            InitializeComponent();
        }

        ContaBancaria Conta = new ContaBancaria();

        int mes, contador;

        private void Txt_Investimento_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Investimento.Text == "" || double.Parse(Txt_Investimento.Text) <100 || Conta.investimento > Conta.saldo)
            {
                Num_Meses.Enabled = false;  // Mantém o item de meses desativado.
            }
            else
            {
                Num_Meses.Enabled = true;   // Habilita o item de meses.
                Num_Meses.Focus();          // Posiciona o cursor para o campo de meses
            }
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_ContaBancaria contaBancaria = new Frm_ContaBancaria(); // Instanciando um objeto contaBancaria para chamar a tela inicial.
            contaBancaria.Show();
            Hide();
        }
    }
}
