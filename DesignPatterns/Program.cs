// See https://aka.ms/new-console-template for more information
// Dive into Design by Alexander Shvets
using FactoryMethod;
using AbstractFactory;
using Builder;
using Singleton;
using Prototype;
using Adapter;
using Bridge;
using Decorator;
using Facade;
using Flyweight;
using Proxy;
using ChainOfResponsibility;
using Command;
using Iterator;
using Mediator;
using Memento;
using Observer;
using State;

#region Creational Design
//Console.WriteLine("Factory Method");
//Main_FactoryMethod.Init(true, 8);
//Main_FactoryMethod.Init(false, 8);
//Console.WriteLine();

//Console.WriteLine("Abstract Factory");
//Main_AbstractFactory.Init(new VictorainFurnitureFactory());
//Main_AbstractFactory.Init(new ModernFurnitureFactory());
//Console.WriteLine();

//Console.WriteLine("Builder");
//Main_Builder.Init();
//Console.WriteLine();

//Console.WriteLine("Singleton");
//Main_Singleton.Init();
//Console.WriteLine();

//Console.WriteLine("Prototype");
//Main_Prototype.Init();
//Console.WriteLine();
#endregion

#region Structural Design
//Console.WriteLine("Adapter");
//Main_Adapter.Init();
//Console.WriteLine();

//Console.WriteLine("Bridge");
//Main_Bridge.Init();
//Console.WriteLine();

//Console.WriteLine("Decorator");
//Main_Decorator.Init();
//Console.WriteLine();

//Console.WriteLine("Facade");
//Main_Facade.Init();
//Console.WriteLine();

//Console.WriteLine("Flyweight");
//Main_Flyweight.Init();
//Console.WriteLine();

//Console.WriteLine("Proxy");
//Main_Proxy.Init();
//Console.WriteLine();
#endregion

Console.WriteLine("Chain Of Responsibility");
Main_ChainOfResponsibility.Init();
Console.WriteLine();

Console.WriteLine("Command");
Main_Command.Init();
Console.WriteLine();

Console.WriteLine("Iterator");
Main_Iterator.Init();
Console.WriteLine();

Console.WriteLine("Mediator");
Main_Mediator.Init();
Console.WriteLine();

Console.WriteLine("Memento");
Main_Memento.Init();
Console.WriteLine();

Console.WriteLine("Observer");
Main_Observer.Init();
Console.WriteLine();

Console.WriteLine("State");
Main_State.Init();
Console.WriteLine();