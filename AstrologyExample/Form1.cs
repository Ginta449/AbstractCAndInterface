using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstrologyExample
{
    public partial class StarSign : Form
    {
        
        public StarSign()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Abstract class implemented
            Aries aries = new Aries();
    
            string[] ariesAstrologyDates = {"21/03", "22/03", "23/03", "24/03", "25/03", "26/03", "27/03", "28/03", "29/03",
                "30/03", "31/03", "01/04", "02/04", "03/04", "04/04", "05/04", "06/04", "06/04", "07/04", "08/04", "09/04",
                "10/04", "11/04" ,"12/04", "13/04", "14/04", "15/04", "16/04", "17/04", "18/04", "19/04"};

            foreach (string a in ariesAstrologyDates)
            {
                var ar = DateTime.Parse(a);
               
                if (monthCalendarAstrology.SelectionStart.Date == ar)
                {
                    aries.Description(s: richTextBox1.Text = "lalalala");//representation of override from abstract subclass method
                    aries.PersonalityTraits(p: richTextBox1.Text = "Strong, hard-working, intelligent");//adding interface to aries class
                }
            }

            //Interface implemented
            string[] piscesAstrologyDates = {"19/02", "20/02", "21/02", "22/02", "23/02", "24/02", "25/02", "26/02", "27/02",
                "28/02", "01/03", "02/03", "03/03", "04/03", "05/03", "06/03", "07/03", "08/03", "09/03", "10/03", "11/03",
                "12/03", "13/03" ,"14/03", "15/03", "16/03", "17/03", "18/03", "19/03", "20/03"};

            Pisces pisces = new Pisces();
       
            foreach (string ab in piscesAstrologyDates)
            {
                var arc = DateTime.Parse(ab);

                if (monthCalendarAstrology.SelectionStart.Date == arc)
                {
                    pisces.Description(s: richTextBox1.Text = "bbbbbbb");//representation of override from abstract subclass method
                    pisces.PersonalityTraits(p: richTextBox1.Text = "Fun, smart, creative");//second initerface override
                }
            }

        }
    }
}
