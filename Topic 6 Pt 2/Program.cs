namespace Topic_6_Pt_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double passingScore = 0.00;
            double failingScore = 0.00;
            double score, percentageOfPassingScores;
            int i = 0;
            string input;
            
            Console.WriteLine("Enter exit if you are done entering scores");

            while (i == 0)
            {
                Console.WriteLine("Enter a score");
                input = Console.ReadLine();

                if (Double.TryParse(input, out score))
                {
                    if (score > 70 && score < 100)
                    {
                        passingScore++;

                    }
                    else if (score > 100)
                    {
                        Console.WriteLine("Invalid score. Please try again.");
                    }
                    else if (score < 70)
                    {
                        failingScore++;
                    }
                }
                else if (input.ToLower() == "exit")
                {
                    i = 1;
                    percentageOfPassingScores = passingScore / (passingScore + failingScore);
                    Console.WriteLine(percentageOfPassingScores);
                    Console.WriteLine(percentageOfPassingScores + "% of the scores are passing");
                }            
            }       
        }
    }
}