namespace Aula02Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
            // forma AAAAMMDD e AAMMDD.Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

            // Ler a data no formato DDMMAAAA
            Console.Write("Digite a data no formato DDMMAAAA: ");
            string data = Console.ReadLine();

            // Extrair o dia, o mês e o ano da data
            int dia = int.Parse(data.Substring(0, 2));
            int mes = int.Parse(data.Substring(2, 2));
            int ano = int.Parse(data.Substring(4, 4));
            Console.WriteLine("-----------------------------------");

            // Imprimir a data no formato AAAAMMDD
            Console.WriteLine("Data no formato AAAAMMDD: " + ano + mes.ToString("D2") + dia.ToString("D2"));
            Console.WriteLine("-----------------------------------");

            // Imprimir a data no formato AAMMDD
            Console.WriteLine("Data no formato AAMMDD: " + ano.ToString().Substring(2) + mes.ToString("D2") + dia.ToString("D2"));
            Console.WriteLine("-----------------------------------");

        }
    }
}