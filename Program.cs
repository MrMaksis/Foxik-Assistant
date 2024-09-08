using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Foxik_Assistant
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            RunApp();
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        static void RunApp()
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}
