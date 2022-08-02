using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //Use the Factory Method when you don't know beforehand the exact
    //types and dependencies of the objects your code should work with.
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
