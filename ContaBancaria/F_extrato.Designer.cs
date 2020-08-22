namespace ContaBancaria
{
    partial class F_extrato
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
            this.tb_exibirExtrato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_debito = new System.Windows.Forms.TextBox();
            this.tb_credito = new System.Windows.Forms.TextBox();
            this.tb_saldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_exibirExtrato
            // 
            this.tb_exibirExtrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_exibirExtrato.Location = new System.Drawing.Point(8, 17);
            this.tb_exibirExtrato.Multiline = true;
            this.tb_exibirExtrato.Name = "tb_exibirExtrato";
            this.tb_exibirExtrato.ReadOnly = true;
            this.tb_exibirExtrato.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_exibirExtrato.Size = new System.Drawing.Size(326, 247);
            this.tb_exibirExtrato.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Debito";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Credito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Saldo";
            // 
            // tb_debito
            // 
            this.tb_debito.Location = new System.Drawing.Point(229, 270);
            this.tb_debito.Name = "tb_debito";
            this.tb_debito.ReadOnly = true;
            this.tb_debito.Size = new System.Drawing.Size(104, 20);
            this.tb_debito.TabIndex = 6;
            // 
            // tb_credito
            // 
            this.tb_credito.Location = new System.Drawing.Point(229, 296);
            this.tb_credito.Name = "tb_credito";
            this.tb_credito.ReadOnly = true;
            this.tb_credito.Size = new System.Drawing.Size(104, 20);
            this.tb_credito.TabIndex = 7;
            // 
            // tb_saldo
            // 
            this.tb_saldo.Location = new System.Drawing.Point(229, 322);
            this.tb_saldo.Name = "tb_saldo";
            this.tb_saldo.ReadOnly = true;
            this.tb_saldo.Size = new System.Drawing.Size(104, 20);
            this.tb_saldo.TabIndex = 8;
            // 
            // F_extrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 353);
            this.Controls.Add(this.tb_saldo);
            this.Controls.Add(this.tb_credito);
            this.Controls.Add(this.tb_debito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_exibirExtrato);
            this.MaximizeBox = false;
            this.Name = "F_extrato";
            this.Text = "F_extrato";
            this.Load += new System.EventHandler(this.F_extrato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_exibirExtrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_debito;
        private System.Windows.Forms.TextBox tb_credito;
        private System.Windows.Forms.TextBox tb_saldo;
    }
}