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
    public partial class EditRepairs : Form {
        int repId;
        public EditRepairs() {
            InitializeComponent();
        }

        public int RepID {
            get{
                return repId;
            }

            set {
                repId = value;
            }
        }

        static string SeparatePriceGrn(string price) {
            string[] aprice = price.Split(',');
            Console.WriteLine(aprice[0]);
            return aprice[0];
        }
        static string SeparatePriceCop(string price) {
            string[] aprice = price.Split(',');
            //Console.WriteLine(aprice[1]);
            if (aprice.Length >1) {
                return aprice[1];
            }
            else {
                return "";
            }
           
        }
        public void FillingEditRepairsForm() {

            DBManager DB = new DBManager();
            DB.FillingEditRepairsForm(repId);
            TBNameOfRepEdit.Text = DB.RepName;
            TbDeTailsEdit.Text = DB.Details;
            TBPriceGrnEdit.Text = DB.PriceGrn;
            TBPriceCopeckEdit.Text = DB.PriceCopeck;
            dateTimePicker1.Value = DB.RepDate;

            //SqlCommand fillCMD = new SqlCommand();
            //fillCMD.Connection = Program.conn;
            //fillCMD.CommandText = "SELECT*FROM Repairs WHERE RepID="+repId+"";//RepName Details  Price DATE
            //SqlDataReader reader = fillCMD.ExecuteReader();

            //while (reader.Read()) {
            //    TBNameOfRepEdit.Text = reader[2].ToString();
            //    TbDeTailsEdit.Text = reader[3].ToString();
            //    TBPriceGrnEdit.Text = SeparatePriceGrn(reader[5].ToString());
            //    TBPriceCopeckEdit.Text = SeparatePriceCop(reader[5].ToString());
            //}
            //reader.Close();


        }

        void ApplyChanges() {
            DBManager DB = new DBManager();
            DB.RepName = TBNameOfRepEdit.Text;
            DB.Details = TbDeTailsEdit.Text;
            DB.PriceGrn = TBPriceGrnEdit.Text;
            DB.PriceCopeck = TBPriceCopeckEdit.Text;
            DB.RepDate = dateTimePicker1.Value.Date;
            DB.ApplyEditRepChanges(repId);
            this.Close();
            //string name = TBNameOfRepEdit.Text;
            //string details = TbDeTailsEdit.Text;
            //string price = TBPriceGrnEdit.Text + "," + TBPriceCopeckEdit.Text;
            //System.DateTime date = dateTimePicker1.Value;

            //System.DateTime RegDate = dateTimePicker1.Value;
            //// System.DateTime.
            ////  Console.WriteLine(RegDate);
            //SqlCommand saveCmd = new SqlCommand();
            //saveCmd.Connection = Program.conn;
            //saveCmd.CommandText = "UPDATE Repairs SET RepName='" + name
            //                    + "',Details='" + details
            //                    + "',RepDate='"    + date
            //                    + "',Price='"   + price
            //                    +  "' WHERE RepID=" +repId+"";
            //saveCmd.ExecuteNonQuery();

            ////Form1 f1 = new Form1();
            ////f1.FillingMainListBox(2);
            //// Program.conn.Close();
            //// this.Hide();
            //this.Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e) {
            ApplyChanges();
        }

        private void TBPriceGrnEdit_KeyPress(object sender, KeyPressEventArgs e) {
            if (Char.IsLetter(e.KeyChar)||Char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("Допустим только числовой ввод", "Неверный формат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void TBPriceCopeckEdit_KeyPress(object sender, KeyPressEventArgs e) {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("Допустим только числовой ввод", "Неверный формат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void canselbutton_Click(object sender, EventArgs e) {

            this.Close();
        }
    }
}
