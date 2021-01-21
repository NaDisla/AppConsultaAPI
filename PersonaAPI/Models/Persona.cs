using System;
using System.Collections.Generic;

#nullable disable

namespace PersonaAPI.Models
{
    public partial class Persona
    {
        public int PerId { get; set; }
        public string PerNombre { get; set; }
        public byte PerEdad { get; set; }
    }
}
