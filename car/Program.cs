// See https://aka.ms/new-console-template for more information
#region Interfaces
using car.Classes;

Car car = new Car(120);
Console.WriteLine("Enter amount of car ");
int amount = int.Parse(Console.ReadLine());
car.Drive();
#endregion