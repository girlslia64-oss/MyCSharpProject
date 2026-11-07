using System.IO.Compression;

Spravka83 spravka83 = new Spravka83();
spravka83.Name = "Spravka 083";
spravka83.Price = 1000;

Console.WriteLine(spravka83.Name);
Console.WriteLine(spravka83.Price);
Console.WriteLine(" К ОПЛАТЕ" + spravka83.CalculatePrice());

Console.WriteLine();

Patient patient = new Patient();
patient.PhoneNumber = "+996 78 90 78";
patient.Email = "sarmanovagulsan@gmail.com";
Console.WriteLine("КАК УВЕДОМИТ ПАЦИЕНТА? 1- sms, 2- email:");

INotifier notifier = Console.ReadLine() == "1" ? new SmsNotifier() : new EmailNotifier();
notifier.Send(patient,"Ваша справка готова");

SpravkaSanknijka sanknijka = new SpravkaSanknijka();
sanknijka.Name = "Sanitarnaya knizhka";
sanknijka.Price = 250;
sanknijka.AnalysesCount = 3;

Console.WriteLine(sanknijka.Name);
Console.WriteLine(sanknijka.Price);
Console.WriteLine("К ОПЛАТЕ:" + sanknijka.CalculatePrice());

Console.WriteLine();

List<ISpravka> spravki = new List<ISpravka> {spravka83, sanknijka};
Kassa kassa = new Kassa();

SpravkaBassein bassein = new SpravkaBassein();
Console.WriteLine(bassein.Name);
Console.WriteLine(bassein.Price);
Console.WriteLine("ИТОГ:" + kassa.Total(spravki));