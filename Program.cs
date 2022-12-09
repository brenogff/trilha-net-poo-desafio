using DesafioPOO.Models;

//IMPLEMENTADO
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "X10", imei: "00000001", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "Iphone 15", imei: "00000002", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");