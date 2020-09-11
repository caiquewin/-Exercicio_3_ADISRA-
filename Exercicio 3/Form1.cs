using System;
using System.Globalization;
using System.Windows.Forms;

namespace Exercicio_3
{
    public partial class Form1 : Form
    {
        string[] Produtos = new string[10];
        string[] Codigo = new string[10];
        double[] Valor = new double[10];
        double soma = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarArray();
            soma = 0;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            listCaixa.Items.Clear();
            picImagem.Image = null;
            lblTitulo3.Text = " ";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {

            if (textCodigo.Text.Length == 3)


            {
                int indice = 0;
                for (int prod = 1; prod < Codigo.Length; prod++)

                {
                    if (textCodigo.Text == Codigo[prod])
                    {
                        indice = prod;

                    }
                }

                if (indice == 0)
                {
                    MessageBox.Show("Enrisa código ao lado :D");
                }

                /*Condição, se foi encontrado o produto ele retorna as informações de acordo com o índice 
                  caso não encontre aparecerá a mensagem, Produto não encontrado*/

                else
                {
                    listCaixa.Items.Add(textCodigo.Text + " " + Produtos[indice] + " R$ " + Valor[indice].ToString("f2",CultureInfo.InvariantCulture));


                    soma = soma + Valor[indice];
                    lblTitulo3.Text = ("R$: " + soma.ToString("f2",CultureInfo.InvariantCulture));
                    //local da imagem
                    picImagem.ImageLocation = "C:/Users/caique/source/repos/Exercicio 3/Exercicio 3/Imagens/" + Codigo[indice] + ".jpg";
                    textCodigo.Text = "";
                    textCodigo.Focus();
                }

            }

        }
        
        private void CarregarArray()
        {
            /*Criação do Método para ser chamado quando necessário, 
             isso evita repetir várias vezes o mesmo código*/

            Codigo[1] = "001";
            Codigo[2] = "002";
            Codigo[3] = "003";
            Codigo[4] = "004";
            Codigo[5] = "005";
            Codigo[6] = "006";

            Produtos[1] = "Hamburge De Carne";
            Produtos[2] = "Hamburge De Frango";
            Produtos[3] = "Batata Frita";
            Produtos[4] = "Refrigerante";
            Produtos[5] = "Salada";
            Produtos[6] = "Maionese";

            Valor[1] = 20.00;
            Valor[2] = 16.00;
            Valor[3] = 6.00;
            Valor[4] = 4.00;
            Valor[5] = 2.00;
            Valor[6] = 1.00;
        }

    }
}