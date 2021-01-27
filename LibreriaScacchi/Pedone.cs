using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaScacchi
{
    public class Pedone:Pezzo
    {
        public Pedone(Colore schieramento):base(1,schieramento) { }

        public override void Muovi(Cella nuovaPosizione)
        {
            if (nuovaPosizione.Lettera==Posizione.Lettera)
            {
                int segno = Schieramento == Colore.Bianco ? +1 : -1;
                int start = Schieramento == Colore.Bianco ? 2 : 7;
                if ()
            }
        }
    }
}
