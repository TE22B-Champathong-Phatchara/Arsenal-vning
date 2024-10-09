using System.Text.Json;


string weapons = File.ReadAllText("weapon.json");

Weapons w = JsonSerializer.Deserialize<Weapons>(weapons);

System.Console.WriteLine($"Your weapon is {w.Name}.");

Console.Write("Enter the number of attacks to perform: ");
int numberOfAttacks = int.Parse(Console.ReadLine());

int totalDamage = 0; 

for (int i = 0; i < numberOfAttacks; i++)
{
    int Atk = w.Attack(); 
    totalDamage += Atk; 
    System.Console.WriteLine($"{w.Name} deals {Atk} damage!");
}

Console.WriteLine($"\nTotal damage dealt after {numberOfAttacks} attacks: {totalDamage}");

Console.ReadLine();