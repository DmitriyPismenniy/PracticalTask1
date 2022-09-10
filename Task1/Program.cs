//Написать программу, которая из имеющегося массива строк формирует массив из 
//строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с 
//клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
//пользоваться коллекциями, лучше обойтись исключительно массивами.

void Task1()
{
    Console.Write("Введите количество требуемых в массиве строк: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] arrstring = new string[size];
    string[] arr2string = new string[size];
    int count = 0;

    for (int i=0; i < size; i++)
    {
        Console.Write($"Введите {i+1} строку массива: ");
        arrstring[i] = Console.ReadLine();
        int length = arrstring[i].Length;
        if (length <= 3)
        {            
            arr2string[count] = arrstring[i];
            count++;            
        }       
    }
    Console.WriteLine("Вы ввели следующий массив: ");
    
    for (int i=0; i < size; i++)
    {
        Console.Write($"{arrstring[i]}, ");        
    }
    Console.WriteLine("\b\b. ");  

    string[] arr3string = new string[count];
    
    for (int i=0; i < count; i++)
    {
        arr3string[i] = arr2string[i];
    }
    Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символам: ");

    for (int i=0; i < count; i++)
    {
        Console.Write($"{arr3string[i]}, ");        
    }
    Console.WriteLine("\b\b. ");
}

Task1();
