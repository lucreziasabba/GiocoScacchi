using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaScacchi
{
    public class Torre:Pezzo
    {
        public Torre(Colore schieramento) : base(5, schieramento) { }

        public override void Muovi(Cella nuovaPosizione)
        {
            if (nuovaPosizione.Lettera == Posizione.Lettera ||
                nuovaPosizione.Numero == Posizione.Numero)
            {
                Posizione = nuovaPosizione;
            }
            else
                Errore();
        }
    }
}
