// Алгоритм сортировки данных (чисел) по возрастанию
// 6 8 3 2 1 4 5 7 

int[] arr = { 6, 8, 3, 2, 1, 4, 5, 7 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i<count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
PrintArray(arr);

void SelectionSort (int [] array)
{
    for (int i = 0; i<array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j<array.Length; j++)
        {
            if (array [j]<array[minPosition]) minPosition=j;
        }
    
    int temporary = array [i];
    array[i] = array[minPosition];
    array [minPosition] = temporary;
    }
}

SelectionSort(arr);
PrintArray(arr);
