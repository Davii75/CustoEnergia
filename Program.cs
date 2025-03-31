double consumo;
double horas;
double custoenergia;
decimal custoestimado;

Console.Write("Digite o consumo (kWh/mês): ");
consumo = Convert.ToDouble(Console.ReadLine()!);
Console.Write("\nDigite as horas de uso diárias: ");
horas = Convert.ToDouble(Console.ReadLine()!);
Console.Write("\nDigite o custo de energia do aparelho (em R$/kWh): ");
custoenergia = Convert.ToDouble(Console.ReadLine()!);
Console.Clear();

Console.WriteLine("--- Custo de Energia ---");
Console.WriteLine($"\nConsumo do aparelho (em kWh/mês)...: {consumo}");
Console.WriteLine($"Horas de uso por dia...............: {horas}");
Console.WriteLine($"Custo da energia (em R$/kWh).......: {custoenergia}");

custoestimado = Convert.ToDecimal(consumo * horas * custoenergia);
Console.WriteLine($"\nCusto estimado: {custoestimado:C2}");