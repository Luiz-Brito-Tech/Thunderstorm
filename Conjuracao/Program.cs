using System;
using System.Drawing;
using System.Windows.Forms;

namespace Conjuracao
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Thunderstorm());
        }

    }

    public class Dado
    {
        public int valor = 6;
        public PictureBox ladoDado;

        public Dado(PictureBox picbox) 
        {
            ladoDado = picbox;
        }

        public void MudaImagem(int valor)
        {
            string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "/Pics/";
            switch (valor)
            {
                case 1:
                    ladoDado.Image = Image.FromFile(caminho + "lado1.png");
                    ladoDado.Image = null;
                    break;
                case 2:
                    ladoDado.Image = Image.FromFile(caminho + "lado2.png");
                    break;
                case 3:
                    ladoDado.Image = Image.FromFile(caminho + "lado3.png");
                    break;
                case 4:
                    ladoDado.Image = Image.FromFile(caminho + "lado4.png");
                    break;
                case 5:
                    ladoDado.Image = Image.FromFile(caminho + "lado5.png");
                    break;
                case 6:
                    ladoDado.Image = Image.FromFile(caminho + "lado6.png");
                    break;
            }
        }

    }
}
