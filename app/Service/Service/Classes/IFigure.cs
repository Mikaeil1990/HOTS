using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Service.Classes
{
    public interface IFigure
    {
        int Health { get; set; }
        int Mana { get; set; }
        int Level { get; set; }
        string Name { get; set; }
        string Trait { get; set; }
        

        //string jump();
        string ulty(IFigure Opp);
        string Attack (IFigure Opp);
        string Refill();
        string Talk();
        Image getImage();
        Image getThumb();

    }
}
