
// See https://aka.ms/new-console-template for more information
int playerHp = 40;
int enermyHp = 20;

int playerAttack;
int enermyAttack;

int healAmount = 5;

Random random = new Random();

while (playerHp > 0 && enermyHp > 0)
{
    // Player turn
    Console.WriteLine("Player Turn");
    Console.WriteLine("Player Hp - " + playerHp + "\nEnermy Hp - " + enermyHp);
    Console.WriteLine("Enter 'a' to attack or 'h' to heal.");

    string choice = Console.ReadLine();

    if (choice == "a")
    {
        playerAttack = random.Next(1,10);
        enermyHp -= playerAttack;
        Console.WriteLine("Player attack deals " + playerAttack + " damage!");
    }
    else
    {
        playerHp += healAmount;
        Console.WriteLine("Player restores " + healAmount + " health points");
    }

    // Enermy turn

    if (enermyHp > 0)
    {
        Console.WriteLine("Enermy Turn");
        Console.WriteLine("Player Hp - " + playerHp + "\nEnermy Hp - " + enermyHp);

        int enermyChoice = random.Next(0, 1);

        if (enermyChoice == 0)
        {
            enermyAttack = random.Next(1,4);
            playerHp -= enermyAttack;
            Console.WriteLine("Enermy attack deals " + enermyAttack + " damage!");
        }

        else
        {
            enermyHp += healAmount;
            Console.WriteLine("Enermy has healed " + healAmount + " health points");
        }

    }
    if (enermyHp is <= 0)
        Console.WriteLine("You have Won!");

    if (playerHp is <= 0)
    {
        Console.WriteLine("You lose!");
    }
}
