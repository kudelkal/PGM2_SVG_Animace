using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace PGM2_SVG_Animace.Models
{
    public class Kruh : Obrazec
    {
        public Kruh(Globals.TypObrazce typObrazce,int pozX, int pozY, Color barva, int polomer) : base(typObrazce, pozX, pozY, barva)
        {
            Polomer = polomer;
        }
        public int Polomer {  get; set; }
        
    }
}
