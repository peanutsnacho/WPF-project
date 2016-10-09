using CORE;
using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class TestViewModel : INotifyPropertyChanged
    {
        private ITest _test;

        public TestViewModel(ITest test)
        {
            _test = test;
            Validate();
        }

        public int TestID
        {
            get { return _test.TestID; }
            set { _test.TestID = value; RaisePropertyChanged("TestID"); }
        }

        public string Name
        {
            get { return _test.Name; }
            set { _test.Name = value; RaisePropertyChanged("Name"); }
        }

        public bool HasMultipleAnswers
        {
            get { return _test.HasMultipleAnswers; }
            set { _test.HasMultipleAnswers = value; RaisePropertyChanged("HasMultipleAnswers"); }
        }

        public TimeSpan Duration
        {
            get { return _test.Duration; }
            set { _test.Duration = value; RaisePropertyChanged("Duration"); }
        }

        public Grading GradingSystem
        {
            get { return _test.GradingSystem; }
            set { _test.GradingSystem = value; RaisePropertyChanged("GradingSystem"); }
        }

        public IEnumerable<IQuestion> Questions
        {
            get { return _test.Questions; }
            set { _test.Questions = value; }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                Validate();
            }
        }

        private void Validate()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
