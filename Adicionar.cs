using System;

public static class Adicionar
{
  public static void AdicionarVeiculo()
  {
    Console.Write("Digite o nome do veículo: ");
    string nome = Console.ReadLine();

    Console.Write("Digite o tipo de combustível (Gasolina / Etanol / Elétrica): ");
    string combustivel = Console.ReadLine();

    Console.Write("Digite as condições (Novo / Usado): ");
    string condicoes = Console.ReadLine();

    Console.Write("Digite o preço: ");
    decimal preco = decimal.Parse(Console.ReadLine());

    Console.Write("Digite o ano de fabricação: ");
    int anoFabricacao = int.Parse(Console.ReadLine());

    Console.Write("Digite a quantidade em estoque: ");
    int quantidade = int.Parse(Console.ReadLine());

    Veiculo veiculo = new Veiculo(Variaveis.proximoCodigo++, nome, combustivel, condicoes, preco, anoFabricacao, quantidade);
    Variaveis.veiculos.Add(veiculo);
    Console.Clear();
  }
}