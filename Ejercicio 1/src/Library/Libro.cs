using System;

namespace SRP
{
    public class Libro
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        //public string LibrarySector { get ; set; }
        //public string LibraryShelve { get ; set; }
        /*
        Parte 1
        La clase libro ya tiene la responsabilidad de crear objetos Libro que representan libros individuales y contienen la
        información de su título, autor y código de identificación. En este caso, cada objeto libro tiene la responsabilidad
        de saber en qué estantería y en qué sector de la biblioteca se encuentran. Para respetar SRP, Shelve y Sector deberían
        ser clases que crean objetos que guardan objetos Book y Shelve, respectivamente.
        */

        public Libro(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }
}
