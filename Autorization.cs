using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipment {
    public partial class Autorization : Form {
        List<Users> users = new List<Users>();
        int numOfUsers=2;

        public int NumOfUsers{
            get{
                return numOfUsers;
            }

            set {
                numOfUsers = value;
            }
        }

        public Autorization() {
            InitializeComponent();

            ShowUsers();
            textBox1.UseSystemPasswordChar = true;
           
            this.Show();
        }

        void ShowUsers() {
            for (int i=0;i<numOfUsers;++i) {
                users.Add(new Users());
                
            }
            users[0].ID = 0;
            users[0].Name = "Администратор";
            users[1].ID = 1;
            users[1].Name = "Пользователь";
            CBSelectUser.DataSource = users;
            CBSelectUser.DisplayMember = "Name";
           



        }
        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void CBSelectUser_SelectedValueChanged(object sender, EventArgs e) {
            AutorityManager manager = AutorityManager.GetInstance();
            if (CBSelectUser.SelectedIndex == 0) {
                // Console.WriteLine(CBSelectUser.SelectedIndex);
                label1.Show();
                textBox1.Show();
                manager.IsAdmin = true;
            }
            else {
                label1.Hide();
                textBox1.Hide();
                manager.IsAdmin = false;
            }
          //  Console.WriteLine(manager.IsAdmin);
        }

        private void selectButton_Click(object sender, EventArgs e) {
            var manager = AutorityManager.GetInstance();
            if (CBSelectUser.SelectedIndex == 0) {
                if (textBox1.Text == "1111") {

                    this.Hide();
                    manager.IsAdmin = true;
                    Program.f1.Show();
                } else {
                    MessageBox.Show("Неверный пароль", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            } else {
                manager.IsAdmin = false;
                this.Hide();
                Program.f1.Show();
                //Console.WriteLine("User");
            }


            
        }
    }
}
