using DesafioPOO.Models;

/* Teste Nokia */
Console.WriteLine("Teste com Nokia:");
Nokia meuNokia = new Nokia("9876543210", "Nokia 3310", "543210987654321", 64);

meuNokia.Ligar();
meuNokia.ReceberLigacao();
meuNokia.InstalarAplicativo("Telegram");

Console.WriteLine($"Numero: {meuNokia.Numero}, Modelo: {meuNokia.Modelo}, IMEI: {meuNokia.Imei}, Memoria: {meuNokia.Memoria}");

Console.WriteLine();

/* Teste Iphone */
Console.WriteLine("Teste com iPhone:");
Iphone meuIphone = new Iphone("1234567890", "iPhone 13", "123456789012345", 256);

meuIphone.Ligar();
meuIphone.ReceberLigacao();
meuIphone.InstalarAplicativo("WhatsApp");
            
Console.WriteLine($"Numero: {meuIphone.Numero}, Modelo: {meuIphone.Modelo}, IMEI: {meuIphone.Imei}, Memoria: {meuIphone.Memoria}");