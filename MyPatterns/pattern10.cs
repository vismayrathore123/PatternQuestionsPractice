public class pattern10
{
    public static void Main(string[] args)
    {
        int n=4;
        for(int i = 0; i < n; i++)
        {
            char ch = (char)('A' + i);
            for(int j = 0; j < i+1; j++)
            {
                Console.Write(ch);
               
            }
            Console.WriteLine();
        }
    }
}