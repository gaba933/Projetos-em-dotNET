using AbstracaoCelular.models.classes;

Console.WriteLine("Celular Nokia");
Nokia nokia = new Nokia("123456789", "Nokia 1100", "123456789012345", 512);
nokia.ligar();
nokia.InstalarApp("WhatsApp");

Console.WriteLine("\n");
Console.WriteLine("---------------------");

Console.WriteLine("\nCelular Iphone");
Iphone iphone = new Iphone("987654321", "Iphone 13", "987654321098765", 128000);
iphone.receberLigacao();
iphone.InstalarApp("Instagram");