int[] RunningSum(int[] nums)
{
    int[] sumArray = new int[nums.Length];
    var sum = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        sum += nums[i];
        sumArray[i] = sum;
    }

    return sumArray;
}

Array.ForEach(RunningSum(new[] { 1, 2, 3, 4 }), Console.WriteLine);