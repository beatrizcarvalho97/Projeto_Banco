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
        int contadorSaque, contadorDeposito; // Declarando as variáveis para contagem de saque e depósito.

        private void Btn_Saque_Click(object sender, EventArgs e)
        {
            if (Txt_Agencia.TextLength == 4 && Txt_NumeroConta.TextLength == 5 && Txt_TitularConta.TextLength >= 3 && Txt_Valor.Text != "")
            {
                // Armazenando todas as informações que foram digitadas para as variáveis da classe.
                // Quem irá receber o valor?
                // Neste caso é o objeto/classe "conta" e o atributo correspondente a informação.

                Conta.agencia = int.Parse(Txt_Agencia.Text);
                Conta.numeroConta = int.Parse(Txt_NumeroConta.Text);
                Conta.titularConta = Txt_TitularConta.Text;
                Conta.valor = double.Parse(Txt_Valor.Text);

                if (Conta.valor <= Conta.saldo)
                {
                    Conta.Realiza_Saque();
                    // Este item precisa acontecer aqui pois a classe não reconhece o campo do Txt, para "incluir" o valor na campo a ser preenchido.
                    Txt_Saldo.Text = Conta.saldo.ToString();
                    contadorSaque++;
                    Lbl_Saque.Text = contadorSaque.ToString();
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente para valor solicitado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Existem campos não preenchidos! Verifique e preencha os mesmos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_ContaBancaria_Load(object sender, EventArgs e) //Load é o carregamento da tela
        {
            //Na linha abaixo, para atribuir o valor dentro da classe, precisamos chamar o objeto instanciado.
            Txt_Saldo.Text = Conta.saldo.ToString();
        }

        private void Txt_Agencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //O Primeiro IF, se refere a validação dos caracteres.
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) //O "e" é uma variável que armazena o valor digitado; as duas condições inseridas: Liberando apenas os números e teclas de controle.
            {
                e.Handled = true;         //Verificando se o valor digitado é um número.

                MessageBox.Show("O campo AGÊNCIA só permite números!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //O segundo se refere ao pressionamento da tecla "Enter".
            if (e.KeyChar == 13) // Condição do uso da tecla Enter
            {
                if (Txt_Agencia.TextLength == 4) // Condição para verificar a quantidade de digitos
                {
                    Txt_NumeroConta.Focus(); // Posiciona o cursor para o próximo campo a ser preenchido.
                }
                else
                {
                    MessageBox.Show("O campo AGÊNCIA deve ser preenchido com 4 digitos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Txt_NumeroConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("O campo NÚMERO DA CONTA só permite números!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (e.KeyChar == 13)
            {
                if (Txt_NumeroConta.MaxLength == 5)
                {
                    Txt_TitularConta.Focus();
                }
                else
                {
                    MessageBox.Show("O campo NÚMERO DA AGÊNCIA deve ser preenchido com 5 digitos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Txt_TitularConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("O campo TITULAR DA CONTA só permite letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Txt_TitularConta.TextLength >= 3 && Txt_TitularConta.TextLength <= 30)
            {
                if (e.KeyChar == 13)
                {
                    Txt_Valor.Focus();
                }
            }
            else
            {
                MessageBox.Show("O campo TITULAR DA CONTA deve ter no mínimo 3 letras e no máximo 30", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Txt_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("O campo VALOR só permite números!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Txt_Valor.Text != "" && e.KeyChar == 13)
            {
                Btn_Saque.Focus();
            }
            else
            {
                MessageBox.Show("O campo de valor precisa ser preenchido! Digite um valor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_Idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
              /*  if (Txt_Idade.MaxLength <= 3)
                {*/
                    e.Handled = true;
                    MessageBox.Show("O campo IDADE só permite números!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                if (e.KeyChar == 13)
                {
                    //Conta.idade = int.Parse(Txt_Idade.Text);
                    if (Txt_Idade.Text != "")
                    {
                         Conta.idade = int.Parse(Txt_Idade.Text);

                        if (Conta.idade >= 18)
                        {
                            Txt_Mes.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Somente maior de idade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Txt_Idade.Clear();
                            Txt_Idade.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este campo não pode estar vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Txt_Idade.Clear();
                        Txt_Idade.Focus();
                    }
                }
            
        
        }

        private void Btn_Deposito_Click(object sender, EventArgs e)
        {
            if (Txt_Agencia.TextLength == 4 && Txt_NumeroConta.TextLength == 5 && Txt_TitularConta.TextLength >= 3 && Txt_Valor.Text != "")
            {
                // Armazenando todas as informações que foram digitadas para as variáveis da classe.
                // Quem irá receber o valor?
                // Neste caso é o objeto/classe "conta" e o atributo correspondente a informação.

                Conta.agencia = int.Parse(Txt_Agencia.Text);
                Conta.numeroConta = int.Parse(Txt_NumeroConta.Text);
                Conta.titularConta = Txt_TitularConta.Text;
                Conta.valor = double.Parse(Txt_Valor.Text);

                Conta.Realiza_Deposito();
                // Este item precisa acontecer aqui pois a classe não reconhece o campo do Txt, para "incluir" o valor na campo a ser preenchido.
                Txt_Saldo.Text = Conta.saldo.ToString();

                MessageBox.Show("Depósito realizado com sucesso!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contadorDeposito++;
                Lbl_Deposito.Text = contadorDeposito.ToString();
            }
            else
            {
                MessageBox.Show("Verifique se todas as informações foram digitadas!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_Mes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                
               
                    e.Handled = true;
                    MessageBox.Show("O campo MÊS só permite números!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                if (e.KeyChar == 13)
                {
                    if (Txt_Mes.Text != "")
                    {
                        Conta.mesNascimento = int.Parse(Txt_Mes.Text);

                        if (Conta.mesNascimento >=1 && Conta.mesNascimento<13)
                        {
                        Txt_Valor.Focus();
                        }
                        else
                    {
                        MessageBox.Show("Digite um mês válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
        }
    }

}
    
 