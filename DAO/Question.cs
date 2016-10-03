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
                _points = value;
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
