using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
using ZininaMatveevaTest.Model;

namespace ZininaMatveevaTest.View.Teacher.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddStudentPage.xaml
    /// </summary>
    public partial class AddStudentPage : Page
    {
        private static ZininaMatveevaTestEntities _context = App.GetContext();
        public AddStudentPage()
        {
            InitializeComponent();
            AddCmb.ItemsSource = _context.Group.ToList();
            AddCmb.DisplayMemberPath = "Name";
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(AddTb.Text) && AddCmb.SelectedItem != null)
            {
                Student newStudent = new Student()
                {
                    Name = AddTb.Text,
                    Group = AddCmb.SelectedItem as Group
                };
                _context.Student.Add(newStudent);
                _context.SaveChanges();
                MessageBox.Show("Cтудент добавлен.");
            }
            else
            {
                MessageBox.Show("Не все данные были введены!");
            }
        }

        private void GoOutBtn_Click(object sender, RoutedEventArgs e)
        {
            TeacherMainPage teacherMainPage = new TeacherMainPage();
            MenuFrame.Navigate(teacherMainPage);
        }
    }
}
