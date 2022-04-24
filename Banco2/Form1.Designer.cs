namespace Banco2
{
    partial class Form1
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.lbl_titular = new System.Windows.Forms.Label();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.btn_deposito = new System.Windows.Forms.Button();
            this.btn_saque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(333, 76);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 22);
            this.textoTitular.TabIndex = 0;
            this.textoTitular.TextChanged += new System.EventHandler(this.textoTitular_TextChanged);
            // 
            // lbl_titular
            // 
            this.lbl_titular.AutoSize = true;
            this.lbl_titular.Location = new System.Drawing.Point(119, 76);
            this.lbl_titular.Name = "lbl_titular";
            this.lbl_titular.Size = new System.Drawing.Size(50, 16);
            this.lbl_titular.TabIndex = 1;
            this.lbl_titular.Text = "Títular: ";
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(333, 194);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 22);
            this.textoNumero.TabIndex = 2;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(333, 365);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 22);
            this.textoSaldo.TabIndex = 3;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(119, 194);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(61, 16);
            this.lbl_numero.TabIndex = 4;
            this.lbl_numero.Text = "Número: ";
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(122, 371);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(47, 16);
            this.lbl_saldo.TabIndex = 5;
            this.lbl_saldo.Text = "saldo: ";
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(333, 130);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(100, 22);
            this.textoValor.TabIndex = 6;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(122, 130);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(45, 16);
            this.lbl_valor.TabIndex = 7;
            this.lbl_valor.Text = "Valor: ";
            // 
            // btn_deposito
            // 
            this.btn_deposito.Location = new System.Drawing.Point(159, 303);
            this.btn_deposito.Name = "btn_deposito";
            this.btn_deposito.Size = new System.Drawing.Size(92, 23);
            this.btn_deposito.TabIndex = 8;
            this.btn_deposito.Text = "Depósito";
            this.btn_deposito.UseVisualStyleBackColor = true;
            this.btn_deposito.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_saque
            // 
            this.btn_saque.Location = new System.Drawing.Point(349, 303);
            this.btn_saque.Name = "btn_saque";
            this.btn_saque.Size = new System.Drawing.Size(95, 23);
            this.btn_saque.TabIndex = 9;
            this.btn_saque.Text = "Saque";
            this.btn_saque.UseVisualStyleBackColor = true;
            this.btn_saque.Click += new System.EventHandler(this.btn_saque_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.btn_saque);
            this.Controls.Add(this.btn_deposito);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.lbl_saldo);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.lbl_titular);
            this.Controls.Add(this.textoTitular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Label lbl_titular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Button btn_deposito;
        private System.Windows.Forms.Button btn_saque;
    }
}

