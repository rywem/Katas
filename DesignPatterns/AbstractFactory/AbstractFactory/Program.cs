// See https://aka.ms/new-console-template for more information
using AbstractFactory;

var machine = new HotDrinkMachine();

var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 100);
drink.Consume();