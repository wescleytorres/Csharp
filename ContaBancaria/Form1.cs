using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria
{
    public partial class F_principal : Form
    {
        public Conta conta;
        public string boleta;

        public double totDeb;
        public double totCred;
        public double totSaldo;

        public F_principal()
        {
            InitializeComponent();

            totDeb = 0;
            totCred = 0;
            totSaldo = 0;
        }

        // ao iniciar , dentro do gb_conta ja deve chamar titular/conta/saldo.
        private void gb_conta_Enter(object sender, EventArgs e)
        {
            // chamando o objeto pai.
            this.conta = new Conta();

            // chamando metodo Titular e passando para tb_titular.
            conta.Titular = "Wescley Torres";
            tb_titular.Text = conta.Titular;

            // chamando metodo Numero e passando para tb_conta.
            conta.Numero = 2503;
            tb_conta.Text = conta.Numero.ToString();

            // essa forma de converter vai aparecer o 0 de inicio.
            tb_saldo.Text = Convert.ToString(conta.Saldo.ToString("C"));


            tb_valor.Focus();
        }

        private void btn_exibirExtrato_Click(object sender, EventArgs e)
        {           
            F_extrato f_Extrato = new F_extrato(boleta, this);
            f_Extrato.Show();
        }

        private void btn_depositar_Click(object sender, EventArgs e)
        {           
            if (tb_valor.Text != "")
            {

                // converter o texto para double
                conta.Depositar(Math.Round(Convert.ToDouble(tb_valor.Text), 2));

                // essa gambiarra é para as duas casas decimais
                tb_saldo.Text = Convert.ToString((this.conta.Saldo).ToString("C"));

                boleta = this.conta.Extrato;

                totDeb += Math.Round(Convert.ToDouble(tb_valor.Text), 2);
                totSaldo = this.conta.Saldo;


                tb_valor.Text = "";
                tb_valor.Focus();
            }
            else
            {
                MessageBox.Show("Insira um valor");
                tb_valor.Focus();
            }
        }

        private void btn_sacar_Click(object sender, EventArgs e)
        {
            if (tb_valor.Text != "")
            {
                double valorCredito = Convert.ToDouble(tb_valor.Text);
                double total = (Math.Round(this.conta.Saldo - valorCredito, 2));

                if (total >= 0)
                {
                    // converter o texto para double
                    conta.Creditar(Convert.ToDouble(tb_valor.Text));

                    // essa gambiarra é para as duas casas decimais
                    tb_saldo.Text = Convert.ToString((this.conta.Saldo).ToString("C"));

                    boleta = this.conta.Extrato;
                    totCred += Math.Round(Convert.ToDouble(tb_valor.Text), 2);
                    totSaldo = this.conta.Saldo;

                    tb_valor.Text = "";
                    tb_valor.Focus();
                }
                else
                {
                    MessageBox.Show("Saldo Insuficiente");
                    tb_valor.Focus();
                }
            }
            else
            {
                MessageBox.Show("Insira um valor");
                tb_valor.Focus();
            }

        }
    }

}
