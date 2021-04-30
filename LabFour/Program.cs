using System;

namespace LabFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter the Number of Scores: ");
            int numberOfScores = int.Parse(Console.ReadLine());
            Calculator(numberOfScores);
        }

        public static void Calculator(int numberOfScores)
        {
            double[] MarksOfStudents = new double[numberOfScores];
            double cgpa = 0d, total = 0d, percentage = 0d;

            // getting the scores from user and storing it
            for (int i = 0; i < numberOfScores; i++)
            {
                Console.Write($"Enter number {i + 1} Score: ");
                string scoreInput = Console.ReadLine();

                if (!double.TryParse(scoreInput, out MarksOfStudents[i]))
                {
                    // when the user input any other thing than a number
                    Console.WriteLine($"'{scoreInput}' is not a valid number.");

                    // Don't increase the array index
                    i--;
                }
            }

            Console.Write($"Your Scores are: ");
            foreach (var score in MarksOfStudents)
            {
                Console.Write($"{score} ");
            }

            Console.WriteLine();
            Console.WriteLine("Are Scores Correct? ");
            Console.WriteLine("If correct, Enter 'Yes' to continue or 'No' to start again:  ");
            string yesOrNO = Console.ReadLine().ToLower();

            while (yesOrNO != "yes" && yesOrNO != "no")
            {
                Console.WriteLine("Invalid option");
                Console.WriteLine("Please, Are Scores Correct? ");
                Console.WriteLine("If correct, Enter 'Yes' to continue or 'No' to start again :");
                yesOrNO = Console.ReadLine();
            }

            if (yesOrNO == "yes")
            {
                for (int i = 0; i < numberOfScores; i++)
                {
                    MarksOfStudents[i] = MarksOfStudents[i] / 10;
                    total += MarksOfStudents[i];
                }

                cgpa = total / numberOfScores;
                percentage = Math.Round(cgpa * 9.5, 2);
                Console.WriteLine($"Your CGPA is: {cgpa}");
                Console.WriteLine($"The Percentage is: {percentage}");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Please Enter the Number of Scores: ");
                numberOfScores = Convert.ToInt32(Console.ReadLine());
                Calculator(numberOfScores);
            }
        }
    }
}
