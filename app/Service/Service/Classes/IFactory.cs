using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Service.Classes
{
    public interface IFactory
    {
          Classes.IFigure createFigure(string name);
          
          
          
          
         //IMap createMap();
        //IFood createFood();
         //IFigure createSportFigure();
       // IFemale createFemale();
       // IGadget createGadget();

    }
}
