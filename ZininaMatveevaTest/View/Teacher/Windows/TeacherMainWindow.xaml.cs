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
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordTb.Text == "123")
            {
                TeacherWindow teacherWindow = new TeacherWindow();
                teacherWindow.Show();
                Close();
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
