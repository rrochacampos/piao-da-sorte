using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace JogoPiao
{
    public partial class FormJogo : Form
    {
        int valorDoTick = 0, tentativas = 0, numeroSorteado = 0;

        public FormJogo()
        {
            InitializeComponent();
        }

        public void iniciar()
        {
            picGif.Visible = true;
            picInicial.Visible = true;
            lblVisor.Text = "Clique no pião para começar";
            valorDoTick = 0;
            tentativas = 0;
            lblNumeroSorteado.Text = "?";
            lblNumerosJogados.Text = "Números jogados: ";
            lblTentativas.Text = "Tentativas: ";
            btnOpcao.Text = "Desistir";
        }

        public void tocarSom(int opcao)
        {
            SoundPlayer tema = new SoundPlayer(Properties.Resources.tema);
            SoundPlayer errou = new SoundPlayer(Properties.Resources.errou);
            SoundPlayer acertou = new SoundPlayer(Properties.Resources.acertou);

            switch (opcao)
            {
                case 1: tema.Play(); break;
                case 2: errou.Play(); break;
                case 3: acertou.Play(); break;
            }
        }

        private void informarNumero(object sender, EventArgs e)
        {
            if (txtNumeros.TextLength < 2 && picGif.Visible == false && btnOpcao.Text != "Jogar novamente")
            {
                txtNumeros.Text += (sender as Button).Text;
            }
        }

        public void digitarPalpite()
        {
            lblVisor.Text = "Digite um número ímpar, entre 1 e 100";
            picGif.Visible = false;
        }

        public int sortearNumero()
        {
            int numero;
            do
            {
                Random aleatorio = new Random();
                numero = aleatorio.Next(1, 100);
            } while (numero % 2 == 0);
            return (numero);
        }

        public void atualizarTentativas(int numeroDigitado)
        {
            string numDigitado = numeroDigitado.ToString();
            numDigitado = numDigitado.PadLeft(2, '0');
            tentativas++;
            lblTentativas.Text = "Tentativas: " + tentativas.ToString();
            lblNumerosJogados.Text += (" " + numDigitado);
        }

        public void comemorar(int numero)
        {
            lblVisor.Text = "Parabéns! Você acertou o número da sorte!";
            lblNumeroSorteado.Text = numero.ToString();
            btnOpcao.Text = "Jogar novamente";
        }

        public void compararNumeros(int numeroDigitado)
        {
            string numDigitado = numeroDigitado.ToString();

            if (numDigitado.Length == 1)
            {
                numDigitado = numDigitado.PadLeft(2, '0');
            }

            if (numeroDigitado == 0 || numeroDigitado % 2 == 0)
            {
                lblVisor.Text = "O número digitado precisa ser ímpar!";
            }
            else if (lblNumerosJogados.Text.Contains(numDigitado))
            {
                lblVisor.Text = "O número " + numDigitado + " já foi jogado!";
            }
            else
            {
                atualizarTentativas(numeroDigitado);
                if (numeroDigitado == numeroSorteado)
                {
                    comemorar(numeroDigitado);
                    tocarSom(3);
                }
                else
                {
                    tocarSom(2);
                    if (numeroDigitado > numeroSorteado)
                    {
                        lblVisor.Text = "O número digitado é maior que o sorteado!";
                    }
                    else if (numeroDigitado < numeroSorteado)
                    {
                        lblVisor.Text = "O número digitado é menor que o sorteado!";
                    }
                }
            }
        }

        private void picInicial_Click(object sender, EventArgs e)
        {
            numeroSorteado = sortearNumero();
            picInicial.Visible = false;
            tocarSom(1);
            tmr1.Enabled = true;
        }

        private void btnENTER_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text != "")
            {
                int numeroDigitado = int.Parse(txtNumeros.Text);
                compararNumeros(numeroDigitado);
                txtNumeros.Text = "";
            }
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text.Length > 0 && picGif.Visible == false)
            {
                txtNumeros.Text = txtNumeros.Text.Substring(0, txtNumeros.Text.Length - 1);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpcao_Click(object sender, EventArgs e)
        {
            if (btnOpcao.Text == "Desistir")
            {
                lblNumeroSorteado.Text = numeroSorteado.ToString();
                btnOpcao.Text = "Jogar novamente";
                lblVisor.Text = "Não foi dessa vez  :(";
            }
            else if (btnOpcao.Text == "Jogar novamente")
            {
                iniciar();
            }
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            if (valorDoTick < 19)
            {
                valorDoTick += 1;
            }
            else
            {
                tmr1.Enabled = false;
                digitarPalpite();
            }
        }

        private void tipSair_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }
    }
}
