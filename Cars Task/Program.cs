namespace Cars_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isContinue = true;
            Tesla s = new Tesla("Z");
            do
            {
                Console.WriteLine(@"1. Drive
2. MaxSpeed
3. Exit");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        s.Drive();
                        break;
                    case 2:
                        s.MaxSpeed();
                        break;
                    case 3:
                        isContinue = false;
                        break;
                }
            } while (isContinue);
            Console.WriteLine(s.Battery);
        }
    }

}
