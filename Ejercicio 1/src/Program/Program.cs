using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Libro book1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro book2 = new Libro("Pro C#","Troelsen","001-035");
            Biblioteca LaBiblioteca = new Biblioteca("La Biblioteca");
            book1.ShelveBook("A","7");
            book2.ShelveBook("B","3");

        }
    }
}