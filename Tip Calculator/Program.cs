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
                //array  of tip percents
                decimal[] percentages = { 0.15m, 0.20m, 0.25m };

                foreach (var percent in percentages)
                {
                    decimal tip = mealCost * percent;
                    decimal total = mealCost + tip;

                    //format them
                    string formattedTotal = total.ToString("C2");
                    string formattedTip = tip.ToString("C2");
                   
                 //Displays the results,casts the percent so it appears as an integer, and uses \n for newlines for efficiency instead of having to write several WriteLines
                    Console.WriteLine($"\n{(int)(percent*100)}%\nTip: {formattedTip}\nTotal: {formattedTotal}");
                }

                Console.Write("Would you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
