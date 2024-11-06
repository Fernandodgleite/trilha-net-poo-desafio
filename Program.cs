using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("500", "Iphone 15 plus", "300", 200);
Nokia nokia = new Nokia("3234", "Nokia Tijolao", "300", 500);
string nomeApp = "Whatsapp";
iphone.InstalarAplicativo(nomeApp);
nokia.InstalarAplicativo(nomeApp);