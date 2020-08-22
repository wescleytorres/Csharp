namespace ContaBancaria
{
    partial class F_principal
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
            this.gb_conta = new System.Windows.Forms.GroupBox();
            this.btn_exibirExtrato = new System.Windows.Forms.Button();
            this.btn_sacar = new System.Windows.Forms.Button();
            this.btn_depositar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.tb_saldo = new System.Windows.Forms.TextBox();
            this.tb_conta = new System.Windows.Forms.TextBox();
            this.tb_titular = new System.Windows.Forms.TextBox();
            this.gb_conta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_conta
            // 
            this.gb_conta.Controls.Add(this.btn_exibirExtrato);
            this.gb_conta.Controls.Add(this.btn_sacar);
            this.gb_conta.Controls.Add(this.btn_depositar);
            this.gb_conta.Controls.Add(this.label4);
            this.gb_conta.Controls.Add(this.label3);
            this.gb_conta.Controls.Add(this.label2);
            this.gb_conta.Controls.Add(this.label1);
            this.gb_conta.Controls.Add(this.tb_valor);
            this.gb_conta.Controls.Add(this.tb_saldo);
            this.gb_conta.Controls.Add(this.tb_conta);
            this.gb_conta.Controls.Add(this.tb_titular);
            this.gb_conta.Location = new System.Drawing.Point(12, 8);
            this.gb_conta.Name = "gb_conta";
            this.gb_conta.Size = new System.Drawing.Size(315, 235);
            this.gb_conta.TabIndex = 0;
            this.gb_conta.TabStop = false;
            this.gb_conta.Text = "Conta";
            this.gb_conta.Enter += new System.EventHandler(this.gb_conta_Enter);
            // 
            // btn_exibirExtrato
            // 
            this.btn_exibirExtrato.Location = new System.Drawing.Point(106, 199);
            this.btn_exibirExtrato.Name = "btn_exibirExtrato";
            this.btn_exibirExtrato.Size = new System.Drawing.Size(103, 25);
            this.btn_exibirExtrato.TabIndex = 10;
            this.btn_exibirExtrato.Text = "Exibir Extrato";
            this.btn_exibirExtrato.UseVisualStyleBackColor = true;
            this.btn_exibirExtrato.Click += new System.EventHandler(this.btn_exibirExtrato_Click);
            // 
            // btn_sacar
            // 
            this.btn_sacar.Location = new System.Drawing.Point(179, 159);
            this.btn_sacar.Name = "btn_sacar";
            this.btn_sacar.Size = new System.Drawing.Size(103, 25);
            this.btn_sacar.TabIndex = 9;
            this.btn_sacar.Text = "Sacar";
            this.btn_sacar.UseVisualStyleBackColor = true;
            this.btn_sacar.Click += new System.EventHandler(this.btn_sacar_Click);
            // 
            // btn_depositar
            // 
            this.btn_depositar.Location = new System.Drawing.Point(29, 159);
            this.btn_depositar.Name = "btn_depositar";
            this.btn_depositar.Size = new System.Drawing.Size(103, 25);
            this.btn_depositar.TabIndex = 8;
            this.btn_depositar.Text = "Depositar";
            this.btn_depositar.UseVisualStyleBackColor = true;
            this.btn_depositar.Click += new System.EventHandler(this.btn_depositar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Conta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titular";
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(131, 103);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(153, 20);
            this.tb_valor.TabIndex = 3;
            // 
            // tb_saldo
            // 
            this.tb_saldo.Location = new System.Drawing.Point(131, 79);
            this.tb_saldo.Name = "tb_saldo";
            this.tb_saldo.ReadOnly = true;
            this.tb_saldo.Size = new System.Drawing.Size(153, 20);
            this.tb_saldo.TabIndex = 2;
            // 
            // tb_conta
            // 
            this.tb_conta.Location = new System.Drawing.Point(131, 55);
            this.tb_conta.Name = "tb_conta";
            this.tb_conta.ReadOnly = true;
            this.tb_conta.Size = new System.Drawing.Size(153, 20);
            this.tb_conta.TabIndex = 1;
            // 
            // tb_titular
            // 
            this.tb_titular.Location = new System.Drawing.Point(131, 30);
            this.tb_titular.Name = "tb_titular";
            this.tb_titular.ReadOnly = true;
            this.tb_titular.Size = new System.Drawing.Size(153, 20);
            this.tb_titular.TabIndex = 0;
            // 
            // F_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 265);
            this.Controls.Add(this.gb_conta);
            this.MaximizeBox = false;
            this.Name = "F_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Litoral";
            this.gb_conta.ResumeLayout(false);
            this.gb_conta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_conta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.TextBox tb_saldo;
        private System.Windows.Forms.TextBox tb_conta;
        private System.Windows.Forms.TextBox tb_titular;
        private System.Windows.Forms.Button btn_exibirExtrato;
        private System.Windows.Forms.Button btn_sacar;
        private System.Windows.Forms.Button btn_depositar;
    }
}

