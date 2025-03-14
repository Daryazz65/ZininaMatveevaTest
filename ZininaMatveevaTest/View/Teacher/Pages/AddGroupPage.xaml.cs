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
using ZininaMatveevaTest.Model;

namespace ZininaMatveevaTest.View.Teacher.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddGroupPage.xaml
    /// </summary>
    public partial class AddGroupPage : Page
    {
        private static ZininaMatveevaTestEntities _context = App.GetContext();

        public AddGroupPage()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(AddTb.Text))
            {
                Group newGroup = new Group()
                {
                    Name = AddTb.Text,
                };
                _context.Group.Add(newGroup);
                _context.SaveChanges();
                MessageBox.Show("Группа добавлена.");
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
