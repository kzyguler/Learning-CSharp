int health = 70;
int coin = 40;
bool key  = true;

if (health <= 0)
{
    Console.WriteLine("You're dead.");
}
else if (coin <= 30)
{
    Console.WriteLine("You need more coin.");
}
else if (!key)
{
    Console.WriteLine("You need key to enter here.");
}
else
{
    Console.WriteLine("You used the key and entered the room.");
}