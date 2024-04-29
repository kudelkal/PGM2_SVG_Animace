﻿using System.Drawing;

namespace PGM2_SVG_Animace.Models
{
    public class Obdelnik : Ctverec
    {
        public Obdelnik(Globals.TypObrazce typObrazce, int pozX, int pozY, Color barva, int stranaA, int stranaB) : base(typObrazce,pozX, pozY, barva, stranaA)
        {
            StranaB = stranaB;
        }
        public int StranaB { get; set; }
    }
}
