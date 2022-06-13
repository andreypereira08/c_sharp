namespace _16demaio
{
    partial class exercicio2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.resultado_imc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXERCICIO 2";
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(60, 152);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(53, 13);
            this.lbl_altura.TabIndex = 1;
            this.lbl_altura.Text = "ALTURA:";
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(63, 199);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(42, 13);
            this.lbl_peso.TabIndex = 2;
            this.lbl_peso.Text = "PESO: ";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(112, 257);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(108, 23);
            this.btn_calcular.TabIndex = 3;
            this.btn_calcular.Text = "CALCULAR IMC";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(174, 152);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(100, 20);
            this.txt_altura.TabIndex = 4;
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(174, 199);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(100, 20);
            this.txt_peso.TabIndex = 5;
            // 
            // resultado_imc
            // 
            this.resultado_imc.AutoSize = true;
            this.resultado_imc.Location = new System.Drawing.Point(157, 352);
            this.resultado_imc.Name = "resultado_imc";
            this.resultado_imc.Size = new System.Drawing.Size(25, 13);
            this.resultado_imc.TabIndex = 6;
            this.resultado_imc.Text = "???";
            // 
            // exercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultado_imc);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.label1);
            this.Name = "exercicio2";
            this.Text = "exercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label resultado_imc;
    }
}