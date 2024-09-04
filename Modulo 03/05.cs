using System;
using System.Collections.Generic;
public class Produto
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    // Construtor sem o parâmetro Id, pois ele será gerado automaticamente (GUID)
    public Produto(string nome, decimal preco)
    {
        Id = Guid.NewGuid();  // Gera um novo Guid automaticamente
        Nome = nome;
        Preco = preco;
    }
}
public class Program
{
    public static void Main()
    {
        // Criando a lista de produtos do tipo Produto (classe)
        List<Produto> produtos = new List<Produto>();
        // Adicionando objetos à lista
        produtos.Add(new Produto("Caneta", 1.99m));
        produtos.Add(new Produto("Caderno", 15.99m));
        produtos.Add(new Produto("Borracha", 0.99m));
        // Iterando sobre a lista e exibindo os produtos
        foreach (Produto produto in produtos)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco:C}");
        }
    }
}