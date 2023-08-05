using TiposEspeciais.Boxes;
using System.Globalization;
using Newtonsoft.Json;

DateTime DataAtual = DateTime.Now;

List<Sales> SalesList = new List<Sales>();

Sales Sale_1 = new Sales(1, "Television", 3500.25M, DataAtual);
Sales Sale_2 = new Sales(2, "Can", 500.25M, DataAtual);
Sales Sale_Fake = new Sales(9999, "Tenis Falseta", -480.25M, DataAtual);

SalesList.Add(Sale_1);
SalesList.Add(Sale_2);

string Serializado = JsonConvert.SerializeObject(SalesList, Formatting.Indented);
string Falseado = JsonConvert.SerializeObject(Sale_Fake, Formatting.Indented);
//Console.WriteLine(Serializado);
//Console.WriteLine("  ");
//Console.WriteLine("  ");



bool? desejaReceber = true;
if (desejaReceber.HasValue && desejaReceber.Value)
{
    Console.WriteLine($"O usuário Escolheu True então eu mostro {Serializado}");
    File.WriteAllText("Boxes/Valido.json", Serializado);
}
else if (desejaReceber == false)
{
    Console.WriteLine($"O usuário Escolheu False então eu mostro {Falseado}");
}
else
{
    Console.WriteLine("O usuário não respondeu é cotoco null");
}


