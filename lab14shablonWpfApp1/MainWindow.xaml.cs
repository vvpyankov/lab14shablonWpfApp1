using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace lab14shablonWpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // public List<Problem> problems;
        public ObservableCollection <Problem> problems;
        public MainWindow()
        {
            InitializeComponent();
           // problems = new List<Problem>();
            problems = new ObservableCollection<Problem>();
            problems.Add(new Problem()
            {
                ProblemName = "Task # 1",
                Description = "To do my Homework",
                Priority = 2,
                ProblemType = ProblemTypes.Work
            });
            problems.Add(new Problem()
            {
                ProblemName = "Task # 2",
                Description = "To spray flowers",
                Priority = 1,
                ProblemType = ProblemTypes.Home
            });
            problems.Add(new Problem()
            {
                ProblemName = "Task # 3",
                Description = "To cook dinner",
                Priority = 1,
                ProblemType = ProblemTypes.Home
            });
            listBox.ItemsSource = problems;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            problems.Add(new Problem()
            {
                ProblemName = "Task # 4",
                Description = "To drink coffee",
                Priority = 1,
                ProblemType = ProblemTypes.Home
            });
        }
    }
}
