namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ModernAppliances modernAppliances = new MyModernAppliances();

            while (option != ModernAppliances.Options.SaveExit)
            {
                modernAppliances.DisplayMenu();

                char option = char.Parse(Console.ReadLine());

                switch (option)
                {
                    case '1':
                        {
                            modernAppliances.Checkout();
                            break;
                        }
                    case '2':
                        {
                            modernAppliances.Find();
                            break;
                        }
                    case '3':
                        {
                            modernAppliances.DisplayType();
                            break;
                        }

                    case '4':
                        {
                            modernAppliances.RandomList();
                            break;
                        }
                    case '5':
                        {
                            modernAppliances.Save();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid option entered. Please try again.");
                            break;
                        }
                }
            }
        }
    }
}
