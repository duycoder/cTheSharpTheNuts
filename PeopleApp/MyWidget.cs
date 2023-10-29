using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp
{
    public partial class MyWidget
    {
        partial void MyWidgetStart(int count);
        partial void MyWidgetEnd(int count);

        public MyWidget()
        {
            int count = 0;
            MyWidgetStart(count++);
            WriteLine("In the constructor of MyWidget.");
            MyWidgetEnd(++count);
            WriteLine("count = " + count);
        }
    }
}
