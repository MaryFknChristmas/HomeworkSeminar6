Console.WriteLine("Введите количество чисел");
int count = Convert.ToInt32(Console.ReadLine());
PositiveNumbers(count);

void PositiveNumbers(int cou)
{
    int positiveCount = 0;
    Console.WriteLine("Введите числа");
    for (int i = 0; i < cou; i++)
    {
       int number = Convert.ToInt32(Console.ReadLine());
       if (number > 0)
        {
            positiveCount += 1;
        }
    }
    Console.WriteLine("Количество положительных чисел равно: " + positiveCount);
}