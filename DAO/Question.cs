using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Question : IQuestion
    {
        private int _questionID;
        private string _text;
        private int _points;
        private List<IAnswer> _answers;
        private List<IAnswer> _correctAnswers;
        
        public void AddAnswer(IAnswer answer)
        {
            _answers.Add(answer);
        }

        public int RemoveAnswer(IAnswer answer)
        {
            if (_answers.Contains(answer))
            {
                IAnswer tmp = _answers.Find(a => a.AnswerID == answer.AnswerID);
                _answers.Remove(tmp);
                if (_correctAnswers.Contains(answer))
                {
                    tmp = _correctAnswers.Find(a => a.AnswerID == answer.AnswerID);
                    _correctAnswers.Remove(tmp);
                }
                return 0;
            }
            return -1;           
        }

        public int QuestionID
        {
            get
            {
                return _questionID;
            }

            set
            {
                _questionID = value;
            }
        }

        public string Text
        {
            get
            {
                return _text;
            }

            set
            {
                _text = value;
            }
        }

        public int Points
        {
            get
            {
                return _points;
            }

            set
            {
                if (value > 0)
                {
                    _points = value;
                }
            }
        }

        public IEnumerable<IAnswer> Answers
        {
            get
            {
                return _answers;
            }

            set
            {
                _answers = value.ToList<IAnswer>();
            }
        }

        public IEnumerable<IAnswer> CorrectAnswers
        {
            get
            {
                return _correctAnswers;
            }

            set
            {
                _correctAnswers = value.ToList<IAnswer>();
            }
        }
    }
}
