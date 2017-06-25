using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Telinha_Teste_Git_Soma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Btn_calcular_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            if (txt_nun1.Text == "" || txt_nun2.Text == "")
            {
                MessageBox.Show("Favor preencha todos os numeros");
            }
            else
            {
                
                resultado = Convert.ToInt16(txt_nun1.Text) + Convert.ToInt16(txt_nun2.Text);
                txt_resultado.Text = Convert.ToString(resultado);
            }

        }

        private void txt_nun1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)) || (Char.IsSymbol(e.KeyChar)))
                if (!(char.IsDigit(e.KeyChar)))  
                e.Handled = true;
        }

        private void txt_nun2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
                e.Handled = true;
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_nun2.Clear();
            txt_nun1.Clear();
            txt_resultado.Clear();
        }
            
    }
}
