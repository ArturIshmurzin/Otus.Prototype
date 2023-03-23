using Otus.Prototype.Models;

Car car = new Car(3, 5, 60);

Car newCar = car.Copy();

Console.WriteLine(car.ToString());
Console.WriteLine();
Console.WriteLine(newCar.ToString());

Console.WriteLine("---------------------------------------------");
//Проверяем что переменные ссылаются на разные инстансы
newCar.Speed = 100;

Console.WriteLine(car.ToString());
Console.WriteLine();
Console.WriteLine(newCar.ToString());

Console.WriteLine("---------------------------------------------");

car = new Car(3, 5, 60);

newCar = (Car)car.Clone();

Console.WriteLine(car.ToString());
Console.WriteLine();
Console.WriteLine(newCar.ToString());

Console.WriteLine("---------------------------------------------");
//Проверяем что переменные ссылаются на разные инстансы
newCar.Speed = 100;

Console.WriteLine(car.ToString());
Console.WriteLine();
Console.WriteLine(newCar.ToString());

Console.ReadKey();