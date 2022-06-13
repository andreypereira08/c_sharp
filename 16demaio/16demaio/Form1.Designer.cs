namespace _16demaio
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
            this.btn_ex1 = new System.Windows.Forms.Button();
            this.btn_ex2 = new System.Windows.Forms.Button();
            this.btn_ex3 = new System.Windows.Forms.Button();
            this.btn_ex4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ex1
            // 
            this.btn_ex1.Location = new System.Drawing.Point(81, 114);
            this.btn_ex1.Name = "btn_ex1";
            this.btn_ex1.Size = new System.Drawing.Size(75, 23);
            this.btn_ex1.TabIndex = 0;
            this.btn_ex1.Text = "Exercicio 1";
            this.btn_ex1.UseVisualStyleBackColor = true;
            this.btn_ex1.Click += new System.EventHandler(this.btn_ex1_Click);
            // 
            // btn_ex2
            // 
            this.btn_ex2.Location = new System.Drawing.Point(211, 114);
            this.btn_ex2.Name = "btn_ex2";
            this.btn_ex2.Size = new System.Drawing.Size(75, 23);
            this.btn_ex2.TabIndex = 1;
            this.btn_ex2.Text = "Exercicio 2";
            this.btn_ex2.UseVisualStyleBackColor = true;
            this.btn_ex2.Click += new System.EventHandler(this.btn_ex2_Click);
            // 
            // btn_ex3
            // 
            this.btn_ex3.Location = new System.Drawing.Point(81, 163);
            this.btn_ex3.Name = "btn_ex3";
            this.btn_ex3.Size = new System.Drawing.Size(75, 23);
            this.btn_ex3.TabIndex = 2;
            this.btn_ex3.Text = "Exercicio 3";
            this.btn_ex3.UseVisualStyleBackColor = true;
            this.btn_ex3.Click += new System.EventHandler(this.btn_ex3_Click);
            // 
            // btn_ex4
            // 
            this.btn_ex4.Location = new System.Drawing.Point(211, 163);
            this.btn_ex4.Name = "btn_ex4";
            this.btn_ex4.Size = new System.Drawing.Size(75, 23);
            this.btn_ex4.TabIndex = 3;
            this.btn_ex4.Text = "Exercicio 4";
            this.btn_ex4.UseVisualStyleBackColor = true;
            this.btn_ex4.Click += new System.EventHandler(this.btn_ex4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 301);
            this.Controls.Add(this.btn_ex4);
            this.Controls.Add(this.btn_ex3);
            this.Controls.Add(this.btn_ex2);
            this.Controls.Add(this.btn_ex1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ex1;
        private System.Windows.Forms.Button btn_ex2;
        private System.Windows.Forms.Button btn_ex3;
        private System.Windows.Forms.Button btn_ex4;
    }
}

