using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Drawing;

namespace Service.Classes
{
    public class Karrigan : Classes.IFigure
    {
        private int healt;
        private int mana;
        public System.Drawing.Image img = Service.Properties.Resources.kerrigan;
        public System.Drawing.Image imgThumb = Service.Properties.Resources.KerriganThumb;
        public int Health
        {
            get{return healt;}
            set
            {
                if (value > 100)
                {
                    healt = 100;
                }
                else if (value < 0)
                {
                    healt = 0;
                }
                else healt = value;
            }
        }

        public int Mana
        {
            get { return mana; }
            set
            {
                if (value > 100)
                {
                    mana = 100;
                }
                else if (value < 0)
                {
                    mana = 0;
                }
                else mana = value;
            }
        }
        public int Level { get; set; }
        public string Name { get; set; }
        public string Trait { get; set; }

        public Karrigan()
        {
            Health = 10;
            Mana = 100;
            Level = 0;
            Name = "Queen of blades";
        }

        public string Refill()
        {
            Health += 10;
            Mana += 30;
            return "You won this round,hero.Enjoy it while it lasts";
        }

        public string ulty(IFigure Opp)
        {
            Opp.Health -= 20;
            Opp.Mana -= 10;
            this.Mana -= 30;

            return "Now, Hero, you shall know my wrath.";
        }

        public string Attack(IFigure Opp)
        {
            Opp.Health -= 10;
            this.Mana -= 20;

            return "I'll Kill you "+Opp.Name+"\n";
        }
        public string Talk()
        {
            return "I can sense your increasing f e a r"+"\n";
        }
        public Image getImage()
        {
            return img;
        }
        public Image getThumb()
        {
            return imgThumb;
        }
    }
}
