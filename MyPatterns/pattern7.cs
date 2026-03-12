// 12345
// 2345
// 345
// 45
// 5


public class pattern7
{
    public static void Main(string[] args)
    {
        int n=5;
    
        for(int i = 0; i < n; i++)
        {
               
            for(int j = i+1; j <= n ; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}