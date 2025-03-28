﻿using System;
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
    /// Логика взаимодействия для ListStudentPage.xaml
    /// </summary>
    public partial class ListStudentPage : Page
    {
        private static ZininaMatveevaTestEntities _context = App.GetContext();
        public ListStudentPage()
        {
            InitializeComponent();
            UserDG.ItemsSource = _context.Student.ToList();
            GroupCmb.ItemsSource = _context.Group.ToList();
            StudentCmb.ItemsSource = _context.Student.ToList();
            GroupCmb.DisplayMemberPath = "Name";
            StudentCmb.DisplayMemberPath = "Name";
        }

        private void UserDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
