using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //Use the Strategy pattern when you want to use different variants
    //of an algorithm within an object and be able to switch
    //from one algorithm to another during runtime.

    //Use the Strategy when you have a lot of similar classes that
    //only differ in the way they execute some behavior.

    //Use the pattern to isolate the business logic of a class from
    //the implementation details of algorithms that may not be as
    //important in the context of that logic.

    //Use the pattern when your class has a massive conditional
    //operator that switches between different variants of the same
    //algorithm.

    public static class Main_Strategy
    {
        public static void Init()
        {
            Context context = new Context();
            int a = 10;
            int b = 20;
            Console.WriteLine($"a: {a}, b: {b}");

            context.SetStrategy(new ConcreteStrategyAdd());
            var result1 = context.ExecuteStrategy(a, b);
            Console.WriteLine($"Strategy Add: {result1}");

            context.SetStrategy(new ConcreteStrategySubstract());
            var result2 = context.ExecuteStrategy(a, b);
            Console.WriteLine($"Strategy Substract: {result2}");

            context.SetStrategy(new ConcreteStrategyMultiply());
            var result3 = context.ExecuteStrategy(a, b);
            Console.WriteLine($"Strategy Multiply: {result3}");
        }
    }
}
