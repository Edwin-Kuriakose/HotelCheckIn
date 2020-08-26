//Edwin Kuriakose

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCheckIn
{
    //global variables
    public static partial class Data
    {
        public static Hotel hilton = new Hotel();

        public static Form1 form1 = new Form1();
        public static reserve r1 = new reserve();
        public static payment p1 = new payment();
    }
    static class Program
    {
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new LogIn());
        }
    }
}
