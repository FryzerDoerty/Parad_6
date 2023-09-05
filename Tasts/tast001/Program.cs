void Main()
{
    int[] sumArr = Array.Empty<int>();

    while (Console.ReadKey().Key != ConsoleKey.Backspace)
    {
        System.Console.WriteLine("Введите элемент массива: ");
        int a = Convert.ToInt32(Console.ReadLine());
        sumArr = sumArr.Append(a).ToArray();
    }
    int[] array = Arr(sumArr);
    System.Console.WriteLine("[" + string.Join(",", array) + "]");
    System.Console.WriteLine("Введите цифру, которую хотите найти: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int rez = Mid(array, n);
    System.Console.WriteLine(rez);
}
int[] Arr(int[] array)
{
    int indx;
    for (int i = 0; i < array.Length; i++)
    {
        indx = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] < array[indx])
            {
                indx = j;
            }
        }
        if (array[indx] == array[i])
        {
            continue;
        }
        int temp = array[i];
        array[i] = array[indx];
        array[indx] = temp;
    }
    return array;
}
int Mid(int[] arr, int n)
{
    //bool f = false;
    int left = 0;
    int right = arr.Length - 1;
    int mid = 0;
    while ((left <= right))
    {
        mid = (left + right) / 2;
        if (n == arr[mid])
        {
            return mid;
        }
        else if (n < arr[mid])
        {
            right = mid - 1;
        }
        else
        {
            left = mid + 1;
        }
    }
    return -1;
}

Main();