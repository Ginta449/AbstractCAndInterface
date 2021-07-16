using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstrologyExample
{
    class Aries : Astrology, IAstrologyTwo
    {
        public override void StarSign()
        {
        }


        public void Description(string s)
        {
            s = "";//paramater to be passed

            MessageBox.Show("Aries(March 21 - April 19) " +
                  "Aries loves to be number one, so it’s no surprise " +
                  "that these audacious rams are the first sign of the zodiac." +
                  "Bold and ambitious, Aries dives headfirst into even the " +
                  "most challenging situations(which is appropriate, since the " +
                  "body part associated with Aries is the head).Like their fellow " +
                  "fire signs, Leo and Sagittarius, Aries is a passionate, motivated," +
                  " and confident leader who builds community with their cheerful" +
                  " disposition and relentless determination.Uncomplicated and direct " +
                  "in their approach, they often get frustrated by exhaustive details and " +
                  "unnecessary nuances.They like things quick and dirty, a temperament also " +
                  "reflected in their sexual proclivities. (Allure.com)");
        }

        public void PersonalityTraits(string p)//interface method
        {
            p = "";
        }
    }
}
