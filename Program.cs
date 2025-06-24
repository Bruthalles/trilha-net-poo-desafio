using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nk = new Nokia(numero: "219821982",modelo:"tijolao",imei:"111010101",memoria: 16);
nk.Ligar();
nk.InstalarAplicativo("Animes");
Console.WriteLine();

Iphone ip = new Iphone(numero:"3221121",modelo:"XR Pro Max",imei:"91221212",memoria:256);
ip.ReceberLigacao();
ip.InstalarAplicativo("youtube");

