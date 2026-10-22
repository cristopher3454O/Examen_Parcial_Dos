using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenDosRegistros
{
    internal class Taller
    {
        public string Nombre { get; set; } = "";
        public int CupoMaximo { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
