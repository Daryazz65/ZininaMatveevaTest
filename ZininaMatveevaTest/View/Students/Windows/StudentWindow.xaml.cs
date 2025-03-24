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
using ZininaMatveevaTest.View.Student.Pages;
using ZininaMatveevaTest.View.Teacher.Pages;

namespace ZininaMatveevaTest.View.Student.Windows
{
    /// <summary>
    /// Логика взаимодействия для StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        public StudentWindow()
        {
            InitializeComponent();
            CmbGroup.SelectedValuePath = "ID";
            CmbGroup.DisplayMemberPath = "Name";
            CmbGroup.ItemsSource = ClassConnect._context.Group.ToList();

            CmbStudent.SelectedValuePath = "ID";
            CmbStudent.DisplayMemberPath = "Name";
            CmbStudent.ItemsSource = ClassConnect._context.Student.ToList();

            CmbTest.SelectedValuePath = "ID";
            CmbTest.DisplayMemberPath = "Name";
            CmbTest.ItemsSource = ClassConnect._context.Test.ToList();
        }

        private void CmbGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedGroup = Convert.ToInt32(CmbGroup.SelectedValue);
            CmbStudent.ItemsSource = ClassConnect._context.Student.Where
                (x => x.IdGroup == SelectedGroup).ToList();
        }
        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(CmbGroup.Text))
                mes += "Выберите группу\n";
            if (string.IsNullOrWhiteSpace(CmbStudent.Text))
                mes += "Выберите студента\n";
            if (string.IsNullOrWhiteSpace(CmbTest.Text))
                mes += "Выберите тест\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            else if (CmbTest.Text == "Общие основы функционирования субъектов хозяйствования")
            {
                PageTest1 pageTest1 = new PageTest1();
                MenuFrame.Navigate(pageTest1);
            }
            else if (CmbTest.Text == "Сущность и структура основного капитала и оборотных средств предприятия")
            {
                PageTest2 pageTest2 = new PageTest2();
                MenuFrame.Navigate(pageTest2);
            }
            else if (CmbTest.Text == "Формы и системы оплаты труда")
            {
                PageTest3 pageTest3 = new PageTest3();
                MenuFrame.Navigate(pageTest3);
            }
            else if (CmbTest.Text == "Результаты коммерческой деятельности")
            {
                PageTest4 pageTest4 = new PageTest4();
                MenuFrame.Navigate(pageTest4);
            }

            ClassVariable.classman = Convert.ToInt32(CmbStudent.SelectedValue);
        }
    }
}
