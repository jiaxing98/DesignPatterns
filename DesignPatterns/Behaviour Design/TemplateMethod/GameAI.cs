using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    // The abstract class defines a template method that contains a
    // skeleton of some algorithm composed of calls, usually to
    // abstract primitive operations. Concrete subclasses implement
    // these operations, but leave the template method itself
    // intact.
    public abstract class GameAI
    {
        protected bool hasEnemy;
        public void Turn()
        {
            CollectResources();
            BuildStructres();
            BuildUnits();
            Attack();
        }

        // Some of the steps may be implemented right in a base class.
        protected virtual void CollectResources()
        {
            Console.WriteLine("Collecting resources");
        }

        // A class can have several template methods.
        public void Attack()
        {
            if (!hasEnemy)
                SendScouts(0, 0);
            else
                SendWarriors(1, 1);
        }

        // And some of them may be defined as abstract.
        protected abstract void BuildStructres();
        protected abstract void BuildUnits();
        protected abstract void SendScouts(int x, int y);
        protected abstract void SendWarriors(int x, int y);
    }

    // Concrete classes have to implement all abstract operations of
    // the base class but they must not override the template method
    // itself.
    public class OrcAI : GameAI
    {
        protected override void BuildStructres()
        {
            Console.WriteLine("Orc is building structures...");
        }

        protected override void BuildUnits()
        {
            Console.WriteLine("Orc is building units...");
        }

        protected override void SendScouts(int x, int y)
        {
            Console.WriteLine($"Orc is sending scouts to ({x}, {y})...");
        }

        protected override void SendWarriors(int x, int y)
        {
            Console.WriteLine($"Orc is sending scouts to ({x}, {y})...");
        }
    }

    public class MonsterAI : GameAI
    {
        protected override void CollectResources()
        {
            Console.WriteLine("Monster don't collect resources...");
        }

        protected override void BuildStructres()
        {
            Console.WriteLine("Monster don't build structures...");
        }

        protected override void BuildUnits()
        {
            Console.WriteLine("Monster don't build units...");
        }

        protected override void SendScouts(int x, int y)
        {
            Console.WriteLine("Monster don't scout...");
        }

        protected override void SendWarriors(int x, int y)
        {
            Console.WriteLine($"Monster wandering at ({x}, {y})...");
        }
    }
}
