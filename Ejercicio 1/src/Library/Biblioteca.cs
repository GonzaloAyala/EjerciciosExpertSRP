using System;
using System.Collections.Generic;

namespace SRP
{
    public class Biblioteca
    {
        public string Nombre{get;set;}
        public Dictionary<string,Sector> Sectores{get;}

        public Biblioteca(string nombre)
        {
            this.Nombre = nombre;
            this.Sectores = new Dictionary<string,Sector>();
        }

        public void CheckSector(string nombre)
        {
            if (!this.Sectores.ContainsKey(nombre))
            {
                Sector nuevoSector = new Sector(nombre);
                this.Sectores.Add(nombre, nuevoSector);
            }
        }

        private bool CheckLibro(Libro libro)
        {
            this.Sectores.foreach (var nombreSector in sector)
            {
                
            }
        }

        public void GuardarLibro(Libro libro, string sector, string estanteria)
        {
            {
                this.CheckSector(sector);
                Sector SectorLibro = this.Sectores[sector];
                SectorLibro.GuardarLibro(libro, estanteria);
            }
        }
    }
}