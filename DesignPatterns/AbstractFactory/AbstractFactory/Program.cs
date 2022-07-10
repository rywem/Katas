// See https://aka.ms/new-console-template for more information
//using AbstractFactory;
using AbstractFactory.OCP;

var machine = new HotDrinkMachine();

var drink = machine.MakeDrink();
drink.Consume();