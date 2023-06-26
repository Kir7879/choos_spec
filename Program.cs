static void Choos_spec()
{
    Console.Write("Введите количество строк, которые хотите ввести: ");
    int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
    string[] strs = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)

    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите строку №{0}:\r\n    ", i + 1);
        strs[i] = Console.ReadLine(); //Заполняем его
    }
    Console.WriteLine("Выводим массив строк:");
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(strs[i]);
        }
    }

    Console.ReadLine();
}

Choos_spec();




