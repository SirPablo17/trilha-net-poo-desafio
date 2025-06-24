using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("SmartPhone Iphone, IOS: ");
Smartphone iphone = new Iphone("254151515", "iPhone 20", "55652545", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Nokia, Android: ");
Smartphone nokia = new Nokia("40028922", "Big Nokia", "51615616", 8);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("MSN");