using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigonometricas
{
    /*Dentro de las carpetas que creemos dentro de nuestro proyecto, podemos crear multiples archivos.cs
      y a su vez dentro de esos archivos.cs podemos tener multiples namespaces, que sirven para separar y agrupar otras cosas (como ser clases).
     */
    /*
     En C# las clases no necesariamente deben llevar el mismo nombre del archivo 
     donde se encuentran las clases, es decir, si nuestro archivo se llama ClasesMatematicas, las clases
     que se creen dentro no necesariamente deben llamarse ClasesMatematicas. En otro lenguajes como Java si es necesario.
     */
    public class Circulo
    {
        //Al ser de tipo internal solo se puede usar en ambito local, pero como todo esta dentro del proyecto CSharp, entonces puede ser llamado en otro archivo.cs. 
        //Es mejor poner las clases de tipo publico.
    }
}
//dentro de archivos.cs puedo tener muchos namespaces, que sirven para agrupar clases, bloques de codigo, funciones, etc.
namespace Algebraicas
{
    public class Sumatorias
    {

    }
    //pueden haber anidamientos de namespaces, puede haber grupos dentro de grupos o lo que es mas simple
    //los namespaces pueden tener otros namespaces, es decir, otras agrupaciones, clases, funciones, bloques de codigo, etc.

    namespace Matriciales
    { 
        public class MatrizPerspectiva
        {

        }
    }
}


