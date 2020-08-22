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
    public partial class F_extrato : Form
    {
        private double txtdeb;
        private double txtcreb;
        private double txtsaldo;

        public F_extrato(string v, F_principal principal)
        {
            InitializeComponent();
            // passando informações do extrato, debito e credito
            tb_exibirExtrato.Text = v;

            // guardando valor na variaveis
            txtdeb = principal.totDeb;
            txtcreb = principal.totCred;
            txtsaldo = principal.totSaldo;

            // Mostrando na tela, convertendo para R$
            tb_debito.Text = "( + ) " + txtdeb.ToString("C");
            tb_credito.Text = "( - ) " + txtcreb.ToString("C");
            tb_saldo.Text = txtsaldo.ToString("C");

        }

        private void F_extrato_Load(object sender, EventArgs e)
        {             
          
        }
    }
}
