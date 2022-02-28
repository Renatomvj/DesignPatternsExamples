using factoryMethod = DesignPatterns.Factory.Factory_Method;
using abstractFactory = DesignPatterns.Factory.Abstract_Factory;
using DesignPatterns.Strategy;
using System;

namespace DesignPatterns
{
    class ProgramTeste
    {
        static void AMain(string[] args)
        {
            #region Pattern Abstract Factory
            new abstractFactory.Client().Main();

            #endregion

            #region Pattern Factory Method

            new factoryMethod.Client().Main();

            #endregion

            #region Pattern Strategy
            var navigator = new Navagatior();

            navigator.SetStrategy(new PublicTransport());
            Console.WriteLine(navigator.ExecuteStrategy(a: 1, b: 2));

            navigator.SetStrategy(new RoadStrategy());
            Console.WriteLine(navigator.ExecuteStrategy(a: 1, b: 2));

            navigator.SetStrategy(new WalkingStrategy());
            Console.WriteLine(navigator.ExecuteStrategy(a: 1, b: 2));
            #endregion

            Console.ReadKey();
        }
    }
}
