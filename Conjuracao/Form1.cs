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
        PictureBox[] espacosSetas = new PictureBox[8];

        int posicao = 0;
        int barrasAtivadas = 0;
        int numerosExibidos = 0;
        int barrasVazias = 0;

        bool TirouAoMenosUm1 = false;

        string caminhoSeta = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "/Pics/arrow.png";

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
            espacosSetas[0] = espacoSeta1;
            espacosSetas[1] = espacoSeta2;
            espacosSetas[2] = espacoSeta3;
            espacosSetas[3] = espacoSeta4;
            espacosSetas[4] = espacoSeta5;
            espacosSetas[5] = espacoSeta6;
            espacosSetas[6] = espacoSeta7;
            espacosSetas[7] = espacoSeta8;
        }

        // Inputs

        private void buttonDados_Click(object sender, EventArgs e)
        {
            if (barras[posicao].Value > 0) 
            {
                switch (buttonDados.Text)
                {
                    case "COMEÇAR":
                        Cria_dadosLista(dados);
                        espacosSetas[posicao].Image = Image.FromFile(caminhoSeta);
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
                            if (barras[posicao].Value > 0)
                            {
                                buttonDados.Text = "REMOVER";
                            }
                        }
                        else
                        {
                            if (barras[posicao].Value > 0)
                            {
                                barras[posicao].Value--;
                            }
                        }

                        if (barras[posicao].Value == 0)
                        {
                            TirouAoMenosUm1 = false;
                            numerosDosJogadores[posicao].Text = "X";
                            barrasVazias++;
                            if (barrasVazias == barrasAtivadas - 1)
                            {
                                buttonDados.Enabled = false;
                            }
                        }

                        espacosSetas[posicao].Image = null;

                        if (buttonDados.Text == "ROLAR")
                        {
                            posicao++;
                            if (posicao == barrasAtivadas)
                            {
                                posicao = 0;
                            }
                        }

                        espacosSetas[posicao].Image = Image.FromFile(caminhoSeta);
                        break;

                    case "REMOVER":
                        espacosSetas[posicao].Image = null;

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
                            posicao++;
                            if (posicao == barrasAtivadas)
                            {
                                posicao = 0;
                            }
                        }

                        espacosSetas[posicao].Image = Image.FromFile(caminhoSeta);
                        break;

                    case "REPOR":
                        espacosSetas[posicao].Image = null;
                        Cria_dadosLista(dados);
                        buttonDados.Text = "ROLAR";
                        posicao++;
                        if (posicao == barrasAtivadas)
                        {
                            posicao = 0;
                        }
                        espacosSetas[posicao].Image = Image.FromFile(caminhoSeta);
                        break;
                }
            }
            else
            {
                espacosSetas[posicao].Image = null;
                while (barras[posicao].Value == 0 && barrasVazias < barrasAtivadas - 1)
                {
                    posicao++;
                    {
                        if (posicao == barrasAtivadas)
                        {
                            posicao = 0;
                        }
                    }
                }
                espacosSetas[posicao].Image = Image.FromFile(caminhoSeta);
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
            labelUnica.Text = $"Número de Jogadores: {barrasAtivadas}/8";
            if(barrasAtivadas == 4)
            {
                buttonJogar.Enabled = true;
                labelUnica.ForeColor = System.Drawing.Color.LightGreen;
            }
            if (barrasAtivadas == 8)
            {
                buttonAdicionar.Enabled = false;
            }
        }       

        private void button_Reiniciar(object sender, EventArgs e)
        {
            espacosSetas[posicao].Image = null;
            posicao = 0;
            barrasVazias = 0;

            for (int indice = 0; indice < barrasAtivadas; indice++)
            {
                barras[indice].Value = 6;
            }

            for (int numero = 1; numero <= numerosDosJogadores.Length; numero++)
            {
                numerosDosJogadores[numero - 1].Text = $"{numero}";
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
    }
}
