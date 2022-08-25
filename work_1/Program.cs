//Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат 
// в отрезке [10,99].

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2] -> 0

// [10, 11, 12, 13, 14] -> 5


class Program
{
    static void Main (string [] args)
    {
        int []array = new int[123];
        FillArray (array);
        PrintArray(array);
        Console.WriteLine(" ");

        
        int start = 10;
        int and =99;
        int count =0;
        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i]<and)&& (array[i]>start))
            count++;
        }
        Console.Write("Количество чисел в диапозоне["+start + ".."+and+"]=[" + count +" ]:");

        static void FillArray(int[]array)
    {
        int length = array.Length;
        int index =0;
        while (index < length)
        {
            array [index] = new Random ().Next (0,123);
            index ++;
        }
    }    
        
    static void PrintArray (int[]array)
    {
        int count = array.Length;
        int position = 0;
        while (position <count)
        {
            Console.Write(array[position]+" ");
            position ++;
        }
        
    }   
    }
}
