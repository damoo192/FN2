using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_25_09_2022
{
    public class GeographyQestions
    {

        public static Question[] Questions { get; private set; }

        public static void SetQuizzQuestions()
        {
            Questions = new Question[]
            {
                new Question("What is the name of the tallest mountain in the world?",
                "Mount Everest",
                new string[] {"Mount Everest","Himalayas","Alps","Lhotse"}),
                new Question(
                    "What are the names of the seven continents of the world?",
                    "Asia Africa North America South America Antarctica Europe Australia",
                    null)
            };
        }
    }
}
