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
            GetAllTests();            
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
            set { _selectedTest = value; RaisePropertyChanged("SelectedTest"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
