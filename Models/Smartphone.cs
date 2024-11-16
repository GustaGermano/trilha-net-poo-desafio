namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo { get; set; }  
        public string Marca { get; set; }   
        public string SistemaOperacional { get; set; }
        public double Memoria { get; set; }


        public Smartphone(string numero, string modelo, string marca, string sistemaOperacional, double memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Marca = marca;
            SistemaOperacional = sistemaOperacional;
            Memoria = memoria;
        }

        protected Smartphone(string numero)
        {
            Numero = numero;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}