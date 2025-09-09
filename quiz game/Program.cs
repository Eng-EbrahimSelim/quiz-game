using System.Threading.Tasks.Sources;

namespace quiz_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions = new string[3] 
            {
                "1.what is the capital of italy ?",
                "2.what is the red planet ?",
                "3.what is the biggest animal ?"
            };
            string[] answers = new string[3]
            {
                "roma",
                "mars",
                "blue whale"
            };
            int score = 0;

            Console.WriteLine("welcome to quiz game");
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                string userAnswer=Console.ReadLine();
                try
                {
                    bool result = correctAnswer(userAnswer, answers[i]);
                    if (result == true)
                    {
                        Console.WriteLine("correct answer !");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"sorry, wrong answer . the correct answer is {answers[i]}");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    i--;
                }
               


            }
            Console.WriteLine($"your score is {score} of 3");

        }
        private static bool correctAnswer(string userInput,string answer)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                throw new Exception("answer cannot be empty!");
            }
            if (userInput==answer)
            {
              return true;
              
            }
            else
            {
                return false;
            }
        }
    }
}
