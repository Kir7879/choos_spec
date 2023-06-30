static void Choos_spec()
{
    Console.Write("Введите количество строк, которые хотите ввести: ");
    int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
    string[] strs = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите строку №{0}:\r\n    ", i + 1);
        strs[i] = Console.ReadLine(); //Заполняем его
        //strs[i] = strs[i].Substring(0, 3); (первый вариант, меньше трех символов)
    }
    Console.WriteLine("Выводим массив по-строчно из первых трех символов строки:");
    {
        for (int i = 0; i < n; i++)
        {
            //if (strs[i].Length <= 3) (второй вариант, только строки меньше трех символо)
            //{
            //Console.WriteLine(strs[i].Split().Count(i => i.Length <= 4)); (счет слов кол-во символов меньше четырех)
            Console.WriteLine(String.Join(" ", strs[i].Split().Where(i => i.Length <= 4)));
            //Console.WriteLine(strs[i]);
            //}
        }
    }
    Console.WriteLine("Нажмите [Enter] для выхода из программы");
    Console.ReadLine();
}
Choos_spec();
