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


    public partial class PantallaPrincipal : Form
    {

        Operaciones objectOperaciones;

        /// <summary>
        /// From Constructor 
        /// </summary>
        public PantallaPrincipal()
        {
            InitializeComponent();
            objectOperaciones = new Operaciones();          
            objectOperaciones.Reiniciar();
            textBox1.Text = objectOperaciones.getHiddenWord();
            label1.Text = String.Concat("El número de pistas restantes es: ", objectOperaciones.getPistas());
            label2.Text = String.Concat("El número de intentos fallidos es: ", objectOperaciones.getIntentos());
        }


        /// <summary>
        /// Evento asociado a todos los botones del teclado con letra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_click(object sender, EventArgs e) //Cuando se pulsa la letra de un boton, obtiene la misma en formato 
        {
            Button button = (Button)sender;
            char letra = Convert.ToChar(button.Text);        

            objectOperaciones.AñadirLetra(letra);
            textBox1.Text = objectOperaciones.getHiddenWord();
            textBox1.Refresh();

            label2.Text = String.Concat("El número de intentos restantes es: ", objectOperaciones.getIntentos());

            if (objectOperaciones.CheckIfwin())
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "/ah_ganador.png");
                MessageBox.Show("Has ganado felicidades");
            }

            switch (objectOperaciones.getIntentos())
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

                    MessageBox.Show("Has perdido, felicidades truán");
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Evento del boton Resolver que muestra la palabra correcta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Resolver_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = objectOperaciones.Resolver();
            textBox1.Refresh();
        }

        /// <summary>
        /// Evento del boton Pedir Pista que pide una pista para la hiddenword
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PedirPista_Click(object sender, EventArgs e)
        {
            if(objectOperaciones.getQuedanPistas())
            {
                objectOperaciones.UsarPista();
                textBox1.Text = objectOperaciones.getHiddenWord();
                textBox1.Refresh();
            }
            else
            {
                MessageBox.Show("No te quedan más pistas, pesao.");
            }

            label1.Text = String.Concat("El número de pistas restantes es: ", objectOperaciones.getPistas());

            if (objectOperaciones.CheckIfwin())
            {
                MessageBox.Show("Has ganado, felicidades");
            }

        }


        /// <summary>
        /// Evento del boton Iniciar Juego que reinicia los parámetros para volver a jugar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IniciarJuego_Click(object sender, EventArgs e)
        {
            objectOperaciones.Reiniciar();
            textBox1.Text = objectOperaciones.getHiddenWord();
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "/ah 0.png");
            textBox1.Refresh();

            label1.Text = String.Concat("El número de pistas restantes es: ", objectOperaciones.getPistas());
            label2.Text = String.Concat("El número de intentos fallidos es: ", objectOperaciones.getIntentos());

        }
    }
}
