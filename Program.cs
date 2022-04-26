




using Homework3;

Console.WriteLine();
Console.WriteLine("=======================1===================");
Console.WriteLine();


Telefons telefons = new Telefons();
telefons.Size = 30;
telefons.Brand = "Nokia";
telefons.Model = "33.10";

telefons.Call();
Console.WriteLine(" - Hello it's 911. How may we assist? ");

telefons.Sms();
Console.WriteLine(" - Nice things recieved. Thank you.");



Console.WriteLine();
Console.WriteLine("=====================2=====================");
Console.WriteLine();

Mashina mashina = new Mashina();
mashina.Brand = "Opel";
mashina.NumberPlate = "lv2314";
mashina.Speed = 220;

Console.WriteLine(" Let's gooooooooooooo, Am Sonic");
mashina.GoFaster();


mashina.Beep();
mashina.SlowDown();
mashina.SlowDown();
mashina.SlowDown();
mashina.SlowDown();
mashina.SlowDown();

Console.WriteLine("That's enough of speed, gas prices n'sane");

mashina.Stop();
Console.WriteLine("Time for a snack!!");


Console.WriteLine();
Console.WriteLine("======================3====================");
Console.WriteLine();


Prece prece = new Prece();
Console.WriteLine("Ludzu ievadiet preces Augstumu : ");
string Weight = Console.ReadLine();
Console.WriteLine("Ievadiet Platumu : ");
string Width = Console.ReadLine();
Console.WriteLine("Un svars? -");
string Height = Console.ReadLine(); 
Console.ReadLine();




Console.WriteLine();
Console.WriteLine("=====================4====================");
Console.WriteLine();






Persona person = new Persona();
person.Name = "Laimonis";
person.Surname = "Lasmanis";
//person.BirthDate = "21.03.93";
person.Age = 29;
person.Hobby = "Eating and sleeping. Sometimes movies";
person.Gender = true;
person.Greeting();

