using System;

class Program
{
  static void Main(string[] args)
  {
    while (true)
    {
      int opcao;

      Console.WriteLine(@"
Bem-Vindo a Mercedes-Benz - Carros:

[1] Adicionar um Novo Veículo
[2] Listagem de veículos
[3] Remover veículo
[4] Dar entrada no estoque
[5] Dar sáida no estoque
[0] Sair do Programa

### By Guilherme Silva ###

");
      Console.Write("Escolha uma das opções: ");
      opcao = int.Parse(Console.ReadLine());

      switch (opcao)
      {
        case 1:
          Adicionar.AdicionarVeiculo();
          break;
        case 2:
          ListarVeiculos();
          break;
        case 3:
          RemoverVeiculo();
          break;
        case 4:
          Estoque.EntradaEstoque();
          break;
        case 5:
          Estoque.SaidaEstoque();
          break;
        case 0:
          Console.Clear();
          Environment.Exit(1);
          break;
        default:
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Número Inválido, digite de acordo com a lista, por favor!!");
          Console.ResetColor();
          break;
      }

    }
  }

  static void ListarVeiculos()
  {
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nLista de Veículos:\n");
    foreach (var veiculo in Variaveis.veiculos)
    {
      Console.WriteLine($"Código: {veiculo.Codigo} | Nome: {veiculo.Nome} | Combustível: {veiculo.Combustivel}, Condições: {veiculo.Condicoes} | Preço: {veiculo.Preco:C} | Ano: {veiculo.AnoFabricacao} | Quantidade: {veiculo.Quantidade}");
    }
    Console.ResetColor();
  }

  static void RemoverVeiculo()
  {
    Console.Write("Digite o código do veículo a ser removido: ");
    int codigo = int.Parse(Console.ReadLine());
    Veiculo veiculo = Variaveis.veiculos.Find(v => v.Codigo == codigo);

    if (veiculo != null)
    {
      Variaveis.veiculos.Remove(veiculo);
      Console.WriteLine("Veículo removido com sucesso!");
    }
    else
    {
      Console.WriteLine("Veículo não encontrado!");
    }
    Console.Clear();
  }
}