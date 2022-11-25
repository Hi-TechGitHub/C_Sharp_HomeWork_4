// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
int[] array = new int[8];
void CreateArray(int[] arr) 
{
    
   // Random rnd = new Random();
    for (int i = 0; i < 8; i++)
    {
        arr[i] = new Random().Next(0, 51);
        
    }

}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < 8; i++) {

    if (i < 8 - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");

}
CreateArray(array);
PrintArray(array);