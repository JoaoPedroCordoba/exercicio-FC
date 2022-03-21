double F, C;

Console.WriteLine("Digite a temperatura em °F, por favor:");
F = Convert.ToDouble(Console.ReadLine());

C = (F-32) /1.8;

Console.WriteLine($"Temperatura em °C é {C:N2}°C");
