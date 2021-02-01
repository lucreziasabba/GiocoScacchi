using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaScacchi
{
    public class Alfiere : Pezzo
    {
        public Alfiere (Colore schieramento) : base(3, schieramento) { }

        public override void Muovi(Cella nuovaPosizione)
        {
            if (Math.Abs(nuovaPosizione.Lettera - Posizione.Lettera) ==
                Math.Abs(nuovaPosizione.Numero - Posizione.Numero))
            {
                Posizione = nuovaPosizione;
            }
            else
                Errore();
        }
    }
}
