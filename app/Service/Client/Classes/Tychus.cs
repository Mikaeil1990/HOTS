using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Service.Classes
{
    public class Tychus : IFigure
    {

        private int healt;
        private int mana;
        public System.Drawing.Image img = Client.Properties.Resources.Tychus;
        public System.Drawing.Image imgThumb = Client.Properties.Resources.TychusThumb;
        public int Health
        {
            get { return healt; }
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

        public Tychus()
        {
            Health = 100;
            Mana = 100;
            Level = 0;
            Name = "Bullet machine";
        }

        public string Refill()
        {
            Health += 10;
            Mana += 30;
            return "I think i had enaugh for now...";
        }

        public string ulty(IFigure Opp)
        {
            Opp.Health -= 25;
            Opp.Mana -= 0;
            this.Mana -= 30;

            return "Die.Die.DIE!!!!!";
        }

        public string Attack(IFigure Opp)
        {
            Opp.Health -= 10;
            this.Mana -= 20;

            return "I'll Kill you "+Opp.Name+"\n";
        }
        public string Talk()
        {
            return "Who's hungry for some fried bulets??"+"\n";
        }

        public Image getImage()
        {
            return this.img;
        }

        public Image getThumb()
        {
            return this.imgThumb;
        }
    }
}
