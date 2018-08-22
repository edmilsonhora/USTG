﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model
{
    class ControleDeFalta
    {
        public int IdControleDeFalt { get; set; }
        public ReservistaM Reservista_IdReservista { get; set; }
        public string Data { get; set; }
        public bool Presenca { get; set; }

        public ControleDeFalta()
        {
        }

        public ControleDeFalta(int idControleDeFalt, ReservistaM reservista_IdReservista, string data, bool presenca)
        {
            IdControleDeFalt = idControleDeFalt;
            Reservista_IdReservista = reservista_IdReservista;
            Data = data;
            Presenca = presenca;
        }
    }
}
