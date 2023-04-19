using System;
using System.Collections.Generic;

namespace SRP
{
    public class Sector
    {
        public string nombre{get;}
        private Dictionary<string, Estanteria> estanterias;

        public Sector(string nombre)
        {
            this.nombre = nombre;
            this.estanterias = new Dictionary<string,Estanteria>();
        }

        public void AddEstanteria(Estanteria nuevaEstanteria)
        {
            this.estanterias.Add(nuevaEstanteria.codigo, nuevaEstanteria);
        }
    }
}