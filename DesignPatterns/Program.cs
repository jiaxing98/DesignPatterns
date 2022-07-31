﻿// See https://aka.ms/new-console-template for more information
// Dive into Design by Alexander Shvets
using FactoryMethod;
using AbstractFactory;
using Builder;

Console.WriteLine("Factory Method");
Main_FactoryMethod.Init(true, 8);
Main_FactoryMethod.Init(false, 8);
Console.WriteLine();

Console.WriteLine("Abstract Factory");
Main_AbstractFactory.Init(new VictorainFurnitureFactory());
Main_AbstractFactory.Init(new ModernFurnitureFactory());
Console.WriteLine();

Console.WriteLine("Builder");
Main_Builder.Init();
Console.WriteLine();