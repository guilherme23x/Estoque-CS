using System;

public static class Estoque
{

  public static void EntradaEstoque()
  {

    Console.Write("Digite o código do veículo: ");
    int codigo = int.Parse(Console.ReadLine());
    Veiculo veiculo = Variaveis.veiculos.Find(v => v.Codigo == codigo);

    if (veiculo != null)
    {
      Console.Write("Digite a quantidade a ser adicionada: ");
      int quantidade = int.Parse(Console.ReadLine());
      veiculo.Quantidade += quantidade;
      Console.WriteLine("Entrada no estoque realizada com sucesso!");
    }
    else
    {
      Console.WriteLine("Veículo não encontrado!");
    }
    Console.Clear();
  }

  public static void SaidaEstoque()
  {

    Console.Write("Digite o código do veículo: ");
    int codigo = int.Parse(Console.ReadLine());
    Veiculo veiculo = Variaveis.veiculos.Find(v => v.Codigo == codigo);

    if (veiculo != null)
    {
      Console.Write("Digite a quantidade a ser removida: ");
      int quantidade = int.Parse(Console.ReadLine());

      if (quantidade <= veiculo.Quantidade)
      {
        veiculo.Quantidade -= quantidade;
        Console.WriteLine("Saída do estoque realizada com sucesso!");
      }
      else
      {
        Console.WriteLine("Quantidade insuficiente no estoque!");
      }
    }
    else
    {
      Console.WriteLine("Veículo não encontrado!");
    }
    Console.Clear();
  }
}