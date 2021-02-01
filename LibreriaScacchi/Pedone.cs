﻿using System;
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
            if (nuovaPosizione.Lettera == Posizione.Lettera)
            {
                int segno = Schieramento == Colore.Bianco ? +1 : -1;
                int start = Schieramento == Colore.Bianco ? 2 : 7;
                if (nuovaPosizione.Numero == Posizione.Numero + segno)
                {
                    Posizione = nuovaPosizione;
                }
                else if (Posizione.Numero == start && nuovaPosizione.Numero == Posizione.Numero + segno * 2)
                {
                    Posizione = nuovaPosizione;
                }
                else
                    Errore();

            }
            else
                Errore();
        }
    }
}
