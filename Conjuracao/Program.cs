using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

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
            Application.Run(new Conjuracao());
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
                    ladoDado.Image = Image.FromFile(caminho + "dado1.png");
                    ladoDado.Image = null;
                    break;
                case 2:
                    ladoDado.Image = Image.FromFile(caminho + "dado2.png");
                    break;
                case 3:
                    ladoDado.Image = Image.FromFile(caminho + "dado3.png");
                    break;
                case 4:
                    ladoDado.Image = Image.FromFile(caminho + "dado4.png");
                    break;
                case 5:
                    ladoDado.Image = Image.FromFile(caminho + "dado5.png");
                    break;
                case 6:
                    ladoDado.Image = Image.FromFile(caminho + "dado6.png");
                    break;
            }
        }

    }
}
