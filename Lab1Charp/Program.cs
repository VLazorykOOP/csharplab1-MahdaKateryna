
internal class Program
{
    private static void Main(string[] args)
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Виберіть завдання:");
        Console.WriteLine("1. Обчислення гіпотенузи прямокутного трикутника");
        Console.WriteLine("2. Перевірка розв'язку квадратного рівняння");
        Console.WriteLine("3. Визначення чи належить точка графіку");
        Console.WriteLine("4. Визначення назви поточного місяця");
        Console.WriteLine("5. Обчислення різниці двох дійсних чисел");
        Console.WriteLine("6. Обчислення виразу x*y+(x+y*y+3)/(x*x+5)");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CalculateHypotenuse1();
                break;
            case 2:
                CheckQuadraticEquation2();
                break;
            case 3:
                Grafic3();
                break;
            case 4:
                DetermineCurrentMonth4();
                break;
            case 5:
                CalculateDifference5();
                break;
            case 6:
                CalculateExpression6();
                break;
            default:
                Console.WriteLine("Некоректний вибір.");
                break;
        }
    }

    static void CalculateHypotenuse1()
    {
        Console.WriteLine("Введіть довжину першого катета:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введіть довжину другого катета:");
        double b = double.Parse(Console.ReadLine());

        double c = Math.Sqrt(a * a + b * b);
        Console.WriteLine($"Гіпотенуза прямокутного трикутника дорівнює: {c}");
    }

    static void CheckQuadraticEquation2()
    {
        Console.WriteLine("Введіть значення a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введіть значення b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Введіть значення c:");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;
        if (discriminant > 0)
        {
            Console.WriteLine("Рівняння має два різних розв'язки.");
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("Рівняння має один розв'язок.");
        }
        else
        {
            Console.WriteLine("Рівняння не має розв'язків.");
        }
    }


    static void Grafic3()
    {
        Console.WriteLine("Введіть значення x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Введіть значення y:");
        double y = double.Parse(Console.ReadLine());

        double res = x*x+y*y;
        if (res < 15*15 || res > 25*25 )
        {
            Console.WriteLine("Так.");
        }
        else if (res == 15*15 || res == 25*25)
        {
            Console.WriteLine("На межі.");
        }
        else
        {
            Console.WriteLine("Ні.");
        }
    }


    static void DetermineCurrentMonth4()
    {
        Console.WriteLine("Введіть кількість днів, які пройшли з 1 січня 1990 року:");
        int days = int.Parse(Console.ReadLine());

        DateTime date = new DateTime(1990, 1, 1).AddDays(days);
        Console.WriteLine($"Поточний місяць: {date.ToString("MMMM")}");
    }

    static void CalculateDifference5()
    {
        Console.WriteLine("Введіть перше число:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Введіть друге число:");
        double secondNumber = double.Parse(Console.ReadLine());

        double difference = firstNumber - secondNumber;
        Console.WriteLine($"Різниця між числами: {difference}");
    }

    static void CalculateExpression6()
    {
        Console.WriteLine("Введіть значення x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Введіть значення y:");
        double y = double.Parse(Console.ReadLine());

        double result = x * y + (x + y * y + 3) / (x * x + 5);
        Console.WriteLine($"Результат виразу: {result}");
    }
}
