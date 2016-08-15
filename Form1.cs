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
using System.Collections.ObjectModel;
using System.IO;

namespace Equipment {
    public partial class Form1 : Form {
        public  delegate void EditFormFilling();
        public event EditFormFilling fillEditForm;

        string idlbl;
        string invnum;
        string resp;
        string workshop;
        string date;
        
        int id=0;
        EditEquipment editEQForm; 
       
        ObservableCollection<EQNameID> eqNameIDObserv = new ObservableCollection<EQNameID>();
        public Form1() {
            fillEditForm = () => { };

            InitializeComponent();
             idlbl=Main_lbl_ID.Text;
             invnum=Main_lbl_Inventory.Text;
             resp=Main_lbl_Resp.Text;
             workshop = Main_lbl_WorkSh.Text;
             date=Main_lbl_Date.Text;
            FillingMainListBox();

        }


        void SetDefault() {
             Main_lbl_ID.Text= idlbl ;
             Main_lbl_Inventory.Text= invnum ;
             Main_lbl_Resp.Text = resp ;
             Main_lbl_WorkSh.Text = workshop ;
             Main_lbl_Date.Text= date ;


        }

       public void FillingMainListBox() {
            DBManager DB = new DBManager();
            DB.FillingMainListBox();
            LBEquipments.SelectedIndexChanged -= LBEquipments_SelectedIndexChanged;//отписываем ListBox От события т.к. при изхменении DataSource вызывается это событие
            LBEquipments.DataSource = null;
            LBEquipments.DataSource = DB.EqNameIDObserv;
            LBEquipments.DisplayMember = null;

            LBEquipments.DisplayMember = "Name";
            LBEquipments.ValueMember = "ID";
            LBEquipments.SelectedIndexChanged += LBEquipments_SelectedIndexChanged;


            #region SQL
            //  eqNameIDObserv.Clear();

            //  SqlCommand fillCmd = new SqlCommand();
            //  fillCmd.Connection = Program.conn;
            //  fillCmd.CommandText = "SELECT ID,EqName FROM Equipments ";
            //  SqlDataReader reader = fillCmd.ExecuteReader();
            //  int i = 0;
            //  while (reader.Read()) {

            //      eqNameIDObserv.Add(new EQNameID());
            //      eqNameIDObserv[i].ID= (int)reader[0];
            //      eqNameIDObserv[i].Name= reader[1].ToString(); 

            //      i++;
            //  }
            //  reader.Close();
            //  LBEquipments.SelectedIndexChanged -= LBEquipments_SelectedIndexChanged;//отписываем ListBox От события т.к. при изхменении DataSource вызывается это событие
            //  LBEquipments.DataSource = null;
            //  LBEquipments.DataSource = eqNameIDObserv;
            //  LBEquipments.DisplayMember = null;

            //  LBEquipments.DisplayMember = "Name";
            //  LBEquipments.ValueMember = "ID";
            //  LBEquipments.SelectedIndexChanged += LBEquipments_SelectedIndexChanged;
            //  Console.WriteLine("filling LB");
            //  //LBEquipments.EndUpdate();
            ////  manager.Refresh();
            #endregion

        }

