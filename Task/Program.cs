string[] arr = {"123", "hi", "5290", "Daniil", "work", "-5"};

void Check(string[] arr)
{
    int count = 0;
    for(int i = 0; i<arr.Length; i++)
    {
        string number = arr[i];
        if(number.Length<=3)
        {
            count++;
        }
    }

    Console.WriteLine($"Количество строк с менее чем тремя символами: {count}");

    string[] secondArr = new string[count];
    Console.WriteLine("Новый массив: ");

    for(int i = 0; i < arr.Length; i++)
    {
        string number = arr[i];

        if(number.Length <= 3)
        {
            int j = 0;
            secondArr[j] = number;
            Console.WriteLine($"{secondArr[j]}");
            j++;
        }
    }
}

Check(arr);