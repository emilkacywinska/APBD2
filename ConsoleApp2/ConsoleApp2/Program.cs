int[] arr = new[] { 11, 2, 3, 4, 5, 6, 6, 10};
double max = GetMax(arr);
Console.WriteLine(("Max value is " + max));


static double GetMax(int[] arr)
{
    int temp=arr[0];
    foreach (var num in arr)
    {
        if (num > temp)
        {
            temp = num;
        }
    }
    
    return temp;
}