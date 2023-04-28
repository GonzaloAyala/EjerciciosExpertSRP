using System;
using System.Collections.Generic;

namespace SRP
{
    public class Estanteria
    {
        public string Codigo{get;set;}
        public Dictionary<string,Libro> Libros{get;}

        public Estanteria(string codigo)
        {
            this.Codigo = codigo;
            this.Libros = new Dictionary<string,Libro>();
        }

        public void AddLibro(Libro nuevoLibro)
        {
            this.Libros.Add(nuevoLibro.Code, nuevoLibro);
        }
    }
}