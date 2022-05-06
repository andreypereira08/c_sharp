namespace exercicio_1
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
            this.lbl_principal = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_mudanca = new System.Windows.Forms.Button();
            this.cbx_turma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_principal
            // 
            this.lbl_principal.AutoSize = true;
            this.lbl_principal.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_principal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_principal.Location = new System.Drawing.Point(92, 60);
            this.lbl_principal.Name = "lbl_principal";
            this.lbl_principal.Size = new System.Drawing.Size(88, 13);
            this.lbl_principal.TabIndex = 0;
            this.lbl_principal.Text = "Bem-vindo a LP2";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(35, 121);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(301, 20);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // btn_mudanca
            // 
            this.btn_mudanca.BackColor = System.Drawing.SystemColors.Control;
            this.btn_mudanca.Location = new System.Drawing.Point(56, 223);
            this.btn_mudanca.Name = "btn_mudanca";
            this.btn_mudanca.Size = new System.Drawing.Size(211, 23);
            this.btn_mudanca.TabIndex = 2;
            this.btn_mudanca.Text = "Clique Aqui para ficar vermelho";
            this.btn_mudanca.UseVisualStyleBackColor = false;
            this.btn_mudanca.Click += new System.EventHandler(this.btn_mudanca_Click);
            // 
            // cbx_turma
            // 
            this.cbx_turma.Enabled = false;
            this.cbx_turma.FormattingEnabled = true;
            this.cbx_turma.Items.AddRange(new object[] {
            "IN204",
            "IN202"});
            this.cbx_turma.Location = new System.Drawing.Point(613, 106);
            this.cbx_turma.Name = "cbx_turma";
            this.cbx_turma.Size = new System.Drawing.Size(121, 21);
            this.cbx_turma.TabIndex = 3;
            this.cbx_turma.SelectedIndexChanged += new System.EventHandler(this.cbx_turma_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha a turma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_turma);
            this.Controls.Add(this.btn_mudanca);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_principal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_principal;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_mudanca;
        private System.Windows.Forms.ComboBox cbx_turma;
        private System.Windows.Forms.Label label1;
    }
}

