namespace StringCount3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello world";
            char[] b = a.ToCharArray();
            for (int i = b.Length-1 ; i >=0; i--) 
            {
                Console.Write(b[i]);
            }
            




        }
    }
}