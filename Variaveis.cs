using System;
using System.Collections.Generic;

public class Veiculo
{
  public int Codigo { get; set; }
  public string Nome { get; set; }
  public string Combustivel { get; set; }
  public string Condicoes { get; set; }
  public decimal Preco { get; set; }
  public int AnoFabricacao { get; set; }
  public int Quantidade { get; set; }

  public Veiculo(int codigo, string nome, string combustivel, string condicoes, decimal preco, int anoFabricacao, int quantidade)
  {
    Codigo = codigo;
    Nome = nome;
    Combustivel = combustivel;
    Condicoes = condicoes;
    Preco = preco;
    AnoFabricacao = anoFabricacao;
    Quantidade = quantidade;
  }
}

public static class Variaveis
{
  public static List<Veiculo> veiculos = new List<Veiculo>();
  public static int proximoCodigo = 1;
}