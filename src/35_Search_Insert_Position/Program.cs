int SearchInsert(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        if (target <= nums[i])
        {
            return i;
        }
    }
    return nums.Length;
}

Console.WriteLine(SearchInsert([1, 3, 5, 6], 5));