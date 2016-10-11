using Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ViewModel
{
    public class QuestionListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<QuestionViewModel> _questions;
        private ListCollectionView _view;
        private QuestionViewModel _selectedQuestion;

        public ObservableCollection<QuestionViewModel> Questions
        {
            get { return _questions; }
            set { _questions = value; }
        }

        public QuestionViewModel SelectedQuestion
        {
            get { return _selectedQuestion; }
            set { _selectedQuestion = value; }
        }

        public QuestionListViewModel()
        {
            Questions = new ObservableCollection<QuestionViewModel>();
            _view = (ListCollectionView)CollectionViewSource.GetDefaultView(_questions);
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

