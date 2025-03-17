using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для DeleteStudentPage.xaml
    /// </summary>
    public partial class DeleteStudentPage : Page
    {
        private static ZininaMatveevaTestEntities _context = App.GetContext();
        public DeleteStudentPage()
        {
            InitializeComponent();
            UserDG.ItemsSource = _context.Student.ToList();
            GroupCmb.ItemsSource = _context.Group.ToList();
            GroupCmb.DisplayMemberPath = "Name";
        }

        private void PoiskBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GoOutBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PechatBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UserDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
