using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace Equipment {
    static class Program {
        public static string conStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Equipment; Integrated Security=True";
     //public static  SqlConnection conn;
        public static Form1 f1;
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
          //  OpenConnection();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Autorization autor = new Autorization();
            f1 = new Form1();
            f1.Hide();
            Application.Run(autor);
            //float a = 0;
            ////float.TryParse("22.", out a);
            //Console.WriteLine(float.TryParse("22,3", out a));
            //Console.WriteLine(a);
          
          //  autor.ShowDialog();
        }
        static void OpenConnection() {
          //  conn  = new SqlConnection(Program.conStr);
          //  conn.Open();
            //Console.WriteLine(00000000000000000000000);
            //conn.Close();
        }
        static void CloseConnection() {
           // conn.Close();
        }
    }
}
