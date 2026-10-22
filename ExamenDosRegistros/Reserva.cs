using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenDosRegistros
{
    internal class Reserva
    {
        public string Responsable { get; set; } = "";
        public Taller Taller { get; set; } = new();
        public int Cantidad { get; set; }
        public string Turno { get; set; } = "";
        public bool Material { get; set; }
    }
}

