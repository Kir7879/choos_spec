static void Choos_spec()
{
    Console.Write("Введите количество строк, которые хотите ввести: ");
    int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
    string[] strs = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)

    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите строку №{0}:\r\n    ", i + 1);
        strs[i] = Console.ReadLine(); //Заполняем его
        strs[i] = strs[i].Substring(0, 3);
    }
    Console.WriteLine("Выводим массив по-строчно из первых трех символов строки:");
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(strs[i]);
        }
    }
    Console.WriteLine("Нажмите [Enter] для выхода из программы");
    Console.ReadLine();
}

Choos_spec();




