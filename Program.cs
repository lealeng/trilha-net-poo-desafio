using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "81919293", modelo: "Sony Ericson", imei: "sn10102", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "81923120", modelo: "16 Pro Max", imei: "16pm1023", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");