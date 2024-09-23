
Warrior warriorA = new Warrior("Ragnar", 300, new Sword("Excalibur", 30, 50));
Warrior warriorB = new Warrior("Lagertha", 300, new Sword("Collosal Slayer", 40, 60));

Console.WriteLine($"Warrior A is called {warriorA.Name}, and has {warriorA.HitPoints}HP");
Console.WriteLine($"Warrior B is called {warriorB.Name}, and has{warriorB.HitPoints}HP");
Console.WriteLine();

while (!(warriorA.Dead || warriorB.Dead))
{
    //Damage for combat round
    int damA = warriorA.DealDamage();
    int damB = warriorB.DealDamage();

    //Warriors take damage
    warriorA.ReceiveDamage(damB);
    warriorB.ReceiveDamage(damA);

    //Output result of round
    Console.WriteLine($"{warriorA.Name} hit {warriorB.Name} for {damA}, {warriorB.Name} now has {warriorB.HitPoints} health");
    Console.WriteLine($"{warriorB.Name} hit {warriorA.Name} for {damB}, {warriorA.Name} now has {warriorA.HitPoints} health \n");


}
if (warriorA.Dead && !warriorB.Dead) Console.WriteLine(warriorB.Name + " is victorious!");
else if (!warriorA.Dead && warriorB.Dead) Console.WriteLine(warriorA.Name + " is victorious!");
else Console.WriteLine("It's a draw");
