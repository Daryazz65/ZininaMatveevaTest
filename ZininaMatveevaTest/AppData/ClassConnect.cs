using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZininaMatveevaTest.Model;

namespace ZininaMatveevaTest.AppData
{
    public class ClassConnect
    {
        public static ZininaMatveevaTestEntities _context = App.GetContext();
    }
}
