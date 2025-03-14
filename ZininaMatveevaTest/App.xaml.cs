using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ZininaMatveevaTest.Model;

namespace ZininaMatveevaTest
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static ZininaMatveevaTestEntities _context;
        public static ZininaMatveevaTestEntities GetContext()
        {
            if (_context == null)
            {
                _context = new ZininaMatveevaTestEntities();
            }
            return _context;
        }
    }
}
