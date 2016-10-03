using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CORE;

namespace DAO
{
    public class Test : ITest
    {
        private int _testID;
        private string _name;
        private bool _hasMultipleAnswers;
        private TimeSpan _duration;
        private Grading _gradingSystem;
        private List<IQuestion> _questions;

        public int TestID
        {
            get
            {
                return _testID;
            }

            set
            {
                _testID = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public bool HasMultipleAnswers
        {
            get
            {
                return _hasMultipleAnswers;
            }

            set
            {
                _hasMultipleAnswers = value;
            }
        }

        public TimeSpan Duration
        {
            get
            {
                return _duration;
            }

            set
            {
                _duration = value;
            }
        }

        public Grading GradingSystem
        {
            get
            {
                return _gradingSystem;
            }

            set
            {
                _gradingSystem = value;
            }
        }

        public IEnumerable<IQuestion> Questions
        {
            get
            {
                return _questions;
            }

            set
            {
                _questions = value.ToList<IQuestion>();
            }
        }
    }
}
