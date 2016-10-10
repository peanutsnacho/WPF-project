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

namespace UI.Pages
{
    /// <summary>
    /// Interaction logic for QuestionsEditorView.xaml
    /// </summary>
    public partial class QuestionsEditorView : Page
    {
        public QuestionsEditorView()
        {
            InitializeComponent();
        }

        void NavigationService_Navigated(object sender, NavigationEventArgs e)
        {
            var tvm = (TestViewModel)e.ExtraData;
            QuestionListViewModel QuestionListVM = new QuestionListViewModel(tvm.Questions);
            DataContext = QuestionListVM;
        }
    }
}
