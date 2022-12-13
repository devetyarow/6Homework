//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


// и как это делать? Т_Т
// 


using System;
 
public class Example
{
    public static void Main()
    {
        int[] arr = { 5, 4, 7, 2, 9 }; // тут нужный нам массив
 
        int[] copy = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++) {
            copy[i] = arr[i];
        }
 
        Console.WriteLine(String.Join(", ", copy));        // 4, 7, 2 и так далее

    }
}