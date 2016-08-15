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
    public partial class EditEquipment : Form {
        int id;
        string imagepath;
        public EditEquipment() {
            InitializeComponent();
          //  Program.f1.fillEditForm += FillEditForm;
        }

        private void label4_Click(object sender, EventArgs e) {

        }
        public void FillEditForm(int id) {//this method called from Form1
            this.id = id;
            DBManager DB = new DBManager();
            DB.FillMainEditForm(id);
            TBInvNumEdit.Text    = DB.InvNumber;
            TBNameOfEditEq.Text  = DB.EqName;
            TBResposibleEdit.Text = DB.Responsible;
            TBWorkShopEdit.Text  = DB.WorkShop;
            dateTimePicker1.Value = DB.RegDate;
            imagepath = DB.Imagepath;
            if (File.Exists(imagepath)) {
                PBaddEditImage.Image = Image.FromFile(imagepath);
                PBaddEditImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
        }

        private void SaveChangesButton_Click(object sender, EventArgs e) {
            DBManager DB = new DBManager();
            DB.EqName = TBNameOfEditEq.Text;
            DB.InvNumber = TBInvNumEdit.Text;
            DB.WorkShop = TBWorkShopEdit.Text;
            DB.Responsible = TBResposibleEdit.Text;
            DB.RegDate = dateTimePicker1.Value;
            DB.Imagepath = imagepath;
            DB.UpdateEquipmentTable(id);
            Program.f1.FillingMainListBox();
            this.Close();

 

        }

        private void addEditImage_Click(object sender, EventArgs e) {
            OpenFileDialog ofd =new OpenFileDialog();
            if (ofd.ShowDialog()==DialogResult.OK) {
                imagepath = ofd.FileName;
                try {
                    PBaddEditImage.Image = Image.FromFile(imagepath);
                    PBaddEditImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch(System.Exception ex) {
                    MessageBox.Show(ex.ToString(), "Неудалось открыть файл", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
