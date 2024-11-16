using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando instâncias dos smartphones
        Smartphone nokia = new Nokia("123456789", "3310", "Nokia", "KaiOS", 32);
        Smartphone iphone = new Iphone("987654321", "13", "Apple", "iOS", 128);

        // Testando funcionalidades da Nokia
        Console.WriteLine("Testando Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Testando funcionalidades do iPhone
        Console.WriteLine("Testando iPhone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}

public class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string marca, string sistemaOperacional, double memoria)
        : base(numero, modelo, marca, sistemaOperacional, memoria) { }

    // Implementando o método abstrato
    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
    }
}

public class Iphone : Smartphone
{
    public Iphone(string numero, string modelo, string marca, string sistemaOperacional, double memoria)
        : base(numero, modelo, marca, sistemaOperacional, memoria) { }

    // Implementando o método abstrato
    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
    }
}