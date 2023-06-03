using Trigonometricas;
using Algebraicas.Matriciales;
using Algebraicas;

namespace zona_principal
{
    internal class Program
    {
        int var_global = 9;
        static void Main(string[] args)
        {
            /*
             *************************************
             * PROJECT OPEN SOURCE GNY
             * 
             * Author: YO PS QUIEN MAS XD
             * ***********************************
             */
            #region Tipos de Datos
            sumador(5, 67);
            int ladoX = 2;
            int ladoY = 5;
            int radio = 3;


            int potencia = 9;

            int cant_quinua = 34;

            //carnet de identidad
            int ci = 9874521;
            //numero de identificacion tributaria
            int nit = 9584231;

            float peso = 13.0f;

            double gravedad = 9.81;
            /*
             ***************REGLAS DE VARIABLES**********
             * un flotante no puede ser guardado en un double
             * un entero no puede guardar un double
             * un double puede guardar un flotante
             * un entero no puede guardar un flotante
             * un flotante puede guardar un entero
             */
            double micro = peso + gravedad / 0;

            float x2 = 3.1415f;

            Console.WriteLine(x2);

            // CASTEO - truncar con (int) un numero, es decir, reducir decimales
            int res = (int)x2;

            Console.WriteLine(res);

            Console.WriteLine("Hola Mundo!");

            string apellido = "Perez";

            char letra = 'a';

            //Tipos de variable var
            var nombre = "Pepe";

            var edad = 20;

            var w = 56.7;

            bool isAlive = true;

            string numeroEnTexto = "25";

            edad = int.Parse(numeroEnTexto);



            Console.WriteLine(edad);
            #endregion

            #region Otros ejemplos
            /*
             Existe tres tipos de errores:
            *Sintaxis = no cumplir con las nomas de tipado o escritura del lenguaje
            *Compilacion/Ejecucion 
            *Semantico
             */
            /*
             Los namespaces sirven para agrupar clases o contenido.
             El primer agrupador de los namespaces es el proyecto el cual agrupa contenido, folders, programs.cs, etc.
             */

            //Usando clases propias

            Circulo c;
            MatrizPerspectiva matriz1;
            Sumatorias sum;

            //Podemos llamar a la clase directamente sin ocupar el using namespace para asignarlo a una variable
            //De esta forma el namespace no sera ocupado en tooodo el program.cs y solo afectara a esa variable, de esta forma no ocupamos tanto proceso o memoria.

            Algebraicas.Sumatorias sums;
            Algebraicas.Matriciales.MatrizPerspectiva mtriz;
            otro.una_clase cc;

            //Operaciones

            Console.WriteLine("Ingrese un numero (diferente a cero)");

            //Manejo de excepciones

            string valorDelUsuario = Console.ReadLine();
            int numeroMisterioso = int.Parse(valorDelUsuario);
            int x = 0;
            //try = intentar ejecutar esa linea, si lo logra se sale del bloque y si no lo logra pasara a la exepcion, entrara en el catch
            try
            {
               x = 50 / numeroMisterioso;
            } catch (DivideByZeroException e) //si no logra ejecutar la linea dentro del bloque try, entonces ejecutara la linea del catch, es como in if/else
            {
                Console.WriteLine("Por favor, intente de nuevo, usted ingreso el numero 0.");
            } //una vez termine de ejecutarse el catch, seguira con el codigo, el programara continuara


            Console.WriteLine("La division es: " + x);
            int result = suma(2147483647, 1);
            Console.WriteLine("La suma es: " + result);
            #endregion
            #region Arreglos
            //unidimensional
            int[] ropero = new int[4];
            string[] argumentos = new string[0];
            ropero[0] = 1;
            ropero[1] = 6;
            ropero[2] = -13;
            ropero[3] = 236;

            int[] aux = new int[6];
            aux[0] = ropero[0];
            //ahora ropero tiene 6 espacios
            ropero = aux;

            //bidimensional
            int[,] matriz = new int[4, 6]; //fila, columna

            matriz[2, 4] = 23;
            // matriz[4, 2] = 23;
            //tridimiensionales
            int[,,,] arrays = new int[3, 3, 3, 3];
            //multidimiensionales
            int[,,,,] arr = new int[3, 3, 4, 5, 5];
            Console.WriteLine("Ropero en el indice 1:" + ropero[3]);

            #endregion
            #region SobreArgs
            Console.WriteLine( "args contiene esta cantidad de elementos: " + args.Length);
            #endregion
            #region Bucles
            //tambien llamados iteradores o loops


            //while: lo ocupamos cuando no sabemos cuantas veces vamos a iterar
            int eval = 10;
            while (eval >= 1)
            {
                Console.WriteLine("Estoy dentro del while" + eval);
                eval--;
                /*
                 la diferencia de usar --eval y eval-- o ++eval o eval++ o derivantes es la siguiente:
                en --eval primero resta en uno a la variable eval y luego obtiene la variable
                en eval-- primero obtiene la variable eval y lueego la modifica, causando que al mostrar la misma variable en
                una sola linea de codigo mediante consola, al usar --eval mostrara el valor actual que tenga eval y al usar eval-- mostrara el valor actual y no se decrementara en la misma linea
                 */
            }
            eval = 11;
            Console.WriteLine("Ya se acabo el while");
            int x1 = 3; int x3 = 4;
            Console.WriteLine("Suma rara: " + (--x1 + ++x3)); // 2 - 5
            Console.WriteLine("Suma normal: " + (--x1 + x3++)); //3 + 4
            Console.WriteLine("Suma normal: " + (x1-- + ++x3)); //3 +5
            /*
             eval +=6; ===> eval = eval + 6;
             eval -= 5; ===> eval = eval - 5
             eval +=4; ===> eval = eval + 4
             eval /=4; ===> eval = eval /4
             */

            //for: cuando sabemos cuantas veces vamos a iterar
            for(int i = 1; i <=10 ; i++)
            {
                Console.WriteLine("Estoy dentro del for " + i);
                i++;
            }
            Console.WriteLine("Ya acabo el for");
            #endregion
        }


