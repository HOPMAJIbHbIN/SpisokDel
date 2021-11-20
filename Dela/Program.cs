using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic;
using System.Runtime.Serialization.Formatters.Binary;
using Dela.Manager;

namespace Dela
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasker tasker = new Tasker();
            tasker.Chtenie();
            Menu menu = new Menu(tasker);
            menu.Show();

        }
    }
}
