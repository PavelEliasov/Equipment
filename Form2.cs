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
using System.IO;
namespace Equipment {
    public partial class Form2 : Form {
        string imagePath ;
        public Form2() {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {

        }

        private void AddNewEquipment_Click(object sender, EventArgs e) {
            if (TBNameOfNewEq.Text=="" || TBNameOfNewEq.Text ==null) {
                MessageBox.Show("Поле - Название оборудование,не может быть пустым","Null Name",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            DBManager DB = new DBManager();

            DB.EqName     = TBNameOfNewEq.Text;
            DB.InvNumber  = TBInvNum.Text;
            DB.WorkShop   = TBWorkShop.Text;
            DB.Responsible= TBResposible.Text;
            DB.RegDate    = dateTimePicker1.Value.Date;
            DB.Imagepath  = imagePath;
            DB.EditEquipmentTable();


            Program.f1.FillingMainListBox();
            this.Hide();

            #region SQL
            // Console.WriteLine(dateTimePicker1.Text);
            // string EqName = TBNameOfNewEq.Text;
            // string InvNum = TBInvNum.Text;
            // string WorkShop = TBWorkShop.Text;
            // string Responsible = TBResposible.Text;
            // System.DateTime RegDate = dateTimePicker1.Value.Date;


            // SqlCommand cmd = new SqlCommand();
            // cmd.Connection = Program.conn;
            // cmd.CommandText = "INSERT INTO EQUIPMENTS  (InventoryNumber, EqName,WorkShop,Responsible,RegDate,ImagePath) VALUES('" + InvNum
            //                   + "','" + EqName 
            //                   + "','" + WorkShop 
            //                   + "','" + Responsible
            //                   + "','" + RegDate 
            //                   + "','"+imagePath+"')";
            // cmd.ExecuteNonQuery();
            // Program.f1.FillingMainListBox();
            // //Form1 f1 = new Form1();
            // //f1.FillingMainListBox(2);
            //// Program.conn.Close();
            //this.Hide();
            #endregion

        }


        private void Form2_FormClosed(object sender, FormClosedEventArgs e) {
            
        }

        private void addImageButton_Click(object sender, EventArgs e) {
           
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog()==DialogResult.OK) {
                imagePath = ofd.FileName.ToString();
               // Console.WriteLine(imagePath);
                if (File.Exists(imagePath)) {
                    //FileNotExisTB.Hide();
                    try {
                        NewImagePB.Image = Image.FromFile(imagePath);
                        NewImagePB.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (System.Exception ex) {
                       
                        MessageBox.Show(ex.ToString(), "Неудалось открыть файл",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        //MessageBox.Show(;
                    }
                    
                }

            }
            
        }
    }
}
