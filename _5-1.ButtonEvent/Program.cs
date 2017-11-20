using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_1.ButtonEvent
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {





            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //code 5-1
            //Button button = new Button();
            //button.Text = "Click me";
            //button.Click += new EventHandler(LogPlainEvent);
            //button.KeyPress += new KeyPressEventHandler(LogKeyEvent);
            //button.MouseClick += new MouseEventHandler(LogMouseEvent);




            //code 5-2 simplify from 5-1

            Button button = new Button();
            button.Text = "Click me";
            button.Click += LogPlainEvent;
            button.KeyPress += LogKeyEvent;
            button.MouseClick += LogMouseEvent;


            Form form = new Form();
            form.AutoSize = true;
            form.Controls.Add(button);

            Application.Run(form);
        }
        static void LogPlainEvent(object sender, EventArgs e)
        {
            Console.WriteLine("LogPlain");
        }

        static void LogKeyEvent(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("LogKey");
        }

        static void LogMouseEvent(object sender, MouseEventArgs e)
        {
            Console.WriteLine("LogMouse");
        }
    }
}
