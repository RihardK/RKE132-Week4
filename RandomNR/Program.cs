Random rnd = new Random();

int randomSum = 0;

for(int i = 0; i < 10; i++)
{
    int userRandomNum = rnd.Next(0, 14001);
    randomSum = randomSum + userRandomNum;
    Console.WriteLine($"My generated value is: {userRandomNum}");
}
Console.WriteLine($"Total of randoms : {randomSum}");