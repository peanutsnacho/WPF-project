using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Answer : IAnswer
    {
        private int _answerID;
        private string _text;

        public int AnswerID
        {
            get
            {
                return _answerID;
            }

            set
            {
                _answerID = value;
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
    }
}
