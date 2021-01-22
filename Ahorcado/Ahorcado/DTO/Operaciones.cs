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

        private string palabraAEncontrar;
        private char[] hiddenWord;
        private int intentosRestantes;
        private int pistasRestantes;
        private bool seguirJugando;
        private bool quedanPistas;

        /// <summary>
        /// Constructor
        /// </summary>
        public Operaciones()
        {
            //5 intentos fallidos para adivinar la palabra
            intentosRestantes = 0;
            pistasRestantes = 0;
            palabraAEncontrar = "";
            quedanPistas = true;
            seguirJugando = true;
        }
        #region Public method Region
        /// <summary>
        /// Método que reinicia la partida y inicializa todo los atributos a su estado inicial.
        /// </summary>
        public void Reiniciar()
        {
            //Escoger una nueva palabra del array
            palabraAEncontrar = EscogerPalabra();
            palabraAEncontrar = palabraAEncontrar.ToUpper();
            hiddenWord = new char[palabraAEncontrar.Length];
            RemplazarPorBarrasBajas(ref hiddenWord);

            //Ponemos imagen vacia TODO


            //Reiniciamos contadores de intentos
            intentosRestantes = 5;

            //Reiniciamos contador de pistas 
            pistasRestantes = 5;

            //Reiniciar booleanos
            seguirJugando = true;
            quedanPistas = true;

        }

        /// <summary>
        /// Método que comprueba si la letra está en la palabra a encontrar y si está, añade la palabra
        /// </summary>
        /// <param name="letra"></param>
        public void AñadirLetra(char letra)
        {

            if (palabraAEncontrar.Contains(letra))
            {
                for (int i = 0; i < palabraAEncontrar.Length; i++)
                {
                    if (palabraAEncontrar[i].Equals(letra))
                    {
                        hiddenWord[i] = letra;
                    }
                }
            }
            else
            {
                intentosRestantes--;

                if (intentosRestantes == 0)
                {
                    seguirJugando = false;
                }
            }
        }

        /// <summary>
        /// Método para usar pistas
        /// </summary>
        public void UsarPista()
        {

            if(pistasRestantes > 0)
            {
                //Añadimos letra random al hiddenArray 
                AñadirLetraRandomHiddenArray();
                //restamos 1 al contador de pistas
                pistasRestantes--;
                
            }

            if (pistasRestantes == 0)
            {
                quedanPistas = false;
            }
        }

        /// <summary>
        /// Método que devuelve la palabra totalmente descubierta con espacios intercalados 
        /// </summary>
        /// <returns></returns>
        public string Resolver()
        {          
            //Añadimos espacios intercalados a la palabra
            IntercalarEspacios(ref palabraAEncontrar);

            //Devolvemos la palabra descubierta con los espacios intercalados para actualizar el textbox.text.
            return palabraAEncontrar;

        }

        #endregion

        #region Getter and Setter region

        /// <summary>
        /// Método que devuelve el número de intentos restantes
        /// </summary>
        /// <returns></returns>
        public int getIntentos()
        {
            return intentosRestantes;
        }

        /// <summary>
        /// Método que devuelve el número de pistas restantes
        /// </summary>
        /// <returns></returns>
        public int getPistas()
        {
            return pistasRestantes;
        }

        /// <summary>
        /// Método que devuelve si quedan pistas por utilizar
        /// </summary>
        /// <returns></returns>
        public bool getQuedanPistas()
        {
            return quedanPistas;
        }


        /// <summary>
        /// Getter seguirJugando boolean.
        /// </summary>
        /// <returns></returns>
        public bool getSeguirJugando()
        {
            return seguirJugando;
        }

        /// <summary>
        /// Getter hiddenword convert to string
        /// </summary>
        /// <returns></returns>
        public string getHiddenWord()
        {
            string result = new string(hiddenWord);
            IntercalarEspacios(ref result); 
            return result;
        }

        #endregion

        #region Private method region
        /// <summary>
        /// Check if win
        /// </summary>
        /// <returns></returns>
        public bool CheckIfwin()
        {
            bool result = false;
            string tmpString = new string(hiddenWord);
            if (palabraAEncontrar == tmpString)
            {
                result = true;
                seguirJugando = false;
                
            }
            return result;
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

        /// <summary>
        /// Método para añadir una letra random en la hiddenword de la palabra a encontrar 
        /// </summary>
        private void AñadirLetraRandomHiddenArray()
        {
            bool notFinished = true;

            //Si la letra no está en la hiddenword, la añadimos.
            int i = 0;
            while (notFinished && i < hiddenWord.Length)
            {         
                if (hiddenWord[i] == '_')
                {
                    AñadirLetra(Convert.ToChar(palabraAEncontrar[i]));
                    notFinished = false;
                      
                }
                i++;
            }
        }

        /// <summary>
        /// Método que añade espacios entre las letras
        /// </summary>
        /// <param name="palabra"></param>
        private void IntercalarEspacios(ref string palabra)
        {

            int palabraLength = palabra.Length*2;

            for(int i = 1; i < palabraLength; i++)
            {                
                palabra = palabra.Insert(i," ");
                i++;

            }
        }

    }
    #endregion
}


