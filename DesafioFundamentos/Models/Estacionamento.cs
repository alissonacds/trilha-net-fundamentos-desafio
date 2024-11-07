namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Add placa de veiculo a lista veiculos
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Solicita a placa do veiculo para remover da lista
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Realiza o calculo do valorTotal para um veiculo add a lista
                int horas = 0;
                horas = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                decimal valorTotal = 0;
                valorTotal = precoInicial + precoPorHora * horas;

                // Pesquisa a placa na lista veiculos e retorna a placa com o calculo do valorTotal
                
                foreach (string item in veiculos)
                {
                    if (item.ToUpper() == placa.ToUpper())
                    {
                        veiculos.Remove(item);
                        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                    }

                    break;
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Laço para listar os veiculos cadastrados
                int contadorForeach = 0;
                foreach(string item in veiculos)
                {
                    Console.WriteLine($"Veiculo = {contadorForeach + 1} - placa: {item}");
                    contadorForeach++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
