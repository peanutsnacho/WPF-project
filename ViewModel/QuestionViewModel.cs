using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class QuestionViewModel : INotifyPropertyChanged
    {
        private IQuestion _question;
        
        public QuestionViewModel(IQuestion question)
        {
            _question = question;
            Validate();
        }

        public int QuestionID
        {
            get { return _question.QuestionID; }
            set { _question.QuestionID = value; RaisePropertyChanged("QestionID"); }
        }

        public string Text
        {
            get { return _question.Text; }
            set { _question.Text = value; RaisePropertyChanged("Text"); }
        }

        public int Points
        {
            get { return _question.Points; }
            set { _question.Points = value; RaisePropertyChanged("Points"); }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                Validate();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Validate()
        {

        }
    }
}
