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
    public partial class Frm_ContaBancaria : Form
    {
        public Frm_ContaBancaria()
        {
            InitializeComponent();
        }

        ContaBancaria Conta = new ContaBancaria();

        private void Btn_Saque_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ContaBancaria_Load(object sender, EventArgs e) //Load é o carregamento da tela
        {
            //Na linha abaixo, para atribuir o valor dentro da classe, precisamos chamar o objeto instanciado.
            Txt_Saldo.Text = Conta.saldo.ToString();
        }
    }
}
