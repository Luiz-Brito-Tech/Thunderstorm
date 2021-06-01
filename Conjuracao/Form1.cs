using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conjuracao
{
    public partial class Conjuracao : Form
    {

        Random rand = new Random();

        List<Dado> dadosLista = new List<Dado>();
        Dado[] dados = new Dado[6];

        bool JogoRolando = false; // False - O jogo/partida não está em andamento / True - O jogo/partida está em andamento

        public Conjuracao() // Construtor
        {
            InitializeComponent();
            // Inicialização do array
            dados[0] = new Dado(dado1picbox);
            dados[1] = new Dado(dado2picbox);
            dados[2] = new Dado(dado3picbox);
            dados[3] = new Dado(dado4picbox);
            dados[4] = new Dado(dado5picbox);
            dados[5] = new Dado(dado6picbox);
        }

        // Inputs

        private void comecaButton_Click(object sender, EventArgs e)
        {
            CriaLista(dados);
            comecarButton.Enabled = false;
            rolarButton.Enabled = true;
            JogoRolando = true;

        }

        private void rolarButton_Click(object sender, EventArgs e)
        {
            foreach (Dado dado in dadosLista)
            {
                dado.valor = rand.Next(1, 7);
                dado.MudaImagem(dado.valor);
            }
            dadosLista.RemoveAll(dado => dado.valor == 1);
            if (dadosLista.ToArray().Length == 0) 
            {
                rolarButton.Enabled = false;
                if (JogoRolando is true) 
                {
                    reporButton.Enabled = true;
                }
            }
        }

        private void reporButton_Click(object sender, EventArgs e)
        {
            CriaLista(dados);
            rolarButton.Enabled = true;
            reporButton.Enabled = false;
        }

        //Outras funções/métodos

        private void CriaLista (Dado[] array)
        {
            foreach (Dado dado in array)
            {
                dado.ladoDado.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "/Pics/dado6.png");
                dadosLista.Add(dado);
            }
        }
    }

}
