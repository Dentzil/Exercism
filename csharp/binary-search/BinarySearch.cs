namespace Exercise_binary_search
{
    public static class BinarySearch
    {
        public static int Search(int[] input, int target)
        {
            if (input.Length == 0 || target < input[0] || target > input[input.Length - 1])
            {
                return -1;
            }

            int first = 0;
            int last = input.Length;

            while (first < last)
            {
                int mid = first + (last - first) / 2;

                if (target <= input[mid])
                {
                    last = mid;
                }
                else
                {
                    first = mid + 1;
                }
            }

            return input[last] == target ? last : -1;
        }
    }
}
