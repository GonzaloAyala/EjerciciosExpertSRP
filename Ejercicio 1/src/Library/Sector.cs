using System;
using System.Collections.Generic;

namespace SRP
{
    public class Sector
    {
        public string Nombre{get;}
        private Dictionary<string, Estanteria> Estanterias;

        public Sector(string nombre)
        {
            this.Nombre = nombre;
            this.Estanterias = new Dictionary<string,Estanteria>();
        }

        public void CheckEstanteria(string nombre)
        {
            if (!this.Estanterias.ContainsKey(nombre))
            {
                Estanteria nuevaEstanteria = new Estanteria(nombre);
                this.Estanterias.Add(nombre, nuevaEstanteria);
            }
        }
        public void GuardarLibro(Libro libro, string estanteria)
        {
            this.CheckEstanteria(estanteria);
            this.Estanterias[estanteria].AddLibro(libro);
        }
    }
}