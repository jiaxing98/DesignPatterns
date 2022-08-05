using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    //Use the Template Method pattern when you want to let clients
    //extend only particular steps of an algorithm, but not the whole
    //algorithm or its structure.

    //Use the pattern when you have several classes that contain
    //almost identical algorithms with some minor differences.As a
    //result, you might need to modify all classes when the algorithm
    //changes.

    public static class Main_TemplateMethod
    {
        public static void Init()
        {

            OrcAI orc = new OrcAI();
            MonsterAI monster = new MonsterAI();

            List<GameAI> gameAIs = new List<GameAI>();
            gameAIs.Add(orc);
            gameAIs.Add(monster);

            gameAIs.ForEach(x => x.Turn());
        }
    }
}
