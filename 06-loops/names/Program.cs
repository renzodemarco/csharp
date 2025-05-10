
string[] names = { "Alex", "Eddie", "David", "Michael" };

Console.WriteLine("Escribimos todos los nombres hasta llegar a David:");

for (int i = 0; i < names.Length; i++)
{
  Console.WriteLine(names[i]);
  if (names[i] == "David") break;
}

Console.WriteLine("\nIteramos los nombres para modificar David por Sammy:");

for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);