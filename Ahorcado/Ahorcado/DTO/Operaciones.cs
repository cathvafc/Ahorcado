using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
   
    class Operaciones
    {

        //Atributos 
          string[] palabras = { "Cientifico", "Carne", "Baloncesto", "Despejado","Ballesta","Aparatos","Descifrar","Mortal","Trompa", "Gigante", "Peregrino", "Sepultura", "Rastro", "Invitado", "Escritorio", "Forrar", "Problemas", "Municipio", "Principal"
                              ,"Espiral","Ardilla","Descalzo","Plural","Mudo","Congelar","Ansiedad","Avisos","Puente","Estado","Lianas","Empalmar","Piedra","Alta","Alumnos","Cabeza","Pato","Multiplicar","Cuerpo","Castor","Estudiar","Fragancia","Auxilio","Graduar","Finlandia","Sorteo","Meteorito","",
                              "Prisma","Cebolla","Sopa","Sendero","Alquilar","Ansiedad","Hablar","Minar","Hilos","Brea","Perejil","Nueve","Prender"};

        string palabraAEncontrar;
        char[] hiddenWord;
        int intentosRestantes;
        int pistasRestantes;

        /// <summary>
        /// Constructor
        /// </summary>
        public Operaciones()
        {
            //5 intentos fallidos para adivinar la palabra
            intentosRestantes = 5;
            palabraAEncontrar = "";
        }

        /// <summary>
        /// Método que reinicia la partida y inicializa todo los atributos a su estado inicial.
        /// </summary>
        public void Reiniciar()
        {
            //Escoger una nueva palabra del array
            palabraAEncontrar = EscogerPalabra();
            hiddenWord = new char[palabraAEncontrar.Length];
            RemplazarPorBarrasBajas(ref hiddenWord);

            //Ponemos imagen vacia TODO


            //Reiniciamos contadores de intentos
            intentosRestantes = 5;

            //Reiniciamos contador de pistas 
            pistasRestantes = 5;

        }

        public void AñadirLetra(char letra)
        {
            //Comprobamos si la letra está en el hiddenArray TODO

            //Si está en el array, añadimos la letra en las posiciones pertinentes y modificamos el textbox.text TODO


            // Si no está en el array TODO
                //Restamos un intento
                //Modificamos imagen
                //Comprobamos que intentos > 0
                    //Si intentos = 0, acabamos el programa
                    // Añadimos imagen de destrucción y muerte
        }

        public void UsarPista()
        {
            //Añadimos letra random al hiddenArray TODO

            //restamos 1 al contador de pistas TODO

        }

        public void Resolver()
        {
            //Mostramos la palabra a resolver en el textbox.text TODO


            //Mantenemos la imagen  TODO

        }

        /// <summary>
        /// Método que escoge una palabra rándom para ser descubierta 
        /// </summary>
        /// <returns></returns>
        private string EscogerPalabra()
        {
            Random random = new Random();

            int t = palabras.Length;
            string n = palabras[random.Next(t)];
            return n;
        }

        /// <summary>
        /// Método que cambia los caracteres de un array de char por _
        /// </summary>
        /// <param name="hiddenWord"></param>
        private void RemplazarPorBarrasBajas(ref char[] hiddenWord)
        {
            //Remplazamos los caractéres por _

            for (int i = 0; i < hiddenWord.Length; i++)
            {
                hiddenWord[i] = '_';
            }
        }



    }

}

   
