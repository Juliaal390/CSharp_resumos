/*IENUMERABLE
explicação no link: https://dev.to/marcosbelorio/entendendo-as-diferencas-entre-ienumerable-e-list-em-c-1m7i
*/

private void TesteIEnumerable()
{
    var nomes = new List<string> { "Luis", "João", "Ricardo", "Alexandre" };
    IEnumerable<string> nomesContenhamLetraO = nomes.Where(x => x.Contains("o"));
    nomes[0] = "Marcos";

    foreach (var nome in nomesContenhamLetraO)
    {
        Console.WriteLine(nome);
    }
}