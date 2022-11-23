void multi(int a, int b) {
    int indexa = 1;
    int result = a;
    
    while (indexa < b)
    {
        result = result * a;
        
        indexa++;
    }
   Console.WriteLine(result);
}
Console.WriteLine("Напишите 2 числа: ");
int enter1 = Convert.ToInt32(Console.ReadLine());
int enter2 = Convert.ToInt32(Console.ReadLine());
multi(enter1, enter2);