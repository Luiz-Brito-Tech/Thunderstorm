using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Conjuracao
{
    public partial class Thunderstorm : Form
    {

        Random rand = new Random();

        List<Dado> dadosLista = new List<Dado>();
        Dado[] dados = new Dado[6];
        ProgressBar[] barras = new ProgressBar[8];
        Button[] numerosDosJogadores = new Button[8];
        int posicao = 0;
        int barrasAtivadas = 0;
        int numerosExibidos = 0;

        bool TirouAoMenosUm1 = false;

        public Thunderstorm() // Construtor
        {
            InitializeComponent();
            // Inicialização do array
            dados[0] = new Dado(dado1picbox);
            dados[1] = new Dado(dado2picbox);
            dados[2] = new Dado(dado3picbox);
            dados[3] = new Dado(dado4picbox);
            dados[4] = new Dado(dado5picbox);
            dados[5] = new Dado(dado6picbox);
            barras[0] = progressBar1;
            barras[1] = progressBar2;
            barras[2] = progressBar3;
            barras[3] = progressBar4;
            barras[4] = progressBar5;
            barras[5] = progressBar6;
            barras[6] = progressBar7;
            barras[7] = progressBar8;
            numerosDosJogadores[0] = numeroDoJogador1;
            numerosDosJogadores[1] = numeroDoJogador2;
            numerosDosJogadores[2] = numeroDoJogador3;
            numerosDosJogadores[3] = numeroDoJogador4;
            numerosDosJogadores[4] = numeroDoJogador5;
            numerosDosJogadores[5] = numeroDoJogador6;
            numerosDosJogadores[6] = numeroDoJogador7;
            numerosDosJogadores[7] = numeroDoJogador8;
        }

        // Inputs

        private void buttonDados_Click(object sender, EventArgs e)
        {
            switch (buttonDados.Text)
            {
                case "COMEÇAR":
                    Cria_dadosLista(dados);
                    buttonDados.Text = "ROLAR";
                    break;

                case "ROLAR":

                    foreach (Dado dado in dadosLista)
                    {
                        dado.valor = rand.Next(1, 7);
                        dado.MudaImagem(dado.valor);
                        if (dado.valor == 1)
                        {
                            TirouAoMenosUm1 = true;
                        }
                    }

                    if (TirouAoMenosUm1 == true)
                    {
                        TirouAoMenosUm1 = false;
                        if (barras[posicao].Value < 6)
                        {
                            barras[posicao].Value++;
                            buttonDados.Text = "REMOVER DADOS QUE TIRARAM 1";
                        }
                    }

                    if(barras[posicao].Value == 6)
                    {
                        TirouAoMenosUm1 = false;
                        buttonDados.Enabled = false;
                    }

                    posicao++;

                    if(posicao == barrasAtivadas)
                    {
                        posicao = 0;
                    }

                    break;

                case "REMOVER DADOS QUE TIRARAM 1":

                    foreach (Dado dado in dadosLista)
                    {
                        if (dado.valor == 1)
                        {
                            dado.ladoDado.Image = null;
                        }
                    }

                    dadosLista.RemoveAll(dado => dado.valor == 1);

                    if (dadosLista.ToArray().Length == 0)
                    {
                        buttonDados.Text = "REPOR";
                    }
                    else 
                    {
                        buttonDados.Text = "ROLAR";
                    }

                    break;

                case "REPOR":
                    Cria_dadosLista(dados);
                    buttonDados.Text = "ROLAR";
                    break;
            }
        }

        private void buttonJogar_Click(object sender, EventArgs e)
        {
            groupBoxMenu.Enabled = false;
            groupBoxMenu.Hide();
            groupBoxPartida.Enabled = true;
            groupBoxPartida.Show();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            barras[barrasAtivadas].Show();
            numerosDosJogadores[numerosExibidos].Show();
            numerosExibidos++;
            barrasAtivadas++;
            if(barrasAtivadas == 4)
            {
                buttonJogar.Enabled = true;
            }
            if (barrasAtivadas == 8)
            {
                buttonAdicionar.Enabled = false;
            }
        }       
        
        private void textBoxEntraJogador_TextChanged(object sender, EventArgs e)
        {
            buttonAdicionar.Enabled = true;
        }

        private void button_Reiniciar(object sender, EventArgs e)
        {
            posicao = 0;

            for (int indice = 0; indice < barrasAtivadas; indice++)
            {
                barras[indice].Value = 0;
            }

            Cria_dadosLista(dados);
            buttonDados.Enabled = true;
            buttonDados.Text = "COMEÇAR";
        }

        // Outras funções/métodos

        private void Cria_dadosLista (Dado[] array)
        {
            foreach (Dado dado in array)
            {
                dado.ladoDado.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "/Pics/lado6.png");
            }

            dadosLista = dados.ToList();

        }

        private void CriaJogadores()
        {

        }

    }
}
