using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_25_09_2022
{
    public class Question
    {
        public string Text {get; private set; }

        public Question(string text, string answer, string[]? options)
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
            Answer = answer ?? throw new ArgumentNullException(nameof(answer));
            Options = options ?? new string[0];
        }

        public string[] Options { get; private set; } 
        
        public string Answer { get; private set; }
    }
}
