

static void First()
{
    int[] array = new int[4];
    var random = new Random();
    {
        for (int i = 0; i < array.Length; i++)
        {
        array[i] = random.Next(100, 1000);
        }
    }
    int count = array.Count(x => x % 2 == 0);
    Console.WriteLine("Задача 34: Количество чётных чисел в массиве: " + count);
}

First();

static void Second()
{
    int[] array = new int[4];
    var random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100);
    }

    int sum = array.Where((x, i) => i % 2 != 0).Sum();
     Console.WriteLine("Задача 36: Сумму элементов стоящих на нечетных позициях: " + sum);
}

Second();

static void Three()
{
    double[] array = { 3.0, 7.0, 22.0, 2.0, 78.0 };
    double max = array.Max();
    double min = array.Min();

    double diff = max - min;
    Console.WriteLine("Задача 38: Разница между максимальным и минимальным элементом массива: " + diff);
}

Three();