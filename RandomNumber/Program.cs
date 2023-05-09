using System.Runtime.ExceptionServices;

Random rnd = new Random();

int randomSum = 0;  

for (int i = 0; i < 3; i++)
{
    int myRandomNum = rnd.Next(0, 11); // 0 - 10
    randomSum = randomSum + myRandomNum;    
    Console.WriteLine($"My random number is {myRandomNum}");
}

Console.WriteLine($"My random sum total is {randomSum}");