using CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModel;

namespace UI
{
    /// <summary>
    /// Interaction logic for EditorMenuPage.xaml
    /// </summary>
    public partial class EditorMenuPage : Page
    {

        private RelayCommand _navigateToDetails;

        public EditorMenuPage()
        {
            InitializeComponent();
            _navigateToDetails = new RelayCommand(param => this.GoToQestionsView());
            var navForward = (Button)this.FindName("NavForward");
            navForward.Command = this.NavigateToDetails;
        }

        private void GoToQestionsView()
        {
            // var Page = (Page)this.FindName("EditorMenuPage");
            //var DataContext = (TestListViewModel)Page.DataContext;
            var curDataContext = (TestListViewModel)this.DataContext;
            var curSelectedTest = curDataContext.SelectedTest;
            NavigationService navService = NavigationService.GetNavigationService(this);
            navService.Navigate(new Pages.QuestionsEditorView(), curSelectedTest);
        }

        public RelayCommand NavigateToDetails
        { get { return _navigateToDetails; } }
    }
}
