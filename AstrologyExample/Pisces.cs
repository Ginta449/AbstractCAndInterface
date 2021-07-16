using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstrologyExample
{
    class Pisces: AstrologyInterface, IAstrologyTwo //good practice to call it IAstrology
    {
        public void Description(string s)
        {
            s = "";

            MessageBox.Show("Pisces (February 19 - March 20) " +
                "Pisces, a water sign, is the last constellation " +
                "of the zodiac.It's symbolized by two fish swimming" +
                " in opposite directions, representing the constant" +
                " division of Pisces's attention between fantasy and" +
                " reality.As the final sign, Pisces has absorbed every" +
                " lesson — the joys and the pains, the hopes and the" +
                " fears — learned by all of the other signs.This makes " +
                "these fish the most psychic, empathetic, and compassionate" +
                " creatures of the astrological wheel.With such immense" +
                " sensitivity, Pisces can easily become swallowed by" +
                " emotions and must remember to stay grounded in the" +
                " material realm(appropriately, Pisces rules the feet).");
        }

        public void PersonalityTraits(string p)
        {
            p = "";
        }
    }
}
