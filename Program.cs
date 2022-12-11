namespace Periods_commas_and_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read file
            Console.WriteLine("Please enter the path to the file you wish to read (without quotation marks).");
            string text = File.ReadAllText(Console.ReadLine());
            
            // Count periods
            int periodCount = text.Count(x => x == '.');
            
            // Count commas
            int commaCount = text.Count(x => x == ',');
            
            // Count whole numbers
            int numberCount = 0;
            var splitText = text.Split(' ', '.', ',');
            for (int i = 0; i < splitText.Length; i++)
            {
                int n;
                bool isNumeric = int.TryParse(splitText[i], out n);

                if (isNumeric)
                {
                    numberCount++;
                }
            }
            // Print results
            Console.WriteLine("There are {0} periods, {1} commas, and {2} numbers in the text.", periodCount, commaCount, numberCount);
            Console.ReadLine();
        }
    }
}