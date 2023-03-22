using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal static class BindingExtension
    {
        public static void DoubleBuffered(this DataGridView dataGridView, bool state)
        {
            var type = dataGridView.GetType();
            var prop = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            Trace.Assert(prop != null, "prop != null");
            prop.SetValue(dataGridView, state, null);
        }
    }
}
