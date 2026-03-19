// 1
// 21
// 321
// 4321

public class pattern11
{
      public static void Main(string[] args)
    {
        int n=5;
        for(int i = 0; i < n; i++)
        {
            for(int j = i + 1; j > 0; j--)
            {
                Console.Write(j + "");
            }
            Console.WriteLine();
        }
    }

}