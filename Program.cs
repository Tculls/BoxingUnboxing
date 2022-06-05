namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> stuffs = new List<object>();
            stuffs.Add(7);
            stuffs.Add(28);
            stuffs.Add(-1);
            stuffs.Add(true);
            stuffs.Add("chair");

            int sum = 0;

            foreach (var stuff in stuffs)
            {
                Console.WriteLine(stuff);

                if (stuff is int)
                {
                    sum += (int)stuff;
                }
            }
            Console.WriteLine(sum);
        }
    }
}