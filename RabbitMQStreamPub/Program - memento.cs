using DesignPatterns;
using DesignPatterns.Cases.Case2;
using DesignPatterns.Cases.Case2.Strategies;
using DesignPatterns.Command.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Unity;

namespace DesignPatterns
{

    class ProgramMemento
    {
        public static IUnityContainer container = new UnityContainer();

        static void ProgramM(string[] args)
        {        

            // Memento 
            MementoClient mc = new MementoClient();
            mc.Execute();

            Console.ReadKey();
        }
      
    }
}