namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo;
        protected string Imei;
        protected int Memoria;
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar(string numeroLigar)
        {
            Console.WriteLine($"Ligando para {numeroLigar} ...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void AlterarNumeroCelular(string novoNumero)
        {
            Numero = novoNumero;
            Console.WriteLine($"Seu novo numero é : {Numero}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}