/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
  либо задать на старте выполнения алгоритма. При решении
 не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/
 
    {
        // Исходный массив строк задан на старте
        string[] inputArray = { "Hello", "2", "world", ":-)", "yes", "no", "1234", "cat" };
        
        // Вызываем метод для получения нового массива с нужными строками
        string[] resultArray = GetStringsThreeChars(inputArray);
        
        // Выводим результат
        Console.WriteLine("Новый массив строк, длина которых меньше или равна 3 символам:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] GetStringsThreeChars(string[] array)
    {
        // Сначала определим, сколько строк удовлетворяют условию
        int count = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }
        
        // Создаем новый массив нужного размера
        string[] result = new string[count];
        
        // Заполняем новый массив строками, которые удовлетворяют условию
        int index = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }
        
        return result;
    }