        public void metodito()
        {
            int x = 3 * var_global;
        }
        public static void sumador(int a, int b)
        {
            //static = solo puede existir una unica instancia
            Console.WriteLine("SUMA DE DOS NUMEROS");
            int suma = a + b;
            Console.WriteLine("La suma de: " + a + " y " + b + " es: " + suma);
        }
        public static int suma(int a, int b)
        {
            int suma = a + b;
            return suma;
        }
    }
}
namespace otro
{
    //dentro de los namespace solo pueden haber clases, namespaces y usings.
    using System.Collections.Generic; //Sera usado para todas las clases o bloques de codigo del namespace otro. Es de uso local
    public class una_clase
    {
        //dentro de las clases pueden haber metodos y variables, pero no calculos
        Circulo circulo2;
        int y = 9;
        //y = 7; solo se puede declarar variables, mas no reasignar o hacer operaciones con las variables, eso solo se hace en los metodos de la clase
        //Se puede usar la clase Circulo porque su namespace Trigonometricas esta siendo utilizada o llamada arriba de todo
        public void met(int nit)
        {
            nit = nit + 3;
        }
        //pueden existir metodos con el mismo nombre, pero con diferentes tipos de parametros y cantidad
        public void met(string num)
        {
            num = num + 3;
        }
        public void met(int ci, string x)
        {
            ci = ci + 3;
        }
        public void met(string x, int ci)
        {
            registroEmpleado("Pedro", "Perez");
            registroEmpleado("Sofia", "Sanchez");
            registroEmpleado("Miranda", "Cristopher");
        }
        public void registroEmpleado(string Nombre, string Apellido)
        {

        }
    }
}