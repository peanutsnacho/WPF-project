using CORE;
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
    public class TestListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<TestViewModel> _tests;
        private IDAO _dao;
        private ListCollectionView _view;
        private TestViewModel _selectedTest;
        private RelayCommand _saveTests;
        private RelayCommand _addNewTestToList;
        private RelayCommand _deleteTestFromList;
        private QuestionListViewModel _questionListViewModel;

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public TestListViewModel()
        {
            _tests = new ObservableCollection<TestViewModel>();
            _dao = new DAO.DAO();
            _view = (ListCollectionView)CollectionViewSource.GetDefaultView(_tests);
            _saveTests = new RelayCommand(param => this.SaveSelectedTest());
            _addNewTestToList = new RelayCommand(param => this.AddTestToList());
            _deleteTestFromList = new RelayCommand(param => this.DeleteTest());
            GetAllTests();            
        }

        private void DeleteTest()
        {
            if (SelectedTest == null)
                return;

            var item = _tests.First(p => p.TestID == SelectedTest.TestID);
            if (item != null)
            {
                _tests.Remove(item);
            }
        }

        private void AddTestToList()
        {
            ITest test = _dao.CreateNewTest();
            TestViewModel tvm = new TestViewModel(test);
            //_dao.AddNewTest(test);
            Tests.Add(tvm);
            SelectedTest = tvm;
        }

        private void SaveSelectedTest()
        {
            var item = _tests.First(p => p.TestID == SelectedTest.TestID);
            if (item == null){
                _tests.Add(SelectedTest); //save to DAO here
            } else
            {
                item = SelectedTest;
            }
        }

        private bool CanSaveTest()
        {
            if (SelectedTest == null)
                return false;
            return true;
        }

        public void GetAllTests()
        {
            foreach (var t in _dao.GetAllTests())
            {
                _tests.Add(new TestViewModel(t));
            }
        }

        public ObservableCollection<TestViewModel> Tests
        {
            get { return _tests; }
            set { _tests = value; RaisePropertyChanged("Tests"); }
        }

        public TestViewModel SelectedTest
        {
            get { return _selectedTest; }
            set
            {
                _selectedTest = value;
                RaisePropertyChanged("SelectedTest");
                QuestionListViewModel = new QuestionListViewModel(SelectedTest);
            }
        }

        public RelayCommand SaveTests
        {
            get { return _saveTests; }
            set { _saveTests = value; }
        }

        public RelayCommand AddNewTestToList
        {
            get { return _addNewTestToList; }
            set { _addNewTestToList = value; }
        }

        public RelayCommand DeleteTestFromList
        {
            get { return _deleteTestFromList; }
            set { _deleteTestFromList = value; }
        }

        public QuestionListViewModel QuestionListViewModel
        {
            get { return _questionListViewModel; }
            set { _questionListViewModel = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
