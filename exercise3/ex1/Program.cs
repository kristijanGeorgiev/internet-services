// See https://aka.ms/new-console-template for more information
#region Animal
using ex1.Classes;
using ex1.Inheritence;
Animal animal = new Animal();
#endregion
#region Dog
animal.id = 1;
animal.name = "Runie";
Console.WriteLine($" The id of the animal is {animal.id} and the name of the animal is {animal.name}");
Pig pig = new Pig();
pig.animalSound();
#endregion
