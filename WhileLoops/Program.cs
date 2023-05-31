Random rnd = new Random();

int cpuRandom;

bool loopActive = true;
cpuRandom = rnd.Next(1, 21); //Tõstsin loopist välja, et number püsiks sama ja seda oleks võimalik lõpuks ära arvata.

while (loopActive)
{
    Console.WriteLine("Enter your guess (1-20):");
    //Console.WriteLine($"Current value = {cpuRandom}");

    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Correct! You won!");
        loopActive = false;
    }
    else
    {
        Console.WriteLine("Incorrect. Try again.");
    }
}
Console.WriteLine("Goodbye.");