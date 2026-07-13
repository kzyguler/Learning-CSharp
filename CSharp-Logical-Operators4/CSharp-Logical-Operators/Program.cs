int health = 100;
bool hasTorch = false;
bool hasNightVision = true;

if (health > 0 && (hasNightVision || hasTorch))
{
    Console.WriteLine("You entered the hidden cave.");
}
else
{
    Console.WriteLine("You cannot enter the hidden cave.");
}