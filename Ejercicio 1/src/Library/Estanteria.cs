using System;
using System.Collections.Generic;

namespace SRP
{
    public class Estanteria
    {
        public int codigo{get;set;}
        public Dictionary<string,Libro> libros{get;}

        public Estanteria(int codigo)
        {
            this.codigo = codigo;
            this.libros = new Dictionary<string,Libro>();
        }

        public void AddLibro(Libro nuevoLibro)
        {
            this.libros.Add(nuevoLibro.Code, nuevoLibro);
        }
    }
}