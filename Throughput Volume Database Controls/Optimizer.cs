using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Throughput_Volume_Database_Controls
{
    class Optimizer
    {
        public static void SetDoubleBuffered(Control control)
        {

            control.GetType().InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null,
                control, new object[] { true });
        }
    }
}
