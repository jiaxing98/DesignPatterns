using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //Use the Factory Method when you don't know beforehand the exact
    //types and dependencies of the objects your code should work with.

    //Use the Factory Method when you want to provide users of
    //your library or framework with a way to extend its internal
    //components.

    //Use the Factory Method when you want to save system
    //resources by reusing existing objects instead of rebuilding
    //them each time.

    public static class Main_FactoryMethod
    {
        private static Logistics? logistics;

        //Init the desired class depends on the conditions
        public static void Init(bool isRoad, int fuel)
        {
            if(isRoad)
            {
                logistics = new RoadLogistics();
                logistics.PlanDelivery(fuel);
            } 
            else
            {
                logistics = new SeaLogistics();
                logistics.PlanDelivery(fuel);
            }
        }
    }
}
