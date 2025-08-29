using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//IMPLEMENTADO!

Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 16);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Iphone iphone = new Iphone("987654321", "Iphone 12", "987654321098765", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");