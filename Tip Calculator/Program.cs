namespace Tip_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tip Calculator");

            String choice;

            //start loop
            do
            {
                Console.Write("Enter cost of meal: ");
                decimal mealCost = decimal.Parse(Console.ReadLine());

                decimal tip = mealCost * .15m;
                decimal total = mealCost + tip;

                //format
                string formattedTotal = total.ToString("C2");
                string formattedTip = tip.ToString("C2");

                Console.WriteLine($"Tip amount: {formattedTip}");
                Console.WriteLine($"TOtal amount: {formattedTotal}");

                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
