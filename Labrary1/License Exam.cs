using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrary1
{
    public class License_Exam
    {
        int count = 0;
        private string[] answers = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };
        public int totalCorrectAnswer(string[] userAnswer) {
            for (int i = 0; i < answers.Length; i++)
            {
                for (int j = 0; j < userAnswer.Length; j++) { 
                    if(i==j && answers[i].Equals(userAnswer[j]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
