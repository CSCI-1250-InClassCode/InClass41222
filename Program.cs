Weapon sword = new Weapon();
Weapon sword1 = new Weapon();

System.Console.WriteLine($"My weapon's name is {sword.GetName()} and it has a damage rating of {sword.GetDamage()}!");

Console.Write($"Please enter your Ninja's name!");
string name = Console.ReadLine();

Ninja ninja1 = new Ninja(name);
ninja1.SetWeapon(sword);

Ninja ninja2 = new Ninja("Mathew");
ninja2.SetWeapon(sword1);

GetStatus(ninja1);
GetStatus(ninja2);

Console.Write($"Ninja 1 took {ninja1.TakeDamage(ninja2.BigOleChop())} damage.");

GetStatus(ninja1);

Console.Write($"Ninja 2 took {ninja2.TakeDamage(ninja1.BigOleChop())} damage.");

GetStatus(ninja2);







static void GetStatus(Ninja ninja)
{
    System.Console.Write($"\n\nName: {ninja.GetName()}"
                    +$"\nHealth: {ninja.GetCurrentHealth()} / {ninja.GetMaxHealth()}"
                    +$"\nPower: {Math.Round(ninja.GetPower() * 100, 2)}%"
                    +$"\nEvil: {ninja.IsEvil()}"
                    +$"\nWeapon Name: {ninja.GetWeapon().GetName()}"
                    +$"\nWeapon Damage: {ninja.GetWeapon().GetDamage()}\n\n");
}