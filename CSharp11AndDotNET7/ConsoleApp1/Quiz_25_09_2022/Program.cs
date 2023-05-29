using Quiz_25_09_2022;

WriteLine("Hallo World");

GeographyQestions.SetQuizzQuestions();

foreach (Question questions in GeographyQestions.Questions)
{
   WriteLine(questions.Text);
    for (int i = 0; i < questions.Options.Length; i++)
    {
        WriteLine($"{i = 1}. {questions.Options[i]}");
    }
    string userAnswer = ReadLine();

    if (userAnswer == questions.Answer)
    {
        WriteLine("You quessed right!");
    }
    else
    {
        WriteLine($"The right anwer was {questions.Answer}");
    }
}

bool newGame = ReadLine().ToLower() == "yew";

if (newGame)
{

}