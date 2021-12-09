using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringRPS
{
    class Choices
    {
        public Choices()
        {
            Random randNum = new Random();
            int computerGuess = randNum.Next(1, 4);
        }
    }
}
