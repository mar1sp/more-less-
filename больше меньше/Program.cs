Random random = new Random();

int secretNumber = random.Next(1, 101);

Console.WriteLine("Это игра больше-меньше я загадал число от 1 до 100!");
Console.WriteLine("Попробуй угадать какое!");
Console.WriteLine("Твоя попытка:");

int guess = 0;
int attempts = 0;

do
{ 
    guess = int.Parse(Console.ReadLine());
    
        while (guess <= 0 || guess > 100)
        {
            Console.WriteLine("Неверное число");
            guess = int.Parse(Console.ReadLine());
        }

        attempts = attempts + 1;

        if (guess > secretNumber)
        {
            Console.WriteLine("Меньше");
        }
        else if (guess < secretNumber)
        {
            Console.WriteLine("Больше");
        }
    
}
while (guess != secretNumber);

Console.WriteLine("Угадал!"); 
Console.WriteLine($"Количество попыток: {attempts}");


