using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Conjuracao
{
    public partial class Thunderstorm : Form
    {

        Random rand = new Random();

        List<Dado> dadosLista = new List<Dado>();
        Dado[] dados = new Dado[6];
        ProgressBar[] barras = new ProgressBar[8];
        int posicao = 0;
        int barrasAtivadas = 0;

        bool JogoRolando = false; // False - O jogo/partida não está em andamento / True - O jogo/partida está em andamento
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
        }

        // Inputs

        private void buttonDados_Click(object sender, EventArgs e)
        {
            switch (buttonDados.Text)
            {
                case "COMEÇAR":
                    Cria_dadosLista(dados);
                    buttonDados.Text = "ROLAR";
                    JogoRolando = true;
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
                    dadosLista.RemoveAll(dado => dado.valor == 1);

                    if (TirouAoMenosUm1 == true && barras[posicao].Value < 6)
                    {
                        barras[posicao].Value++;
                        TirouAoMenosUm1 = false;
                    }

                    if (dadosLista.ToArray().Length == 0)
                    {
                        if (JogoRolando is true)
                        {
                            buttonDados.Text = "REPOR";
                        }
                        else
                        {
                            buttonDados.Enabled = false;
                        }
                    }

                    if(barras[posicao].Value == 6)
                    {
                        buttonDados.Enabled = false;
                    }

                    posicao++;

                    if(posicao == barrasAtivadas)
                    {
                        posicao = 0;
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
            barras[barrasAtivadas].Enabled = true;
            barras[barrasAtivadas].Show();
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

        // Outras funções/métodos

        private void Cria_dadosLista (Dado[] array)
        {
            foreach (Dado dado in array)
            {
                dado.ladoDado.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "/Pics/lado6.png");
                dadosLista.Add(dado);
            }
        }

        private void CriaJogadores()
        {
            
        }
    }
}
