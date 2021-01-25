using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{


    public partial class Form1 : Form
    {

        Operaciones ejemplo1;
        public Form1()
        {
            InitializeComponent();
            ejemplo1 = new Operaciones();          
            ejemplo1.Reiniciar();
            textBox1.Text = ejemplo1.getHiddenWord();
            label1.Text = String.Concat("El número de pistas restantes es: ", ejemplo1.getPistas());
            label2.Text = String.Concat("El número de intentos fallidos es: ", ejemplo1.getIntentos());
        }

        private void bt_click(object sender, EventArgs e) //Cuando se pulsa la letra de un boton, obtiene la misma en formato 
        {
            Button button = (Button)sender;
            char letra = Convert.ToChar(button.Text);        

            ejemplo1.AñadirLetra(letra);
            textBox1.Text = ejemplo1.getHiddenWord();
            textBox1.Refresh();

            label2.Text = String.Concat("El número de intentos restantes es: ", ejemplo1.getIntentos());

            if (ejemplo1.CheckIfwin())
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "/ah_ganador.png");
                MessageBox.Show("Has ganado felicidades");
            }

            switch (ejemplo1.getIntentos())
            {
                case 5:
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + "/ah 0.png");
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + "/ah 1.png");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + "/ah 2.png");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + "/ah 3.png");
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + "/ah 4.png");
                    break;
                case 0:
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + "/ah 5.png");
                    break;
                default:
                    break;
            }

            if (!ejemplo1.getSeguirJugando() && !ejemplo1.CheckIfwin())
            {
                MessageBox.Show("Has perdido, felicidades truán");

            }

        }

        private void Resolver_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = ejemplo1.Resolver();
            textBox1.Refresh();
        }

        private void PedirPista_Click(object sender, EventArgs e)
        {
            if(ejemplo1.getQuedanPistas())
            {
                ejemplo1.UsarPista();
                textBox1.Text = ejemplo1.getHiddenWord();
                textBox1.Refresh();
            }
            else
            {
                MessageBox.Show("No te quedan más pistas, pesao.");
            }

            label1.Text = String.Concat("El número de pistas restantes es: ", ejemplo1.getPistas());

            if (ejemplo1.CheckIfwin())
            {
                MessageBox.Show("Has ganado, felicidades");
            }

        }

        private void IniciarJuego_Click(object sender, EventArgs e)
        {
            ejemplo1.Reiniciar();
            textBox1.Text = ejemplo1.getHiddenWord();
            textBox1.Refresh();

            label1.Text = String.Concat("El número de pistas restantes es: ", ejemplo1.getPistas());
            label2.Text = String.Concat("El número de intentos fallidos es: ", ejemplo1.getIntentos());

        }
    }
}
