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
        private int soma(int x, int y)// rotina que calcula soma de nos numeros 
        {
            int resultado = x + y;// variavel que soma 
            return resultado;                     
        }
        private void Btn_calcular_Click(object sender, EventArgs e)
        {

            if (txt_nun1.Text == "" && txt_nun2.Text == "")
            {
                string mensagem = "<ERRO>";
                string titulo = "Favor preencha todos os campos da Calculadora";
                txt_resultado.Clear(); // limpa o textbox resultado 
                MessageBox.Show(titulo,mensagem);
                
            }
            else
            {

                if (txt_nun1.Text == "")//valida campo vazio
                {
                    string mensagem = "<ERRO>";
                    string titulo = "Favor preencha o campo do número 1";
                    txt_resultado.Clear(); // limpa o textbox resultado 
                    txt_nun1.Clear(); // limpa o textbox numero 1 
                    MessageBox.Show(titulo,mensagem);

                }
                else
                {
                    if (txt_nun2.Text == "")
                    {
                        string mensagem = "<ERRO>";
                        string titulo = "Favor preencha o campo do número 2";
                        txt_resultado.Clear();// limpa o textbox resultado
                        txt_nun2.Clear();// limpa o textbox numero 2
                        MessageBox.Show(titulo,mensagem);
                    }

                    else
                    {
                        // chamando o botão calcular 
                        // passando a rotina soma para o botão e os parametros para receber os valores 
                        int resultado = soma(Convert.ToInt16(txt_nun1.Text), Convert.ToInt16(txt_nun2.Text));
                        txt_resultado.Text = resultado.ToString();

                        //exemplo. sem usar rotina 
                        /*resultado = Convert.ToInt32(txt_nun1.Text) + Convert.ToInt32(txt_nun2.Text);
                        txt_resultado.Text = Convert.ToString(resultado);*/
                    }
                }
            }
        }

        private void txt_nun1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // valida somente letra espaço e simbolos não usei 
            //if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)) || (Char.IsSymbol(e.KeyChar)))
                
            if (!(char.IsDigit(e.KeyChar)))  // usando esta que so pode digitar numeros
                e.Handled = true;
        }
        private void txt_nun2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar))) //  so pode digitar numeros
                e.Handled = true;
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            // limpa todos os textbox do form
            txt_nun2.Clear();
            txt_nun1.Clear();
            txt_resultado.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
            
    }
}
