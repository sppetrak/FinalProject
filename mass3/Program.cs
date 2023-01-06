Console.WriteLine("Введите 5 строк массива через пробел: ");
string[] array1 = new string[5];
array1 = Console.ReadLine()!.Split( ); 

string[] array2 = new string[array1.Length];


void stringlenght(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
stringlenght(array1, array2);
PrintArray(array2);