// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и 
//предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6] -> 36 21

class Program
{
    static void Main (string [] args)
    {     
        int [] array = {12,79,123,14,8,11,95};
        PrintArray(array);
        Console.WriteLine(" ");

        Console.Write("Введите колличество чисел: ");
        int U = Convert.ToInt32(Console.ReadLine());
        int n =U-1;
        int t = 0; 
        int result = 0;
            
         for (int i = 0; i <=array.Length/2   ; i++)
         {
            if (array[i] > array.Length/2 )
            {
              result = (array[n] * array[t]) ; 
            } 
            n = n -1;
            t =t+1;
            Console.WriteLine(result);   
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

