using CORE;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO : IDAO
    {
        private List<ITest> _tests;

        public DAO()
        {
            Answer answer0 = new Answer();
            answer0.AnswerID = 0;
            answer0.Text = "This is answer 0";

            Answer answer1 = new Answer();
            answer1.AnswerID = 1;
            answer1.Text = "This is answer 1";

            Answer answer2 = new Answer();
            answer2.AnswerID = 2;
            answer2.Text = "This is answer 2";

            Answer answer3 = new Answer();
            answer3.AnswerID = 3;
            answer3.Text = "This is answer 3";

            Answer answer4 = new Answer();
            answer4.AnswerID = 4;
            answer4.Text = "This is answer 4";

            Question question0 = new Question();
            question0.QuestionID = 0;
            question0.Text = "This is question 0";
            question0.Points = 5;
            question0.Answers = new List<Answer>();
            question0.AddAnswer(answer0);
            question0.AddAnswer(answer1);

            Question question1 = new Question();
            question1.QuestionID = 1;
            question1.Text = "This is question 1";
            question1.Points = 10;
            question1.Answers = new List<Answer>();
            question1.AddAnswer(answer2);
            question1.AddAnswer(answer3);
            question1.AddAnswer(answer4);

            Test test0 = new Test();
            test0.TestID = 0;
            test0.Name = "Test 0";
            test0.HasMultipleAnswers = true;
            test0.GradingSystem = Grading.FullAnswerPositivePoints;
            test0.Duration = new TimeSpan(0, 15, 0);
            test0.Questions = new List<Question>();
            test0.AddQuestion(question0);
            test0.AddQuestion(question1);

            _tests = new List<ITest>();
            _tests.Add(test0);

        }

        public void AddNewTest(ITest test)
        {
            _tests.Add(test);
        }

        public IEnumerable<ITest> getAllTests()
        {
            return _tests;
        }
    }
}
