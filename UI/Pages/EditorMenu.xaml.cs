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
        private RelayCommand _goToQuestionsView;

        public EditorMenuPage()
        {
            InitializeComponent();
            _goToQuestionsView = new RelayCommand(param => NavigateToQuestions());
            var button = (Button)this.FindName("NavQuestions");
            //button.Command = GoToQuestionsView;
        }

        private void NavigateToQuestions()
        {
            var tvm = ((TestListViewModel)DataContext).SelectedTest;
            NavigationService navService = NavigationService.GetNavigationService(this);
            navService.Navigate(new Pages.QuestionsEditorView(), tvm);
        }

        public RelayCommand GoToQuestionsView
        {
            get { return _goToQuestionsView; }
        }

        private void NavQuestions_Click(object sender, RoutedEventArgs e)
        {
            var tvm = ((TestListViewModel)DataContext).SelectedTest;
            NavigationService navService = NavigationService.GetNavigationService(this);
            navService.Navigate(new Pages.QuestionsEditorView(), tvm);
        }
    }
}
