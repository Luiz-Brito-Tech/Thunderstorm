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
        ProgressBar[] barras = new ProgressBar[4];
        int posicao = 0;

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
        }

        // Inputs

        private void Button_Click(object sender, EventArgs e)
        {
            switch (Button.Text)
            {
                case "COMEÇAR":
                    CriaLista(dados);
                    Button.Text = "ROLAR";
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
                            Button.Text = "REPOR";
                        }
                        else
                        {
                            Button.Enabled = false;
                        }
                    }

                    if(barras[posicao].Value == 6)
                    {
                        Button.Enabled = false;
                    }

                    posicao++;

                    if(posicao == barras.Length)
                    {
                        posicao = 0;
                    }

                    break;

                case "REPOR":
                    CriaLista(dados);
                    Button.Text = "ROLAR";
                    break;
            }
        }

        // Outras funções/métodos

        private void CriaLista (Dado[] array)
        {
            foreach (Dado dado in array)
            {
                dado.ladoDado.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "/Pics/lado6.png");
                dadosLista.Add(dado);
            }
        }
    }
}
