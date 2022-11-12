using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Celular Iphone");
Smartphone cel1 = new Iphone("98520-7643", "Iphone10", "6654380gtf25", 64);
Console.WriteLine($"seu numero é: {cel1.Numero}");
cel1.Ligar("98653-8900");
cel1.ReceberLigacao();
cel1.InstalarAplicativo("Netfilx");
cel1.AlterarNumeroCelular("86907-4453");

Console.WriteLine("===========================================");

Console.WriteLine("Celular Nokia");
Smartphone cel2 = new Nokia(numero: "78953-6542", modelo: "Nokia_8000", imei: "767t5dsa5789", memoria: 138);
Console.WriteLine($"seu numero é: {cel2.Numero}");
cel2.Ligar("89767-5674");
cel2.ReceberLigacao();
cel2.InstalarAplicativo("YouTube");
cel2.AlterarNumeroCelular("79854-4056");
