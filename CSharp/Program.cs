namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *************************************
             * PROJECT OPEN SOURCE GNY
             * 
             * Author: YO PS QUIEN MAS XD
             * ***********************************
             */
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
             ***************REGLAS DE VARIABLES************
             * un flotante no puede ser guardado en un double
             * un double puede guardar un flotante
             * un entero no puede guardar un flotante
             * un flotante puede guardar un entero
             */
            double micro = peso;
            float x2 = 3.1415f;

            Console.WriteLine(x2);

            int res = (int)x2;

            Console.WriteLine(res);

            Console.WriteLine("Hola Mundo!");
        }
    }
}