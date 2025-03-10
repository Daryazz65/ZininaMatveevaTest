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
using System.Windows.Shapes;
using ZininaMatveevaTest.AppData;
using ZininaMatveevaTest.View.Teacher.Pages;

namespace ZininaMatveevaTest.View.Teacher.Windows
{
    /// <summary>
    /// Логика взаимодействия для TeacherMainWindow.xaml
    /// </summary>
    public partial class TeacherMainWindow : Window
    {
        public TeacherMainWindow()
        {
            InitializeComponent();
            TeacherMainPage teacherMainPage = new TeacherMainPage();
            TeacherMainFrame.Navigate(teacherMainPage);
            FrameHelper.selectedFrame = TeacherMainFrame;
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordTb.Text == "123")
            {
                TeacherMainPage teacherMainPage = new TeacherMainPage();
                TeacherMainFrame.Navigate(teacherMainPage);
            }
            else
            {
                MessageBox.Show("Пароль неверный!");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
        }
    }
}
