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

namespace Equipment {
    public partial class Form3 : Form {
        List<Repairs> repairs = new List<Repairs>();
        ObservableCollection<Repairs> repeirsObserv = new ObservableCollection<Repairs>();
        //   NewRepairs f4 = new NewRepairs();
        delegate void DeleteRepairs();
        event DeleteRepairs onDelete;
        string details;
        string price;
        string date;
        string totalPrice;

        int repID=0;
        int eqID;
        public int EqID {
            get{
                return eqID;
            }

            set {
                eqID = value;
            }
        }

        public int RepID{
            get{
                return repID;
            }

            set {
                repID = value;
            }
        }

        float ttlPrice;




        public Form3() {
            InitializeComponent();

            onDelete = () => { };

             details=TBDetails.Text;
             price=lblPrice.Text;
             date=lblRepDate.Text;
             totalPrice=lblTotalPrice.Text;

            if (AutorityManager.GetInstance().IsAdmin == false) {
                addNewRepairsButton.Hide();
                EditRepairsButton.Hide();
                delRepairsbutton.Hide();
            }

        }

        public void FillingRepairsLB() {
            DBManager DB = new DBManager();
            DB.FillingRepairsLB(eqID);

            LBRepairs.SelectedIndexChanged -= LBRepairs_SelectedIndexChanged;
            LBRepairs.DataSource = null;
            LBRepairs.DataSource = DB.RepairsObserv;
            LBRepairs.DisplayMember = null;
            LBRepairs.DisplayMember = "RepName";
            LBRepairs.ValueMember = "RepID";
            LBRepairs.SelectedIndexChanged += LBRepairs_SelectedIndexChanged;
            ttlPrice = DB.TotalPrice;
            lblTotalPrice.Text = ttlPrice.ToString();
            

        }

        void FillingRepForm() {
            DBManager DB = new DBManager();
            DB.FillingRepForm(this.repID);
            TBDetails.Text = DB.Details;
            lblPrice.Text = DB.Price;
            lblRepDate.Text = DB.RepDate.ToShortDateString();

        }

        void DeleteRepair() {
          
            DBManager DB = new DBManager();
            DB.DeleteRepair(repID);
            FillingRepForm();
            FillingRepairsLB();
          
            if (LBRepairs.Items.Count > 0) {
                LBRepairs.SetSelected(0, true);

            }
          


        }

        void SetDefaultState() {
            TBDetails.Text = details;
            lblPrice.Text = price;
            lblRepDate.Text = date;
            lblTotalPrice.Text = totalPrice;


        }


        private void button3_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void LBRepairs_SelectedIndexChanged(object sender, EventArgs e) {
             repID = (int)LBRepairs.SelectedValue;
             FillingRepForm();
             delRepairsbutton.Enabled = true;
            EditRepairsButton.Enabled = true;
            
        }

        private void addNewRepairsButton_Click(object sender, EventArgs e) {
            NewRepairs newRepForm =new NewRepairs();
            newRepForm.ID = eqID;
            newRepForm.ShowDialog();
        }

        private void Form3_Activated(object sender, EventArgs e) {
         
            FillingRepForm();
            FillingRepairsLB();
            if (LBRepairs.Items.Count == 0) {
                SetDefaultState();
            }

            if (LBRepairs.Items.Count > 0) {
              LBRepairs.SetSelected(0, true);

            }
        }

        private void EdirRepairsButton_Click(object sender, EventArgs e) {
            if (LBRepairs.Items.Count == 0) {

                return;
            }
            EditRepairs edRepForm = new EditRepairs();
            edRepForm.RepID = repID;
            edRepForm.FillingEditRepairsForm();
            edRepForm.ShowDialog();
        }

        private void delRepairsbutton_Click(object sender, EventArgs e) {
            if (LBRepairs.Items.Count == 0) {

                return;
            }
            this.Activated -= new System.EventHandler(this.Form3_Activated);
            //Console.WriteLine(repID);
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?","Delete Repairs",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (result==DialogResult.OK) {
                DeleteRepair();
                this.Activated += new System.EventHandler(this.Form3_Activated);
              
            }
            
        }

        private void LBRepairs_Leave(object sender, EventArgs e) {
          //  delRepairsbutton.Enabled = false;
        }

        private void Form3_Shown(object sender, EventArgs e) {
            if (LBRepairs.Items.Count > 0) {
                  LBRepairs.SetSelected(0, true);

            }
        }
    }
}
