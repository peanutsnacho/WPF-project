using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IQuestion
    {
        int QuestionID { get; }
        string Text { get; set; }
        int Points { get; set; }
        IEnumerable<IAnswer> Answers { get; set; }
        IEnumerable<IAnswer> CorrectAnswers { get; set; }
    }
}
