void SortSelection(int[] collection)
{
    int size = collection.Length;
    for (int i =0; i < size -1; i++)
    {
        int posMin = i;
        for (int j = i+1; j < size; j++)
        {
            if (collection[j]<collection[posMin]) posMin = j;
        }
        int temp = collection [i];
        collection [i] = collection[posMin];
        collection[posMin] = temp;
    }

}

int[] array = {7, 6, 3, 4, 5, 1, 2, 3};

Console.WriteLine($"[{String.Join(',', array)}]");
SortSelection(array);
Console.WriteLine($"[{String.Join(',', array)}]");
