using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace Equipment {
    public partial class NewRepairs : Form {
        int id=0;
       
        public int ID {
            get {
                return id;
            }
            set {
                id = value;
            }
        }

        public NewRepairs() {
            InitializeComponent();
        }
        void SendInfoToDB(int id) {

            DBManager DB = new DBManager();
            DB.RepName = TBNameOfRep.Text;
            DB.Details = TbDeTails.Text;
            DB.Price = TBPriceGrn.Text + "," + TBPriceCopeck.Text;
            DateTime a = new DateTime();
            DateTime.TryParse (dateTimePicker1.Value.Date.ToShortDateString(),out a);
            DB.RepDate = a;
            Console.WriteLine(dateTimePicker1.Value.Date.ToShortDateString());
            DB.AddRepair(id);

        }
        private void addButton_Click(object sender, EventArgs e) {
            // id = ID;
            if (TBNameOfRep.Text != "") {
                SendInfoToDB(id);

                this.Close();
            }
            else {
                MessageBox.Show("Поле названия работ должно быть заполнено!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void TBPriceGrn_TextChanged(object sender, EventArgs e) {
          
        }

        private void TBPriceGrn_KeyPress(object sender, KeyPressEventArgs e) {
            if (Char.IsPunctuation(e.KeyChar) || Char.IsLetter(e.KeyChar)) {
                TBPriceGrn.ClearUndo();
                TBPriceGrn.Clear();
                TBPriceGrn.Text = "";
                MessageBox.Show("Допустим только числовой ввод");
                e.Handled = true;
                return;

            }
        }

        private void TBPriceGrn_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            
        }

        private void TBPriceCopeck_KeyPress(object sender, KeyPressEventArgs e) {
            if (Char.IsPunctuation(e.KeyChar) || Char.IsLetter(e.KeyChar)) {
                TBPriceGrn.ClearUndo();
                TBPriceGrn.Clear();
                TBPriceGrn.Text = "";
                MessageBox.Show("Допустим только числовой ввод");
                e.Handled = true;
                return;
            }
            if (TBPriceCopeck.TextLength>=2) {
                TBPriceCopeck.ClearUndo();
                TBPriceCopeck.Clear();
                TBPriceCopeck.Text = "";
                MessageBox.Show("Неверный ввод,копейки должны быть указаны максимум 2 символами");
                e.Handled = true;
                return;

            }
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
