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
using ZininaMatveevaTest.View.Teacher.Windows;

namespace ZininaMatveevaTest.View.Teacher.Pages
{
    /// <summary>
    /// Логика взаимодействия для TeacherMainPage.xaml
    /// </summary>
    public partial class TeacherMainPage : Page
    {
        public TeacherMainPage()
        {
            InitializeComponent();
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudentPage addStudentPage = new AddStudentPage();
            MenuFrame.Navigate(addStudentPage);
        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            AddGroupPage addGroupPage = new AddGroupPage();
            MenuFrame.Navigate(addGroupPage);
        }

        private void ListMarkStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            ListStudentPage listStudentPage = new ListStudentPage();
            MenuFrame.Navigate(listStudentPage);
        }

        private void DeleteStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            DeleteStudentPage deleteStudentPage = new DeleteStudentPage();
            MenuFrame.Navigate(deleteStudentPage);
        }

        private void GoOutBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