        void MainListBoxIndexChanged(int iditem) {
            string imagepath = "";
            DBManager DB = new DBManager();
            DB.MainListBoxIndexChanged(iditem);
            Main_lbl_ID.Text = iditem.ToString();
            Main_lbl_Inventory.Text = DB.InvNumber;
            Main_lbl_WorkSh.Text = DB.WorkShop;
            Main_lbl_Resp.Text = DB.Responsible;
            Main_lbl_Date.Text = DB.RegDate.ToString();
            imagepath = DB.Imagepath;
            if (File.Exists(imagepath)) {
                FileNotExisTB.Hide();
                MainPB.Image = Image.FromFile(imagepath);
                MainPB.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else {
                MainPB.Image = null;
                FileNotExisTB.Show();
            }

            #region SQL
            // string imagepath = "";
            // Console.WriteLine("ItemSelected");
            // SqlCommand itemSelect_Cmd = new SqlCommand();
            // itemSelect_Cmd.Connection = Program.conn;


            // Main_lbl_ID.Text = iditem.ToString();

            // itemSelect_Cmd.CommandText = "SELECT *FROM Equipments WHERE ID=" + iditem + "";

            ////= itemSelect_Cmd.ExecuteScalar().ToString();
            //SqlDataReader reader = itemSelect_Cmd.ExecuteReader();

            // while (reader.Read()) {
            //     Main_lbl_Inventory.Text = reader["InventoryNumber"].ToString();
            //     Main_lbl_WorkSh.Text = reader["Workshop"].ToString();
            //     Main_lbl_Resp.Text= reader["Responsible"].ToString();
            //     Main_lbl_Date.Text = reader["RegDate"].ToString();
            //     imagepath = reader["ImagePath"].ToString();
            //     //  Console.WriteLine(reader[1].ToString());

            // }
            // reader.Close();
            // if (File.Exists(imagepath)) {
            //     FileNotExisTB.Hide();
            //     MainPB.Image = Image.FromFile(imagepath);
            //     MainPB.SizeMode = PictureBoxSizeMode.StretchImage;
            // }
            // else {
            //     MainPB.Image=null;
            //     FileNotExisTB.Show();
            // }
            #endregion

        }

        void DeleteEquipment() {
            DBManager DB = new DBManager();
            DB.DeleteEquipment(id);

            this.FillingMainListBox();

            if (LBEquipments.Items.Count > 0) {
                LBEquipments.SetSelected(0, true);

            }

            if (LBEquipments.Items.Count == 0) {
                SetDefault();

            }


        }

        private void AddEquipmentTool_Click(object sender, EventArgs e) {
            Form2 f2 = new Form2() ;
            f2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
           // Program.conn.Close();
            Console.WriteLine("Form has been Closed");
            Application.Exit();
        }

        private void LBEquipments_SelectedIndexChanged(object sender, EventArgs e) {
           
            string strid= LBEquipments.SelectedValue.ToString();
            //int id = 0;
            int.TryParse(strid,out id);
            MainListBoxIndexChanged(id);

       }
        private void AddNewItemButton_Click(object sender, EventArgs e) {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

       

        private void label8_Click(object sender, EventArgs e) {

        }

        private void detailsButton_Click(object sender, EventArgs e) {
            if (LBEquipments.Items.Count == 0) {
                return;

            }
            Form3 f3 = new Form3();
            f3.EqID = id;
            f3.ShowDialog();
        }

        private void Form1_Shown(object sender, EventArgs e) {
            if (AutorityManager.GetInstance().IsAdmin == false) { 
                AddNewItemButton.Hide();
                EditMainButton.Hide();
                delEqbutton.Hide();
                AddEquipmentTool.Enabled=false;
            }
           

        }



        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Form1_Activated(object sender, EventArgs e) {
            DBManager DB = new DBManager();
            DB.CalculateTotalPrice();
            lblTotalPrice.Text = DB.TotalPrice.ToString();
            if (LBEquipments.Items.Count > 0) {
                LBEquipments.SetSelected(0, true);

            }

            if (LBEquipments.Items.Count == 0) {
                SetDefault();

            }
        }


        private void EditMainButton_Click(object sender, EventArgs e) {
            if (LBEquipments.Items.Count == 0) {
                return;
            }

            editEQForm = new EditEquipment();
            string strid = LBEquipments.SelectedValue.ToString();
            int.TryParse(strid, out id);
            editEQForm.FillEditForm(id);

            editEQForm.ShowDialog();

        }

        private void delEqbutton_Click(object sender, EventArgs e) {
            if (LBEquipments.Items.Count==0) {
                return;
            }

            this.Activated -= new System.EventHandler(this.Form1_Activated);
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись из списка?", "Delete Equipment", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK) {
                DeleteEquipment();
                this.Activated += new System.EventHandler(this.Form1_Activated);
                // Console.WriteLine(id);
            }

        }

        
    }
}
