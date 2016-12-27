using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Service.Classes
{
    public class Factory : Classes.IFactory
    {
        
        
        
        public IFigure createFigure(string name)
        {
            if (name=="karrigan")
            {
                return (new Karrigan());
            }
            if (name=="Tyrael")
            {
                return (new Tyreal());
            }
            if (name == "Tychus")
            {
                return (new Tychus());
            }
            return (new Karrigan());
        }
        


    }
}
