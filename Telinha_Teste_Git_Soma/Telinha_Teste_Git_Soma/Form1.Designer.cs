namespace Telinha_Teste_Git_Soma
{
    partial class Form1
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
            this.lb_nun1 = new System.Windows.Forms.Label();
            this.lb_nun2 = new System.Windows.Forms.Label();
            this.txt_nun1 = new System.Windows.Forms.TextBox();
            this.txt_nun2 = new System.Windows.Forms.TextBox();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.lb_operador = new System.Windows.Forms.Label();
            this.lb_igual = new System.Windows.Forms.Label();
            this.Btn_calcular = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_nun1
            // 
            this.lb_nun1.AutoSize = true;
            this.lb_nun1.Location = new System.Drawing.Point(23, 30);
            this.lb_nun1.Name = "lb_nun1";
            this.lb_nun1.Size = new System.Drawing.Size(53, 13);
            this.lb_nun1.TabIndex = 0;
            this.lb_nun1.Text = "Número 1";
            // 
            // lb_nun2
            // 
            this.lb_nun2.AutoSize = true;
            this.lb_nun2.Location = new System.Drawing.Point(23, 90);
            this.lb_nun2.Name = "lb_nun2";
            this.lb_nun2.Size = new System.Drawing.Size(53, 13);
            this.lb_nun2.TabIndex = 1;
            this.lb_nun2.Text = "Número 2";
            // 
            // txt_nun1
            // 
            this.txt_nun1.Location = new System.Drawing.Point(114, 23);
            this.txt_nun1.MaxLength = 4;
            this.txt_nun1.Name = "txt_nun1";
            this.txt_nun1.Size = new System.Drawing.Size(100, 20);
            this.txt_nun1.TabIndex = 2;
            this.txt_nun1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nun1_KeyPress);
            // 
            // txt_nun2
            // 
            this.txt_nun2.Location = new System.Drawing.Point(114, 83);
            this.txt_nun2.MaxLength = 4;
            this.txt_nun2.Name = "txt_nun2";
            this.txt_nun2.Size = new System.Drawing.Size(100, 20);
            this.txt_nun2.TabIndex = 3;
            this.txt_nun2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nun2_KeyPress);
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(23, 149);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(55, 13);
            this.lb_resultado.TabIndex = 4;
            this.lb_resultado.Text = "Resultado";
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(114, 142);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(100, 20);
            this.txt_resultado.TabIndex = 5;
            // 
            // lb_operador
            // 
            this.lb_operador.AutoSize = true;
            this.lb_operador.Location = new System.Drawing.Point(156, 56);
            this.lb_operador.Name = "lb_operador";
            this.lb_operador.Size = new System.Drawing.Size(13, 13);
            this.lb_operador.TabIndex = 6;
            this.lb_operador.Text = "+";
            // 
            // lb_igual
            // 
            this.lb_igual.AutoSize = true;
            this.lb_igual.Location = new System.Drawing.Point(156, 115);
            this.lb_igual.Name = "lb_igual";
            this.lb_igual.Size = new System.Drawing.Size(13, 13);
            this.lb_igual.TabIndex = 7;
            this.lb_igual.Text = "=";
            // 
            // Btn_calcular
            // 
            this.Btn_calcular.Location = new System.Drawing.Point(139, 210);
            this.Btn_calcular.Name = "Btn_calcular";
            this.Btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.Btn_calcular.TabIndex = 8;
            this.Btn_calcular.Text = "Calcular";
            this.Btn_calcular.UseVisualStyleBackColor = true;
            this.Btn_calcular.Click += new System.EventHandler(this.Btn_calcular_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Location = new System.Drawing.Point(43, 210);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Limpar.TabIndex = 9;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 260);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.lb_igual);
            this.Controls.Add(this.lb_operador);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.txt_nun2);
            this.Controls.Add(this.txt_nun1);
            this.Controls.Add(this.lb_nun2);
            this.Controls.Add(this.lb_nun1);
            this.Controls.Add(this.Btn_calcular);
            this.Name = "Form1";
            this.Text = "Calculadora Soma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nun1;
        private System.Windows.Forms.Label lb_nun2;
        private System.Windows.Forms.TextBox txt_nun1;
        private System.Windows.Forms.TextBox txt_nun2;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label lb_operador;
        private System.Windows.Forms.Label lb_igual;
        private System.Windows.Forms.Button Btn_calcular;
        private System.Windows.Forms.Button Btn_Limpar;
    }
}

