using System;

public class BinarySearch
{
    public static int MySqrt(int x)
    {
        if (x < 2) return x;

        int left = 1, right = x / 2;
        int ans = 0;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (mid <= x / mid) // avoid overflow
            {
                ans = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return ans;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(MySqrt(4)); // Output: 2
        Console.WriteLine(MySqrt(8)); // Output: 2
    }
}